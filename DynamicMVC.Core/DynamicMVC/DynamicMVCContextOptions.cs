namespace DynamicMVC.Core.DynamicMVC
{
    public class DynamicMVCContextOptions
    {
        public DynamicMVCContextOptions()
        {
            DynamicDropDownRecordLimit = 50;
        }

        public long DynamicDropDownRecordLimit { get; set; }
    }
}