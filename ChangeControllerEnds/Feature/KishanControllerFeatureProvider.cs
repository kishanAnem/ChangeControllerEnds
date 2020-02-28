using System;
using System.Reflection;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace ChangeControllerEnds.Feature
{
    public class KishanControllerFeatureProvider : ControllerFeatureProvider
    {
        private readonly string _controllerEndwith;

        public KishanControllerFeatureProvider(string controllerEndwith)
        {
            _controllerEndwith = controllerEndwith;

        }
        protected override bool IsController(TypeInfo typeInfo)
        {
            return base.IsController(typeInfo) || typeInfo.Name.EndsWith("Kishan", StringComparison.OrdinalIgnoreCase);
        }
    }
}
