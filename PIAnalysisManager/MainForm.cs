/**********************************************************
|  App Name: PI Analysis Manager
|  Author:   David Eftink
|  Date:     10/1/2020
|  Version:  2.3
***********************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OSIsoft.AF;

namespace PIAnalysisManager
{
    public partial class MainForm : Form
    {
        List<AnalysisDataItem> listAnalysisDataItems = new List<AnalysisDataItem>();

        public MainForm()
        {
            InitializeComponent();

            // Connect the PI System Picker to the AF DB Picker
            afDatabasePicker1.SystemPicker = piSystemPicker1;

        }
                      
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (afDatabasePicker1.AFDatabase != null)
                {
                    // Clear variables
                    txtMessage.Text = "";
                    BindingSource tableBinding = new BindingSource();
                    listAnalysisDataItems.Clear();

                    // Disable search button
                    btnSearch.Text = "Running...";
                    btnSearch.Enabled = false;

                    // Run AF Analysis Search 
                    listAnalysisDataItems = AnalysisController.RunAFSearch(afDatabasePicker1.AFDatabase, txtElementName.Text, txtAnalysisTemplate.Text);

                    // Bind search results to data grid
                    dataGridView1.DataSource = tableBinding;
                    tableBinding.DataSource = listAnalysisDataItems;

                    // Update output message
                    txtMessage.Text = "Analyses Found: " + listAnalysisDataItems.Count;

                    // Enable buttons
                    btnSearch.Enabled = true;
                    btnSearch.Text = "Analysis Search";
                    chkSelectAll.Enabled = true;
                    btnBackfill.Enabled = true;
                    btnEnable.Enabled = true;
                    btnDisable.Enabled = true;
                    btnExportCSV.Enabled = true;
                    chkSelectAll.Checked = false;
                }
                else
                {
                    txtMessage.Text = "No AF DB Selected";
                }
            }

            catch (Exception ex)
            {
                txtMessage.Text = ex.Message;
            }
        }

        private void btnBackfill_Click(object sender, EventArgs e)
        {
            try
            {
                PISystem piSys = afDatabasePicker1.PISystem;

                bool flagRecalc = false;
                string resultMsg = "";
                
                string startTime = txtStartTime.Text;
                string endTime = txtEndTime.Text;

                // Validate Times and Backfill/Recalculate
                if (AnalysisController.ValidateAFTimeRange(startTime, endTime, out resultMsg) == true)
                {
                    // check if Delete and Recalculate
                    if (radRecalc.Checked)
                    {
                        flagRecalc = true;
                    }

                    // Run AF Analysis Backfill
                    int selectedCount = AnalysisController.RunBackfill(piSys, startTime, endTime, listAnalysisDataItems, flagRecalc);

                    if (selectedCount > 0)
                    {
                        // write output message
                        txtMessage.Text = "Analyses Queued for Backfill: " + selectedCount.ToString();
                    }
                    else
                    {
                        txtMessage.Text = "No Analyses Selected in Grid";
                    }
                }
                else
                {
                    // Invalid start or end times
                    txtMessage.Text = resultMsg;
                }
            }

            catch (Exception ex)
            {
                txtMessage.Text = ex.Message;
            }

        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            try
            {
                // set status on Analyses
                int selectedCount = AnalysisController.SetAnalysesStatus(listAnalysisDataItems, OSIsoft.AF.Analysis.AFStatus.Disabled);

                if (selectedCount > 0)
                {
                    txtMessage.Text = "Disabled Analyses: " + selectedCount.ToString();
                    dataGridView1.Refresh();
                }
                else
                {
                    txtMessage.Text = "No Analyses Selected in Grid";
                }
            }

            catch (Exception ex)
            {
                txtMessage.Text = ex.Message;
            }
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            try
            {
                // set status on Analyses
                int selectedCount = AnalysisController.SetAnalysesStatus(listAnalysisDataItems, OSIsoft.AF.Analysis.AFStatus.Enabled);

                if (selectedCount > 0)
                {
                    txtMessage.Text = "Enabled Analyses: " + selectedCount.ToString();
                    dataGridView1.Refresh();
                }
                else
                {
                    txtMessage.Text = "No Analyses Selected in Grid";
                }
            }

            catch (Exception ex)
            {
                txtMessage.Text = ex.Message;
            }
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // select or deselect all Analyses in Grid
                if (listAnalysisDataItems.Count > 0)
                {
                    if (chkSelectAll.Checked)
                    {
                        foreach (AnalysisDataItem dataItem in listAnalysisDataItems)
                        {
                            dataItem.Select = true;
                        }
                    }
                    else
                    {
                        foreach (AnalysisDataItem dataItem in listAnalysisDataItems)
                        {
                            dataItem.Select = false;
                        }
                    }
                    // refresh data grid
                    dataGridView1.Refresh();
                }
            }

            catch (Exception ex)
            {
                txtMessage.Text = ex.Message;
            }
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            try
            {
                // Export if data in grid
                if (listAnalysisDataItems.Count > 0)
                {
                    // Open Save Dialog
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.FileName = "PIAnalysis_" + afDatabasePicker1.AFDatabase.Name;
                    saveDialog.Filter = "CSV file (*.csv)|*.csv|All files (*.*)|*.*";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Export Data Grid to CSV file
                        AnalysisController.ExportAnalysisDataToCSV(listAnalysisDataItems, saveDialog.FileName);
                        txtMessage.Text = "Export File Created: " + saveDialog.FileName;
                    }
                }
                else
                {
                    txtMessage.Text = "No Grid Data to Export";
                }
            }

            catch (Exception ex)
            {
                txtMessage.Text = ex.Message;
            }
        }
    }
}
