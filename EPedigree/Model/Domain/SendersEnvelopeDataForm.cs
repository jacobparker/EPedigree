using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPedigree.Model.Domain
{
    public class SendersEnvelopeDataForm
    {

        /** Sender's first name on the envelope */
        private String EnvelopeSendersFirstName;

        /** Sender's middle initial on the envelope */
        private String EnvelopeSendersMiddleInitial;

        /** Sender's last name on the envelope */
        private String EnvelopeSendersLastName;

        /** Sender's street address on the envelope */
        private String EnvelopeSendersStreetAddress;

        /** Sender's city on the envelope */
        private String EnvelopeSendersCity;

        /** Sender's state on the envelope */
        private String EnvelopeSendersState;

        /** Sender's zipcode on the envelope */
        private String EnvelopeSendersZipCode;

        /** Envelope message */
        private String EnvelopeMessageBody;

        /**
         * @param envelopeSendersFirstName
         * @param envelopeSendersMiddleInitial
         * @param envelopeSendersLastName
         * @param envelopeSendersStreetAddress
         * @param envelopeSendersCity
         * @param envelopeSendersState
         * @param envelopeSendersZipCode
         * @param envelopeMessageBody
         */

        public SendersEnvelopeDataForm()
        {

        }

        public SendersEnvelopeDataForm(String envelopeSendersFirstName, String envelopeSendersMiddleInitial, String envelopeSendersLastName, String envelopeSendersStreetAddress,
                String envelopeSendersCity, String envelopeSendersState, String envelopeSendersZipCode, String envelopeMessageBody)
        {

            this.EnvelopeSendersFirstName = envelopeSendersFirstName;
            this.EnvelopeSendersMiddleInitial = envelopeSendersMiddleInitial;
            this.EnvelopeSendersLastName = envelopeSendersLastName;
            this.EnvelopeSendersStreetAddress = envelopeSendersStreetAddress;
            this.EnvelopeSendersCity = envelopeSendersCity;
            this.EnvelopeSendersState = envelopeSendersState;
            this.EnvelopeSendersZipCode = envelopeSendersZipCode;
            this.EnvelopeMessageBody = envelopeMessageBody;
        }

        // getters and setters

        /**
         * @return Returns the sender's envelope first name.
         */

        public String getEnvelopeSendersFirstName()
        {
            return EnvelopeSendersFirstName;
        }

        /**
         * @set Sets the sender's envelope first name.
         */

        public void setEnvelopeSendersFirstName(String envelopeSendersFirstName)
        {
            this.EnvelopeSendersFirstName = envelopeSendersFirstName;
        }

        /**
         * @return Returns the sender's envelope middle initial.
         */

        public String getEnvelopeSendersMiddleInitial()
        {
            return EnvelopeSendersMiddleInitial;
        }

        /**
         * @set Sets the sender's envelope middle initial.
         */

        public void setEnvelopeSendersMiddleInitial(String envelopeSendersMiddleInitial)
        {
            this.EnvelopeSendersMiddleInitial = envelopeSendersMiddleInitial;
        }

        /**
         * @return Returns the sender's envelope last name.
         */

        public String getEnvelopeSendersLastName()
        {
            return EnvelopeSendersLastName;
        }

        /**
         * @set Sets the sender's envelope last name.
         */

        public void setEnvelopeSendersLastName(String envelopeSendersLastName)
        {
            this.EnvelopeSendersLastName = envelopeSendersLastName;
        }

        /**
         * @return Returns the sender's envelope street address.
         */

        public String getEnvelopeSendersStreetAddress()
        {
            return EnvelopeSendersStreetAddress;
        }

        /**
         * @set Sets the sender's envelope street address.
         */

        public void setEnvelopeSendersStreetAddress(String envelopeSendersStreetAddress)
        {
            this.EnvelopeSendersStreetAddress = envelopeSendersStreetAddress;
        }

        /**
         * @return Returns the sender's envelope city location.
         */

        public String getEnvelopeSendersCity()
        {
            return EnvelopeSendersCity;
        }

        /**
         * @set Sets the sender's envelope city location.
         */

        public void setEnvelopeSendersCity(String envelopeSendersCity)
        {
            this.EnvelopeSendersCity = envelopeSendersCity;
        }

        /**
         * @return Returns the sender's envelope state location.
         */

        public String getEnvelopeSendersState()
        {
            return EnvelopeSendersState;
        }

        /**
         * @set Sets the sender's envelope state location.
         */

        public void setEnvelopeSendersState(String envelopeSendersState)
        {
            this.EnvelopeSendersState = envelopeSendersState;
        }

        /**
         * @return Returns the sender's envelope zip code.
         */

        public String getEnvelopeSendersZipCode()
        {
            return EnvelopeSendersZipCode;
        }

        /**
         * @set Sets the sender's envelope zip code.
         */

        public void setEnvelopeSendersZipCode(String envelopeSendersZipCode)
        {
            this.EnvelopeSendersZipCode = envelopeSendersZipCode;
        }

        /**
          * @return Returns the receiver's envelope message.
          */
        public String getEnvelopeMessageBody()
        {
            return EnvelopeMessageBody;
        }

        /**
         * @set Sets the receiver's envelope message.
         */
        public void setEnvelopeMessageBody(String envelopeMessageBody)
        {
            this.EnvelopeMessageBody = envelopeMessageBody;
        }

        /**
         * Validate if the instance variables are valid
         * 
         * @return boolean - true if instance variables are valid, else false
         */
        public bool validate()
        {

            if (EnvelopeSendersFirstName == null) return false;
            if (EnvelopeSendersMiddleInitial == null) return false;
            if (EnvelopeSendersLastName == null) return false;
            if (EnvelopeSendersStreetAddress == null) return false;
            if (EnvelopeSendersCity == null) return false;
            if (EnvelopeSendersState == null) return false;
            if (EnvelopeSendersZipCode == null) return false;
            if (EnvelopeMessageBody == null) return false;

            return true;
        }

        /**
        * @param envelopeSendersFirstName;
        * @param envelopeSendersMiddleInitial;
        * @param envelopeSendersLastName;	
        * @param envelopeSendersStreetAddress;
        * @param envelopeSendersCity;
        * @param envelopeSendersState;
        * @param envelopeSendersZipCode;

        */

        public bool Equals(SendersEnvelopeDataForm sendersEnvelopeDataForm)
        {
            if (!EnvelopeSendersFirstName.Equals(sendersEnvelopeDataForm.EnvelopeSendersFirstName)) return false;
            if (!EnvelopeSendersMiddleInitial.Equals(sendersEnvelopeDataForm.EnvelopeSendersMiddleInitial)) return false;
            if (!EnvelopeSendersLastName.Equals(sendersEnvelopeDataForm.EnvelopeSendersLastName)) return false;
            if (!EnvelopeSendersStreetAddress.Equals(sendersEnvelopeDataForm.EnvelopeSendersStreetAddress)) return false;
            if (!EnvelopeSendersCity.Equals(sendersEnvelopeDataForm.EnvelopeSendersCity)) return false;
            if (!EnvelopeSendersState.Equals(sendersEnvelopeDataForm.EnvelopeSendersState)) return false;
            if (!EnvelopeSendersZipCode.Equals(sendersEnvelopeDataForm.EnvelopeSendersZipCode)) return false;
            if (!EnvelopeMessageBody.Equals(sendersEnvelopeDataForm.EnvelopeMessageBody)) return false;

            return true;
        }


        /**
         * toString() method useful for logging
         *  
         */

        public override string ToString()
        {
            StringBuilder strBfr = new StringBuilder();
            strBfr.Append("envelopeSendersFirstName:");
            strBfr.Append(EnvelopeSendersFirstName);
            strBfr.Append("\nenvelopeSendersMiddleInitial:");
            strBfr.Append(EnvelopeSendersMiddleInitial);
            strBfr.Append("\nenvelopeSendersLastName:");
            strBfr.Append(EnvelopeSendersLastName);
            strBfr.Append("\nenvelopeSendersStreetAddress :");
            strBfr.Append(EnvelopeSendersStreetAddress);
            strBfr.Append("\nenvelopeSendersCity:");
            strBfr.Append(EnvelopeSendersCity);
            strBfr.Append("\nenvelopeSendersState:");
            strBfr.Append(EnvelopeSendersState);
            strBfr.Append("\nenvelopeSendersZipCode:");
            strBfr.Append(EnvelopeSendersZipCode);
            strBfr.Append("\nenvelopeReceiversFirstName:");
            strBfr.Append(EnvelopeMessageBody);


            return strBfr.ToString();


        }




    }

}

