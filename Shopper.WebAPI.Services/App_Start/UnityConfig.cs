using Microsoft.Practices.Unity;
using System.Web.Http;
using Shopper.DataAccess.DataTier.Repo.Concrete;
using Shopper.DataAccess.DataTier.Repo.Interfaces;
using Shopper.DataServices.Concrete;
using Shopper.DataServices.Interfaces;
using Unity.WebApi;

namespace Shopper.WebAPI.Services
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterType<IInventoryService, InventoryService>();
            container.RegisterType<ICustomerService, CustomerService>();
            container.RegisterType<IDepartmentService, DepartmentService>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}