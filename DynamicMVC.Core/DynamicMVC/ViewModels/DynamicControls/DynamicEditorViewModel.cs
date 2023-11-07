using DynamicMVC.Core.DynamicMVC.ViewModels.DynamicPropertyViewModels;

namespace DynamicMVC.Core.DynamicMVC.ViewModels.DynamicControls
{
    public class DynamicEditorViewModel
    {
        public string ViewModelPropertyName { get; set; }
        public string DynamicEditorName { get; set; }
        public DynamicPropertyEditorViewModel DynamicPropertyEditorViewModel { get; set; }
    }
}
