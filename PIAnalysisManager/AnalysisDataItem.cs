/**********************************************************
|  Class:    AnalysisDataItem
|  Author:   David Eftink
|  Date:     10/1/2020
***********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OSIsoft.AF.Asset;
using OSIsoft.AF.Analysis;

namespace PIAnalysisManager
{
    // Class to encapsulate a single AF Analysis for the Data Grid
    public class AnalysisDataItem
    {
        private AFAnalysis afAnalysis = null;
        private bool selected = false;

        public AnalysisDataItem()
        {
            this.afAnalysis = null;
        }

        public AnalysisDataItem(AFAnalysis analysis)
        {
            this.afAnalysis = analysis;
        }

        public bool Select
        {
            get
            {
                return this.selected;
            }
            set
            {
                this.selected = value;
            }
        }

        public string ElementPath
        {
            get
            {
                // return just the AF Element Path, ignore AF Server & Analysis Template Name
                // cast as AFElement and use AF GetPath method to return AF Element Path
                return (this.afAnalysis.Target as AFElement).GetPath(this.afAnalysis.Database);
            }
        }

        public string ElementName
        {
            get
            {
                return this.afAnalysis.Target.ToString();
            }
        }

        public string AnalysisName
        {
            get
            {
                return this.afAnalysis.Name;
            }
        }

        public string AnalysisTemplate
        {
            get
            {
                string template = "";
                if (this.afAnalysis.HasTemplate)
                {
                    template = this.afAnalysis.Template.Name;
                }
                return template;
            }
        }

        public string AnalysisType
        {
            get
            {
                return this.afAnalysis.AnalysisRule.Name;
            }
        }

        public string Status
        {
            get
            {
                return this.afAnalysis.Status.ToString();
            }
        }

        public AFAnalysis GetAnalysisObject()
        {
            return this.afAnalysis;
        }

        public void SetAnalysisObject(AFAnalysis analysis)
        {
            this.afAnalysis = analysis;
        }
    }
}
