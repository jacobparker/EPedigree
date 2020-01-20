using EPedigree.Model.Business.Factory;
using EPedigree.Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPedigree.Model.Business.Managers
{
    public class ManagerSuperType
    {
        private ServiceFactory factory = ServiceFactory.GetInstance();

        protected IService GetService(String name)
        {
            return factory.GetService(name);
        }
    }
}
