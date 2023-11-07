#pragma warning disable 1591
namespace DynamicMVC.Core.DynamicMVC.Interfaces
{
    public interface IDynamicDisplayName
    {
        string DisplayName { get; set; }
        string ViewModelPropertyName { get; set; }
    }
}
