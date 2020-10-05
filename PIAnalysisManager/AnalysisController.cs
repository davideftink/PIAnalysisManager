/**********************************************************
|  Class:    AnalysisController
|  Author:   David Eftink
|  Date:     10/4/2020
***********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OSIsoft.AF;
using OSIsoft.AF.Analysis;
using OSIsoft.AF.Search;
using OSIsoft.AF.Time;

namespace PIAnalysisManager
{
    public static class AnalysisController
    {
        // Runs an AF Analysis Search and returns a list of Analysis Data Items
        public static List<AnalysisDataItem> RunAFSearch(AFDatabase afDB, string searchElement, string searchTemplate)
        {
            List<AnalysisDataItem> listAnalysisItems = new List<AnalysisDataItem>();

            // Create a search query by Element Name or Analysis Template Name
            string searchQuery = string.Format("TargetName:'{0}' TemplateName:'{1}'", searchElement, searchTemplate);

            IList<AFSearchToken> listAFSearch = AFAnalysisSearch.ParseQuery(searchQuery);

            // Run AF Analysis Search
            // add using statement to automatically close the search and clear cache on the server
            using (AFAnalysisSearch search = new AFAnalysisSearch(afDB, "theAFSearch", listAFSearch))
            {
                // using caching for better performance
                search.CacheTimeout = TimeSpan.FromMinutes(10);

                // Loop thru each Analysis in search and add to List for the Data Grid
                foreach (AFAnalysis item in search.FindAnalyses(fullLoad: true, pageSize: 1000))
                {
                    AnalysisDataItem row = new AnalysisDataItem(item);
                    listAnalysisItems.Add(row);
                }
            }

            return listAnalysisItems;
        }
        
        // Runs an AF Analysis Backfill on a list of Analysis Data Items
        public static int RunBackfill(PISystem ps, string startTime, string endTime, List<AnalysisDataItem> listAnalysisItems, bool flagRecalc)
        {
            List<AFAnalysis> listAnalyses = new List<AFAnalysis>();

            AFAnalysisService afAnalysisSvc = ps.AnalysisService;

            AFAnalysisService.CalculationMode calcMode = AFAnalysisService.CalculationMode.FillDataGaps;

            AFTime afStartTime;
            AFTime afEndTime;

            afStartTime = AFTime.Parse(startTime);
            afEndTime = AFTime.Parse(endTime);

            AFTimeRange afTimeRange = new AFTimeRange(afStartTime, afEndTime);

            // Backfill selected Analyses in the Data Grid
            foreach (AnalysisDataItem dataItem in listAnalysisItems)
            {
                if (dataItem.Select)
                {
                    listAnalyses.Add(dataItem.GetAnalysisObject());
                }
            }

            // if Analyses are selected, then queue Backfill Calculation
            if (listAnalyses.Count > 0)
            {
                // Delete and Recalculate
                if (flagRecalc)
                {
                    calcMode = AFAnalysisService.CalculationMode.DeleteExistingData;
                }

                // Backfill only the selected Analyses in the Data Table Grid
                afAnalysisSvc.QueueCalculation(listAnalyses, afTimeRange, calcMode);
            }

            return listAnalyses.Count;
        }

        public static int SetAnalysesStatus(List<AnalysisDataItem> listAnalysisItems, AFStatus status)
        {
            List<AFAnalysis> listAnalyses = new List<AFAnalysis>();

            // find selected Analyses, and then Enable
            foreach (AnalysisDataItem dataItem in listAnalysisItems)
            {
                if (dataItem.Select)
                {
                    listAnalyses.Add(dataItem.GetAnalysisObject());
                }
            }

            if (listAnalyses.Count > 0)
            {
                // Set Status on Analyses
                AFAnalysis.SetStatus(listAnalyses, status);
            }

            return listAnalyses.Count;
        }

        public static void ExportAnalysisDataToCSV(List<AnalysisDataItem> listAnalysisItems, string csvPath)
        {
            using (StreamWriter csvWriter = new StreamWriter(csvPath, false))
            {
                // Write CSV column headers
                string delimiter = ",";
                string rowData = "Selected(x),Name,ObjectType,Parent,Template,AnalysisStatus,AnalysisRule";

                csvWriter.WriteLine(rowData);

                foreach (AnalysisDataItem dataItem in listAnalysisItems)
                {
                    string selected = "";

                    // Build CSV row data
                    if (dataItem.Select)
                    {
                        selected = "x";
                    }
                    rowData = String.Join(delimiter, selected, dataItem.AnalysisName, "Analysis", dataItem.ElementPath, dataItem.AnalysisTemplate, dataItem.Status, dataItem.AnalysisType);
                    csvWriter.WriteLine(rowData);
                }
            }
        }

        public static bool ValidateAFTimeRange(string startTime, string endTime, out string resultMsg)
        {
            bool isValid = true;
            bool startValid = false;
            bool endValid = false;
            resultMsg = "";
            AFTime startTest;
            AFTime endTest;

            // Validate AF Times and return message
            startValid = AFTime.TryParse(startTime, out startTest);
            endValid = AFTime.TryParse(endTime, out endTest);

            if (!startValid & endValid)
            {
                resultMsg = "Invalid start time";
                isValid = false;
            }

            if (startValid & !endValid)
            {
                resultMsg = "Invalid end time";
                isValid = false;
            }

            if (!startValid & !endValid)
            {
                resultMsg = "Invalid start & end times";
                isValid = false;
            }
            
            return isValid;
        }

    } // End of Class
}
