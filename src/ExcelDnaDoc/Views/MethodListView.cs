namespace ExcelDnaDoc.Templates
{
    using ExcelDna.Documentation.Models;

    public class MethodListView : ViewBase<AddInModel>
    {
        public override string PageName
        {
            get { return (OutputType==OutputType.Html ? "index.htm" : "index.md"); }
        }

        public override byte[] Template
        {
            get
            {
                return OutputType == OutputType.Html
                    ? Properties.Resources.MethodListTemplate
                    : Properties.Resources.MethodListTemplateMD;
            }
        }
    }
}
