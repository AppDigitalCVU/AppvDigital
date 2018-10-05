using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using AppUscv.Business;
using AppUscv.Business.Interface;
using AppUscv.Repository.Infrastructure;
using AppUscv.Repository.Infrastructure.Contract;

namespace AppvDigital
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            // e.g. container.RegisterType<ITestService, TestService>();

            //en caso de necesitar un constructor con un valor de la clase business como parametro
            //en caso de recibir un valor  entero o algo pasar un valor por default
            //container.RegisterType<PersonalBusiness>(new Unity.Injection.InjectionConstructor(0));

            //por cada uno de las interfaces a injectar y clases concretas referenciadas necesitamos
            //utilizar el  siguiente metodo de esta clase
            container.RegisterType<IPersonalBusiness, PersonalBusiness>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}