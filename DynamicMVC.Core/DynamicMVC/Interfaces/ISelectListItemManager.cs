using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DynamicMVC.Core.DynamicMVC.Interfaces
{
    public interface ISelectListItemManager
    {
        List<SelectListItem> GetSelectListItems(Type type, string valueFieldName, string textFieldName, object selectedItem = null, string nullText = null);
        List<SelectListItem> GetSelectListItemForBooleanDropDown(bool? value, string nullText);
    }
}