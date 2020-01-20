using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPedigree.Model.Services;
using EPedigree.Model.Business.Exceptions;
using System.Configuration;
using System.Collections.Specialized;

namespace EPedigree.Model.Business.Factory
{
    public class ServiceFactory
    {
        //Singleton design pattern.          
        private static ServiceFactory factory = new ServiceFactory();

        public static ServiceFactory GetInstance()
        {
            return factory;
        }

        public IService GetService(string serviceName)
        {
            Type type;
            Object obj = null;

            try
            {
                //Looks up impl name in app.config
                type = Type.GetType(GetImplName(serviceName));
                //Instantiates the implementation class
                obj = Activator.CreateInstance(type);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }
            return (IService)obj;
        }

        private string GetImplName(string serviceName)
        {
            NameValueCollection settings = ConfigurationManager.AppSettings;
            //Looks up the impl name in the app.config file
            return settings.Get(serviceName);
        }
    }
}