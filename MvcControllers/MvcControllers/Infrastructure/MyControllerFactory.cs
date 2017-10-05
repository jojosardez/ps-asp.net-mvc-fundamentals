using StructureMap;
using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcControllers.Infrastructure
{
    public class MyControllerFactory : DefaultControllerFactory
    {
        private readonly Container _container;

        public MyControllerFactory(Container container)
        {
            _container = container;
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return _container.GetInstance(controllerType) as IController;
        }
    }
}