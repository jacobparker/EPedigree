using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPedigree.Model.Business.Exceptions
{
    public class ServiceLoadException : Exception
    {

        public ServiceLoadException(String svcMessage, Exception svcNestedException) : base(svcMessage, svcNestedException)
        {
            
        }

    }
}
