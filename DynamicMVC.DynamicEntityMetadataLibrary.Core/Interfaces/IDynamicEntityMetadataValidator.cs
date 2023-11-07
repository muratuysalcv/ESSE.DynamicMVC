using DynamicMVC.DynamicEntityMetadataLibrary.Core.Models;

namespace DynamicMVC.DynamicEntityMetadataLibrary.Core.Interfaces
{
    public interface IDynamicEntityMetadataValidator
    {
        string Validate(DynamicEntityMetadata dynamicEntityMetadata);
    }
}
