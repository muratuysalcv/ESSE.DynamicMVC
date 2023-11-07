using Microsoft.AspNetCore.Mvc;
using DynamicMVC.DynamicEntityMetadataLibrary.Core.Models;
using DynamicMVC.Core.DynamicMVC.ViewModels.DynamicEditorViewModels;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace DynamicMVC.Core.DynamicMVC.ViewModels.DynamicPropertyViewModels
{
    public class DynamicPropertyIndexViewModel : DynamicPropertyViewModel
    {
        public DynamicPropertyIndexViewModel(DynamicPropertyMetadata dynamicPropertyMetadata) : base(dynamicPropertyMetadata)
        {
            
        }

        //These are used in mobile page only
        public bool AllowSort { get; set; }
        public string SortExpression { get; set; }

        public string PartialViewName { get; set; }
        public DynamicEditorHyperlinkViewModel DynamicEditorHyperlinkViewModel { get; set; }
        public ViewDataDictionary ToViewDataDictionary()
        {
            var vdd = new ViewDataDictionary(this.ToViewDataDictionary());
            vdd.Add("DynamicPropertyViewModel", this);
            return vdd;
        }
    }
}