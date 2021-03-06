﻿using System;
using System.Web.Mvc;
using System.Web.Routing;
using DryIoc;

namespace UnitTests
{
    public class MyControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return (IController) MvcApplication.Container.Resolve(controllerType);
        }
    }
}