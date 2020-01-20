using EPedigree.Model.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPedigree.Model.Services;
using EPedigree.Model.Services.Exceptions;
using NUnit.Framework;
using System.Windows.Forms;

namespace EPedigree.Model.Services.EnvelopeService
{
    public class EnvelopeSvcImpl : IEnvelopeService
    {
        /**
         * Envelope Service Implementation
         * Creates a new envelope object at the request of EnvelopeManager.
         * At the request of the "merge" button on the Envelope Tab,
         * it combines data entered from sender/receiver sub-forms to make
         * a complete and new envelope object. 
         */
        public new void createEnvelopeData(Envelope envelope)
        {

           // Final Envelope object to be serialized
            Envelope e1 = new Envelope();


            //De-serialize sender object containing sender's information in sender place holder sEDF

            Stream sender1 = null;
            try
            {
                Stream os = new System.IO.FileStream("senders1.obj", System.IO.FileMode.Create, System.IO.FileAccess.Write);
            }
            catch (FileNotFoundException e3)
            {
                // TODO Auto-generated catch block
                Console.WriteLine(e3);
            }
            catch (IOException e3)
            {
                // TODO Auto-generated catch block
                Console.WriteLine(e3);
            }
            SendersEnvelopeDataForm sEDF = null;
            try
            {
                sEDF = (SendersEnvelopeDataForm)sender1.GetLifetimeService();
            }
            catch (IOException e2)
            {
                // TODO Auto-generated catch block
                Console.WriteLine(e2);
            }
            catch (Exception e2)
            {
                // TODO Auto-generated catch block
                Console.WriteLine(e2);
            }

            //Get data from sender's form 
            String sFN1 = sEDF.getEnvelopeSendersFirstName();
            String sML1 = sEDF.getEnvelopeSendersMiddleInitial();
            String sLN1 = sEDF.getEnvelopeSendersLastName();
            String sSA1 = sEDF.getEnvelopeSendersStreetAddress();
            String sCT1 = sEDF.getEnvelopeSendersCity();
            String sST1 = sEDF.getEnvelopeSendersState();
            String sZC1 = sEDF.getEnvelopeSendersZipCode();
            String sMg1 = sEDF.getEnvelopeMessageBody();

            //Transfer data into target envelope
            e1.setEnvelopeSendersFirstName(sFN1);
            e1.setEnvelopeSendersMiddleInitial(sML1);
            e1.setEnvelopeSendersLastName(sLN1);
            e1.setEnvelopeSendersStreetAddress(sSA1);
            e1.setEnvelopeSendersCity(sCT1);
            e1.setEnvelopeSendersState(sST1);
            e1.setEnvelopeSendersZipCode(sZC1);
            e1.setEnvelopeMessageBody(sMg1);

            //De-serialize sender object containing sender's information in sender place holder sEDF

            Stream receiver1 = null;
            try
            {
                Stream os = new System.IO.FileStream("receiver1.obj", System.IO.FileMode.Create, System.IO.FileAccess.Write);
            }
            catch (FileNotFoundException e)
            {
                // TODO Auto-generated catch block
                Console.WriteLine(e);
            }
            catch (IOException e)
            {
                // TODO Auto-generated catch block
                Console.WriteLine(e);
            }
            ReceiversEnvelopeDataForm rEDF = null;
            try
            {
                rEDF = (ReceiversEnvelopeDataForm)receiver1.GetLifetimeService();
            }
            catch (IOException e)
            {
                // TODO Auto-generated catch block
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                // TODO Auto-generated catch block
                Console.WriteLine(e);


                //Get data from receiver's form 
                String sFN2 = rEDF.getEnvelopeReceiversFirstName();
                String sML2 = rEDF.getEnvelopeReceiversMiddleInitial();
                String sLN2 = rEDF.getEnvelopeReceiversLastName();
                String sSA2 = rEDF.getEnvelopeReceiversStreetAddress();
                String sCT2 = rEDF.getEnvelopeReceiversCity();
                String sST2 = rEDF.getEnvelopeReceiversState();
                String sZC2 = rEDF.getEnvelopeReceiversZipCode();

                //Transfer data into target envelope

                e1.setEnvelopeReceiversFirstName(sFN2);
                e1.setEnvelopeReceiversMiddleInitial(sML2);
                e1.setEnvelopeReceiversLastName(sLN2);
                e1.setEnvelopeReceiversStreetAddress(sSA2);
                e1.setEnvelopeReceiversCity(sCT2);
                e1.setEnvelopeReceiversState(sST2);
                e1.setEnvelopeReceiversZipCode(sZC2);

                //Serialize sender/receiver data into new Envelope1.obj		
                try
                {
                    Stream os = new System.IO.FileStream("envelope1.obj", System.IO.FileMode.Create, System.IO.FileAccess.Write);
                    os.Equals(e1);
                    os.Close();
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex);
                }

                if (e1 != null)
                {

                    //Send user a create message if successful
                    String name0 = null;
                    String message0 = String.Format("Envelope1.obj created!", name0);

                    MessageBox.Show(message0);

                }
                else
                {

                    //Send user a fail message if not successful
                    String name1 = null;
                    String message1 = String.Format("Envelope1.obj not created, call support!", name1);

                    MessageBox.Show(message1);

                }
               
            } // end Envelope Service

        }
    }
}
