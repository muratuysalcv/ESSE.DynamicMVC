using DynamicMVC.DynamicEntityMetadataLibrary.Core.Models;
using DynamicMVC.Core.DynamicMVC.ViewModels.DynamicPropertyViewModels;

namespace DynamicMVC.Core.DynamicMVC.Interfaces
{
    public interface IDynamicPropertyViewModelBuilder
    {
        DynamicPropertyIndexViewModel BuildDynamicPropertyIndexViewModel(DynamicPropertyMetadata dynamicPropertyMetadata);
        DynamicPropertyEditorViewModel BuildDynamicPropertyEditorViewModelForEdit(DynamicPropertyMetadata dynamicPropertyMetadata);
        DynamicPropertyEditorViewModel BuildDynamicPropertyEditorViewModelForCreate(DynamicPropertyMetadata dynamicPropertyMetadata);
        DynamicPropertyEditorViewModel BuildDynamicPropertyEditorViewModelForDetails(DynamicPropertyMetadata dynamicPropertyMetadata);
    }
}