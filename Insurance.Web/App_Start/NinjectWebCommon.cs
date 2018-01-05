﻿using Insurance.Service;
using Insurance.Model;
using Insurance.Data.Repositories;
using Insurance.Data.Common;
[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Insurance.Web.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Insurance.Web.App_Start.NinjectWebCommon), "Stop")]


namespace Insurance.Web.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;

    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            // Repositories

            kernel.Bind<IRepository<Customer>>().To<CustomerRepository>();
            kernel.Bind<IRepository<Category>>().To<CategoryRepository>();
            kernel.Bind<IRepository<Orders>>().To<OrdersRepository>();


            //Services
            kernel.Bind<ICustomerService>().To<CustomerService>();
            kernel.Bind<ICategoryService>().To<CategoryService>();
            kernel.Bind<IOrdersService>().To<OrdersService>();
        }
    }
}
