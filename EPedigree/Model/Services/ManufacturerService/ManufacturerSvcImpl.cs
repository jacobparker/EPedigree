using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPedigree.Model.Domain;
using EPedigree.Model.Services.Exceptions;
using EPedigree.Model.Services;
using System.IO;

namespace EPedigree.Model.Services.ManufacturerService
{

    public class ManufacturerSvcImpl : IManufacturerService
    {
        /**
         * Manufacturer Service Implementation
         * Creates a new manufacturer profile object at the request of ManufacturerManager.
         *  
         *
         */


        public new void createMfgrProfile(Manufacturer manufacturer)
        {

            Manufacturer mFG1 = new Manufacturer();

            try
            {
                Stream os = new System.IO.FileStream("manufacturer1.obj", System.IO.FileMode.Create, System.IO.FileAccess.Write);
                os.Equals(mFG1);
                os.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
                Console.Write(ex);
            }

         
        } // end Manufacturer
    }
}

