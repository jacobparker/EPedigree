using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPedigree.Model.Domain
{
    public class ReceiversEnvelopeDataForm
    {

        /** Receiver's first name on the envelope */
        private String envelopeReceiversFirstName;

        /** Receiver's middle initial on the envelope */
        private String envelopeReceiversMiddleInitial;

        /** Receiver's last name on the envelope */
        private String envelopeReceiversLastName;

        /** Receiver's street address on the envelope */
        private String envelopeReceiversStreetAddress;

        /** Receiver's city on the envelope */
        private String envelopeReceiversCity;

        /** Receiver's state on the envelope */
        private String envelopeReceiversState;

        /** Receiver's zipcode on the envelope */
        private String envelopeReceiversZipCode;


        public ReceiversEnvelopeDataForm()
        {

        }
        /**
         * @param envelopeReceiversFirstName
         * @param envelopeReceiversMiddleInitial
         * @param envelopeReceiversLastName
         * @param envelopeReceiversStreetAddress
         * @param envelopeReceiversCity
         * @param envelopeReceiversState
         */


        public ReceiversEnvelopeDataForm(String envelopeReceiversFirstName, String envelopeReceiversMiddleInitial, String envelopeReceiversLastName,
                String envelopeReceiversStreetAddress, String envelopeReceiversCity, String envelopeReceiversState, String envelopeReceiversZipCode)

        {

            this.envelopeReceiversFirstName = envelopeReceiversFirstName;
            this.envelopeReceiversMiddleInitial = envelopeReceiversMiddleInitial;
            this.envelopeReceiversLastName = envelopeReceiversLastName;
            this.envelopeReceiversStreetAddress = envelopeReceiversStreetAddress;
            this.envelopeReceiversCity = envelopeReceiversCity;
            this.envelopeReceiversState = envelopeReceiversState;
            this.envelopeReceiversZipCode = envelopeReceiversZipCode;

        }

        // getters and setters

        /**
         * @return Returns the receiver's envelope first name.
         */

        public String getEnvelopeReceiversFirstName()
        {
            return envelopeReceiversFirstName;
        }

        /**
         * @set Sets the receiver's envelope first name.
         */

        public void setEnvelopeReceiversFirstName(String envelopeReceiversFirstName)
        {
            this.envelopeReceiversFirstName = envelopeReceiversFirstName;
        }

        /**
         * @return Returns the receiver's envelope middle initial.
         */

        public String getEnvelopeReceiversMiddleInitial()
        {
            return envelopeReceiversMiddleInitial;
        }

        /**
         * @set Sets the receiver's envelope middle initial.
         */

        public void setEnvelopeReceiversMiddleInitial(String envelopeReceiversMiddleInitial)
        {
            this.envelopeReceiversMiddleInitial = envelopeReceiversMiddleInitial;
        }

        /**
         * @return Returns the receiver's envelope last name.
         */

        public String getEnvelopeReceiversLastName()
        {
            return envelopeReceiversLastName;
        }

        /**
         * @set Sets the receiver's envelope last name.
         */

        public void setEnvelopeReceiversLastName(String envelopeReceiversLastName)
        {
            this.envelopeReceiversLastName = envelopeReceiversLastName;
        }

        /**
         * @return Returns the receiver's envelope street address.
         */

        public String getEnvelopeReceiversStreetAddress()
        {
            return envelopeReceiversStreetAddress;
        }

        /**
         * @set Sets the receiver's envelope street address.
         */

        public void setEnvelopeReceiversStreetAddress(String envelopeReceiversStreetAddress)
        {
            this.envelopeReceiversStreetAddress = envelopeReceiversStreetAddress;
        }

        /**
         * @return Returns the receiver's envelope city location.
         */

        public String getEnvelopeReceiversCity()
        {
            return envelopeReceiversCity;
        }

        /**
         * @set Sets the receiver's envelope city location.
         */

        public void setEnvelopeReceiversCity(String envelopeReceiversCity)
        {
            this.envelopeReceiversCity = envelopeReceiversCity;
        }

        /**
         * @return Returns the receiver's envelope state location.
         */

        public String getEnvelopeReceiversState()
        {
            return envelopeReceiversState;
        }

        /**
         * @set Sets the receiver's envelope state location.
         */

        public void setEnvelopeReceiversState(String envelopeReceiversState)
        {
            this.envelopeReceiversState = envelopeReceiversState;
        }

        /**
         * @return Returns the receiver's envelope zipcode.
         */

        public String getEnvelopeReceiversZipCode()
        {
            return envelopeReceiversZipCode;
        }

        /**
         * @set Set the receiver's envelope zipcode.
         */

        public void setEnvelopeReceiversZipCode(String envelopeReceiversZipCode)
        {
            this.envelopeReceiversZipCode = envelopeReceiversZipCode;
        }

        /**
         * Validate if the instance variables are valid
         * 
         * @return boolean - true if instance variables are valid, else false
         */
        public bool validate()
        {

            if (envelopeReceiversFirstName == null) return false;
            if (envelopeReceiversMiddleInitial == null) return false;
            if (envelopeReceiversLastName == null) return false;
            if (envelopeReceiversStreetAddress == null) return false;
            if (envelopeReceiversCity == null) return false;
            if (envelopeReceiversState == null) return false;
            if (envelopeReceiversZipCode == null) return false;


            return true;
        }

        /**
        * @param envelopeReceiversFirstName;
        * @param envelopeReceiversMiddleInitial;
        * @param envelopeReceiversLastName;
        * @param envelopeReceiversStreetAddress;
        * @param envelopeReceiversCity;
        * @param envelopeReceiversState;
        * @param envelopeReceiversZipCode;
        */

        public bool Equals(ReceiversEnvelopeDataForm receiversEnvelopeDataForm)
        {
            if (!envelopeReceiversFirstName.Equals(receiversEnvelopeDataForm.envelopeReceiversFirstName)) return false;
            if (!envelopeReceiversMiddleInitial.Equals(receiversEnvelopeDataForm.envelopeReceiversMiddleInitial)) return false;
            if (!envelopeReceiversLastName.Equals(receiversEnvelopeDataForm.envelopeReceiversLastName)) return false;
            if (!envelopeReceiversStreetAddress.Equals(receiversEnvelopeDataForm.envelopeReceiversStreetAddress)) return false;
            if (!envelopeReceiversCity.Equals(receiversEnvelopeDataForm.envelopeReceiversCity)) return false;
            if (!envelopeReceiversState.Equals(receiversEnvelopeDataForm.envelopeReceiversState)) return false;
            if (!envelopeReceiversZipCode.Equals(receiversEnvelopeDataForm.envelopeReceiversZipCode)) return false;


            return true;
        }


        /**
         * oString() method useful for logging
         *  
         */

        public String toString()
        {
            StringBuilder strBfr = new StringBuilder();

            strBfr.Append("\nenvelopeReceiversFirstName:");
            strBfr.Append(envelopeReceiversFirstName);
            strBfr.Append("\nenvelopeReceiversMiddleInitial:");
            strBfr.Append(envelopeReceiversMiddleInitial);
            strBfr.Append("\nenvelopeReceiversLastName:");
            strBfr.Append(envelopeReceiversLastName);
            strBfr.Append("\nenvelopeReceiversStreetAddress:");
            strBfr.Append(envelopeReceiversStreetAddress);
            strBfr.Append("\nenvelopeReceiversCity:");
            strBfr.Append(envelopeReceiversCity);
            strBfr.Append("\nenvelopeReceiversState:");
            strBfr.Append(envelopeReceiversState);
            strBfr.Append("\nenvelopeReceiversZipCode:");
            strBfr.Append(envelopeReceiversZipCode);

            return strBfr.ToString();


        }
    }

}

