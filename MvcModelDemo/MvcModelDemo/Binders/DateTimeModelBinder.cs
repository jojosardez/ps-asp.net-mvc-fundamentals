using System;
using System.Web.Mvc;

namespace MvcModelDemo.Binders
{
    public class DateTimeModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var result = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);
            if (result == null)
            {
                return null;
            }

            DateTime dateTimeResult;
            if (DateTime.TryParse(result.AttemptedValue, out dateTimeResult))
            {
                return dateTimeResult;
            }

            int intResult;
            if (int.TryParse(result.AttemptedValue, out intResult))
            {
                return new DateTime(intResult, 1, 1);
            }

            bindingContext.ModelState.AddModelError(bindingContext.ModelName, "Could not convert DateTime");
            return null;
        }
    }
}