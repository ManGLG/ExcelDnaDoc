namespace ExcelDnaDoc.Templates
{
    using ExcelDna.Documentation.Models;

    public class CategoryView : ViewBase<CategoryModel>
    {
        public override string PageName
        {
            get
            {
                return OutputType == OutputType.Html
                    ? this.Model.Name + " Functions.htm"
                    : this.Model.Name.Replace(" ", "-") + "-Functions.md";
            }
        }

        public override byte[] Template 
        {
            get
            {
                return OutputType == OutputType.Html
                    ? Properties.Resources.CategoryTemplate
                    : Properties.Resources.CategoryTemplateMD;
            } 
        }
    }
}
