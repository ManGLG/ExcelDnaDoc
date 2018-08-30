namespace ExcelDnaDoc.Templates
{
    using ExcelDna.Documentation.Models;

    public class CommandView : ViewBase<CommandModel>
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
                    ? Properties.Resources.CommandTemplate
                    : Properties.Resources.CommandTemplateMD;
            }
        }
    }
}
