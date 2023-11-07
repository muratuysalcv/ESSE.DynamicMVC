using System.Collections;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DynamicMVC.Annotations.Enums;
using DynamicMVC.Data.Interfaces;
using DynamicMVC.Shared.Enums;
using DynamicMVC.Core.DynamicMVC;
using DynamicMVC.Core.DynamicMVC.Extensions;
using DynamicMVC.Core.DynamicMVC.Interfaces;
using Microsoft.AspNetCore.Http;

namespace DynamicMVC.Core.Controllers {
    [CorrectQueryStringTypesActionFilter]
    public class DynamicController : DynamicControllerBase {
        public DynamicController(IDynamicRepository dynamicRepository, IRequestManager requestManager, IDynamicEntitySearchManager dynamicEntitySearchManager, IReturnUrlManager returnUrlManager, IDynamicIndexViewModelBuilder dynamicIndexViewModelBuilder, IDynamicCreateViewModelBuilder dynamicCreateViewModelBuilder, IDynamicEditViewModelBuilder dynamicEditViewModelBuilder, IDynamicDeleteViewModelBuilder dynamicDeleteViewModelBuilder, IDynamicDetailsViewModelBuilder dynamicDetailsViewModelBuilder, IDynamicIndexPageViewModelBuilder dynamicIndexPageViewModelBuilder)
            : base(dynamicRepository, requestManager, dynamicEntitySearchManager, returnUrlManager, dynamicIndexViewModelBuilder, dynamicCreateViewModelBuilder, dynamicEditViewModelBuilder, dynamicDeleteViewModelBuilder, dynamicDetailsViewModelBuilder, dynamicIndexPageViewModelBuilder) {
        }

        public virtual ActionResult Index(string defaultOrderBy) {
            if (_requestManager.PagingParametersDoNotExist()) {
                _requestManager.AddPagingParameters(defaultOrderBy, 1, 10, KeyName);
                return RedirectToAction("Index", TypeName, _requestManager.RouteValueDictionaryWrapper().GetRouteValueDictionary());
            }
            var viewModel = _dynamicIndexViewModelBuilder.Build(DynamicEntityMetadata);
            return View("DynamicIndex", viewModel);
        }

