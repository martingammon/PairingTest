using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using PairingTest.Business.Contracts;
using PairingTest.Business.Managers;
using PairingTest.Providers.Interfaces;
using PairingTest.Providers.Providers;

namespace PairingTest.Providers
{
    public static class AutofacConfig
    {
        private static IContainer _odiContainer;
        public static IContainer OdiContainer
        {
            get
            {
                if (_odiContainer == null)
                    RegisterComponents();

                return _odiContainer;
            }
        }

        public static void RegisterComponents()
        {

            var builder = new ContainerBuilder();
            builder.RegisterType<QuestionnaireManager>().As<IQuestionnaireManager>().PropertiesAutowired();
            builder.RegisterType<QuestionnaireProvider>().As<IQuestionnaireProvider>().PropertiesAutowired();
            _odiContainer = builder.Build();
        }
    }
}
