using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPedigree.Model.Domain;
using EPedigree.Model.Services.Exceptions;
using EPedigree.Model.Services;

namespace EPedigree.Model.Services.ManufacturerService
{
    public class IManufacturerService
    {
        /** 
         * Create an manufacturer profile object 
         * @param Manufacturer
         * 							register user data about the manufacturer creating product, pedigree, and envelope objects. 
         * @throws ManufacturerServiceException
         *  
         * 							If the Manufacturer object is null or is not found 
         * 
         * */

        public string NAME = "IManufacturerService";

        public void createMfgrProfile(Manufacturer manufacturer)
        {
            if (manufacturer == null) throw new ArgumentNullException();

        }

    }

}

