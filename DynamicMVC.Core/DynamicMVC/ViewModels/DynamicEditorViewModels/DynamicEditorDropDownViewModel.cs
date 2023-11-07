using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DynamicMVC.Core.DynamicMVC.ViewModels.DynamicEditorViewModels
{
    public class DynamicEditorDropDownViewModel
    {
        public DynamicEditorDropDownViewModel()
        {

        }

        public DynamicEditorDropDownViewModel(Type type, string dataTextField, string dataValueField)
            : this()
        {
            Type = type;
            DataTextField = dataTextField;
            DataValueField = dataValueField;
        }
        public Type Type { get; set; }
        public string DataTextField { get; set; }
        public string DataValueField { get; set; }
        public List<SelectListItem> SelectListItems { get; set; }
    }
}
