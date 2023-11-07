using DynamicMVC.DynamicEntityMetadataLibrary.Core.Models;
using DynamicMVC.Core.DynamicMVC.ViewModels.DynamicPropertyViewModels;

namespace DynamicMVC.Core.DynamicMVC.Interfaces
{
    public interface IDynamicEditorModelBuilder
    {
        string DynamicEditorName();
        void Build(DynamicPropertyMetadata dynamicPropertyMetadata, DynamicPropertyEditorViewModel dynamicPropertyViewModel, dynamic item);
    }
}