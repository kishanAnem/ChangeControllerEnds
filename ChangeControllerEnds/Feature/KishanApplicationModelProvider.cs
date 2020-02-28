using System;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace ChangeControllerEnds.Feature
{
    public class KishanApplicationModelProvider : IApplicationModelProvider
    {
        private readonly string _controllerEndwith;

        public KishanApplicationModelProvider(string controllerEndwith)
        {
            _controllerEndwith = controllerEndwith;
        }


        public int Order => 100;

        public void OnProvidersExecuted(ApplicationModelProviderContext context)
        {

        }

        public void OnProvidersExecuting(ApplicationModelProviderContext context)
        {
            foreach (var controller in context.Result.Controllers)
            {
                if (controller.ControllerName.EndsWith(_controllerEndwith, StringComparison.OrdinalIgnoreCase))
                {
                    controller.ControllerName =
                             controller.ControllerName.Substring(0, controller.ControllerName.Length - "Kishan".Length);
                }
            }
        }
    }
}