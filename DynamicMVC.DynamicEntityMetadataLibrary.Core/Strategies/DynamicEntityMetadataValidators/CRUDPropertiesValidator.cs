using DynamicMVC.DynamicEntityMetadataLibrary.Core.Interfaces;
using DynamicMVC.DynamicEntityMetadataLibrary.Core.Models;

namespace DynamicMVC.DynamicEntityMetadataLibrary.Core.Strategies.DynamicEntityMetadataValidators
{
    public class CRUDPropertiesValidator : IDynamicEntityMetadataValidator
    {
        public string Validate(DynamicEntityMetadata dynamicEntityMetadata)
        {
            if (dynamicEntityMetadata.ScaffoldIndexProperties() == null)
                return "ScaffoldIndexProperties should not be null for DynamicEntity " + dynamicEntityMetadata.TypeName();

            return null;
        }
    }
}
