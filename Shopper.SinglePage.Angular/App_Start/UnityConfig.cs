using System.Web.Http;
using Microsoft.Practices.Unity;
using Shopper.DataServices.Concrete;
using Shopper.DataServices.Interfaces;
using Unity.WebApi;

namespace Shopper.SinglePage.Angular
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<ICustomerService, CustomerService>();
            container.RegisterType<IInventoryService, InventoryService>();
            container.RegisterType<IDepartmentService, DepartmentService>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}