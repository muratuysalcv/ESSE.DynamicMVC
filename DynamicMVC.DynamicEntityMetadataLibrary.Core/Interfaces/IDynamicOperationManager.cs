using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicMVC.Annotations.Enums;
using DynamicMVC.DynamicEntityMetadataLibrary.Core.Models;

namespace DynamicMVC.DynamicEntityMetadataLibrary.Core.Interfaces
{
    public interface IDynamicOperationManager
    {
        DynamicOperation GetDynamicOperation(TemplateTypeEnum templateTypeEnum, string submitValue, IEnumerable<DynamicMethod> dynamicMethods);
    }
}
