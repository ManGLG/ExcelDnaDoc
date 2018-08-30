namespace ExcelDnaDoc.Templates
{
    using ExcelDna.Documentation.Models;

    public class CommandListView : ViewBase<AddInModel>
    {
        public override string PageName
        {
            get
            {
                return OutputType == OutputType.Html
                    ? this.Model.ProjectName + " Commands.htm"
                    : this.Model.ProjectName.Replace(" ", "-") + "-Commands.md";
            }
        }

        public override byte[] Template
        {
            get
            {
                return OutputType == OutputType.Html
                    ? Properties.Resources.CommandListTemplate
                    : Properties.Resources.CommandListTemplateMD;
            }
        }
    }
}