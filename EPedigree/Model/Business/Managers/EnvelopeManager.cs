using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPedigree.Model.Business.Exceptions;
using EPedigree.Model.Services.Exceptions;
using EPedigree.Model.Domain;
using EPedigree.Model.Services.EnvelopeService;
using EPedigree.Model.Business.Factory;

namespace EPedigree.Model.Business.Managers
{
    public class EnvelopeManager : ManagerSuperType
    {
        /**
         * @author Ish
         *
         * This Manager class uses the properties file provided by the SuperManagerType,
         * calls the ServiceFactory, and executes services requested by the presentation layer. 
         *
         *  It called to create a new envelope object with sender/receiver sub-form data.
         *
         */

        public EnvelopeManager()
        {
            // construct object . . .
        }

        //Use Case Driven - Adding new envelope
        public void addNewEnvelope(Envelope envelope)
        {
            IEnvelopeService envelopeSvc = (IEnvelopeService)GetService(typeof(IEnvelopeService).Name);
            envelopeSvc.createEnvelopeData(envelope);


        }//end addNewEnvelope
    }
}

