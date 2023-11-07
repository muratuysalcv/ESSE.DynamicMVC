using DynamicMVC.DynamicEntityMetadataLibrary.Core.Models;
using DynamicMVC.Core.DynamicMVC.ViewModels.DynamicPropertyViewModels;

namespace DynamicMVC.Core.DynamicMVC.Interfaces
{
    public interface IDynamicDisplayPartialModelBuilder
    {
        string DynamicDisplayPartialName();
        void Build(DynamicPropertyMetadata dynamicPropertyMetadata, DynamicPropertyIndexViewModel dynamicPropertyIndexViewModel, dynamic item);
    }
}