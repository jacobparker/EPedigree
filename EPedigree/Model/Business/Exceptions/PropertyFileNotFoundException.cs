using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPedigree.Model.Business.Exceptions
{
    public class PropertyFileNotFoundException : Exception
    {

        public PropertyFileNotFoundException(String propMessage, Exception propNestedException) : base(propMessage, propNestedException)
        {

        }
    }
}
