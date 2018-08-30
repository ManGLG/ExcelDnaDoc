namespace ExcelDnaDoc.Templates
{
    using ExcelDna.Documentation.Models;

    public class FunctionView : ViewBase<FunctionModel>
    {
        public override string PageName
        {
            get { return this.Model.Name + (OutputType==OutputType.Html ? ".htm" : ".md"); }
        }

        public override byte[] Template
        {
            get
            {
                return OutputType == OutputType.Html
                    ? Properties.Resources.FunctionTemplate
                    : Properties.Resources.FunctionTemplateMD;
            }
        }
    }
}
