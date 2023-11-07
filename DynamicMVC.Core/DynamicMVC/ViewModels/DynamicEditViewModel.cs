using System.Collections.Generic;
using DynamicMVC.Annotations;
using DynamicMVC.DynamicEntityMetadataLibrary.Core.Models;
using DynamicMVC.Core.DynamicMVC.ViewModels.DynamicControls;

#pragma warning disable 1591

namespace DynamicMVC.Core.DynamicMVC.ViewModels
{
    public class DynamicEditViewModel
    {
        public DynamicEditViewModel()
        {
            DynamicEditorViewModels = new HashSet<DynamicEditorViewModel>();
            DynamicUIMethods=new HashSet<DynamicMethod>();
            Title = "Edit";
            ButtonText = "Save";
        }

        public string Header { get; set; }
        public string TypeName { get; set; }
        public string ReturnUrl { get; set; }
        public string Title { get; set; }
        public string ButtonText { get; set; }
        public dynamic Item { get; set; }

       
        public ICollection<DynamicEditorViewModel> DynamicEditorViewModels { get; set; }
        public ICollection<DynamicMethod> DynamicUIMethods { get; set; }
    }
}
