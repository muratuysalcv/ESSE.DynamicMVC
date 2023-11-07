using System.Collections.Generic;
using DynamicMVC.DynamicEntityMetadataLibrary.Core.Models;

namespace DynamicMVC.DynamicEntityMetadataLibrary.Core.Interfaces
{
    public interface IDynamicEntityMetadataPropertyFixup
    {
        void Fixup(IEnumerable<DynamicEntityMetadata> dynamicEntityMetadatas);
        int Order();
    }
}