        public virtual ActionResult _Index() {
            var viewModel = DynamicIndexPageViewModelBuilder.Build(DynamicEntityMetadata);
            return PartialView("_DynamicIndex", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult IndexSearch(FormCollection formCollection) {
            return RedirectToAction("Index", TypeName, formCollection.ToRouteValues().GetRouteValueDictionary());
        }

        public virtual ActionResult Create(string returnUrl) {
            dynamic createModel = DynamicEntityMetadata.CreateNewObject()();
            UpdateModelAndClearModelState(createModel);
            var viewModel = DynamicCreateViewModelBuilder.Build(DynamicEntityMetadata, createModel, returnUrl);
            return View("DynamicCreate", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Create(FormCollection formCollection, string submitType, string returnUrl) {
            dynamic model = DynamicEntityMetadata.CreateNewObject()();
            var viewModel = DynamicCreateViewModelBuilder.Build(DynamicEntityMetadata, model, returnUrl);
            if (TryUpdateModelAsync(viewModel.Item, "Item")) {
                var dynamicOperation = DynamicEntityMetadata.GetDynamicOperation(TemplateTypeEnum.Create, submitType);
                dynamicOperation.PerformPreSaveOperation(null, formCollection, model, ref returnUrl, TempData, ViewData);

                if (dynamicOperation.PersistModel)
                    CreateItem(model);

                dynamicOperation.PeformPostSaveOperation(null, formCollection, model, ref returnUrl, TempData, ViewData);

                if (dynamicOperation.ReturnSucessfulRedirect)
                    return ReturnSuccessfulRedirect(returnUrl, model);
            }
            return View("DynamicCreate", viewModel);
        }

        public virtual ActionResult Delete(dynamic id, string returnUrl) {
            id = ParseKeyType(id);
            var model = _dynamicRepository.GetItem(EntityType, DynamicEntityMetadata.KeyProperty().PropertyName(), id);
            var viewModel = _dynamicDeleteViewModelBuilder.Build(DynamicEntityMetadata, model, returnUrl);
            return View("DynamicDelete", viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Delete(dynamic id, FormCollection formCollection, string returnUrl) {
            id = ParseKeyType(id);
            _dynamicRepository.DeleteItem(EntityType, KeyName, id);
            return ReturnSuccessfulRedirect(returnUrl);
        }

        public virtual ActionResult Details(dynamic id) {
            id = ParseKeyType(id);
            var model = _dynamicRepository.GetItem(EntityType, KeyName, id, DynamicEntityMetadata.InstanceIncludes().ToArray());
            var viewModel = DynamicDetailsViewModelBuilder.Build(DynamicEntityMetadata, model);
            return View("DynamicDetails", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Details(dynamic id, FormCollection formCollection, string submitType, string returnUrl) {
            id = ParseKeyType(id);
            var model = _dynamicRepository.GetItem(EntityType, KeyName, id, DynamicEntityMetadata.InstanceIncludes().ToArray());
            var viewModel = DynamicDetailsViewModelBuilder.Build(DynamicEntityMetadata, model);
            if (TryUpdateModelAsync(viewModel.Item, "Item")) {
                var dynamicOperation = DynamicEntityMetadata.GetDynamicOperation(TemplateTypeEnum.Details, submitType);
                dynamicOperation.PerformPreSaveOperation(id, formCollection, model, ref returnUrl, TempData, ViewData);

                if (dynamicOperation.PersistModel)
                    EditItem(model);

                dynamicOperation.PeformPostSaveOperation(id, formCollection, model, ref returnUrl, TempData, ViewData);

                if (dynamicOperation.ReturnSucessfulRedirect)
                    return ReturnSuccessfulRedirect(returnUrl, model);
            }
            return View("DynamicDetails", viewModel);
        }

        public virtual ActionResult Edit(dynamic id, string returnUrl) {
            id = ParseKeyType(id);
            var model = _dynamicRepository.GetItem(EntityType, KeyName, id, DynamicEntityMetadata.InstanceIncludes().ToArray());
            var viewModel = DynamicEditViewModelBuilder.Build(DynamicEntityMetadata, model, returnUrl);
            return View("DynamicEdit", viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Edit(dynamic id, FormCollection formCollection, string submitType, string returnUrl) {
            id = ParseKeyType(id);
            var model = _dynamicRepository.GetItem(EntityType, KeyName, id, DynamicEntityMetadata.InstanceIncludes().ToArray());
            var viewModel = DynamicEditViewModelBuilder.Build(DynamicEntityMetadata, model, returnUrl);
            if (TryUpdateModelAsync(viewModel.Item, "Item")) {
                var dynamicOperation = DynamicEntityMetadata.GetDynamicOperation(TemplateTypeEnum.Edit, submitType);
                dynamicOperation.PerformPreSaveOperation(id, formCollection, model, ref returnUrl, TempData, ViewData);

                if (dynamicOperation.PersistModel)
                    EditItem(model);

                dynamicOperation.PeformPostSaveOperation(id, formCollection, model, ref returnUrl, TempData, ViewData);

                if (dynamicOperation.ReturnSucessfulRedirect)
                    return ReturnSuccessfulRedirect(returnUrl, model);
            }
            return View("DynamicEdit", viewModel);
        }
        [HttpPost]
        public virtual ActionResult AutoComplete(string searchString) {
            return AutoCompleteCustom(KeyName, DynamicEntityMetadata.DefaultProperty().PropertyName(), searchString);
        }
        [HttpPost]
        public virtual ActionResult AutoCompleteCustom(string valueMember, string displayMember, string searchString) {
            IEnumerable items = _dynamicRepository.GetAutoCompleteItems(EntityType, valueMember, displayMember, searchString, 10);
            return Json(items);
        }
    }
}