using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPedigree.Model.Domain
{
    public class Envelope
    {

        // Sender's first name on the envelope 
        public String envelopeSendersFirstName { get; set; }

        // Sender's middle initial on the envelope
        public String envelopeSendersMiddleInitial { get; set; }

        // Sender's last name on the envelope 
        public String envelopeSendersLastName { get; set; }

        // Sender's street address on the envelope 
        public String envelopeSendersStreetAddress { get; set; }

        // Sender's city on the envelope 
        public String envelopeSendersCity { get; set; }

        // Sender's state on the envelope 
        public String envelopeSendersState { get; set; }

        // Sender's zipcode on the envelope 
        public String envelopeSendersZipCode { get; set; }

        // Receiver's first name on the envelope 
        public String envelopeReceiversFirstName { get; set; }

        // Receiver's middle initial on the envelope 
        public String envelopeReceiversMiddleInitial { get; set; }

        // Receiver's last name on the envelope 
        public String envelopeReceiversLastName { get; set; }

        // Receiver's street address on the envelope 
        public String envelopeReceiversStreetAddress { get; set; }

        // Receiver's city on the envelope 
        public String envelopeReceiversCity { get; set; }

        // Receiver's state on the envelope 
        public String envelopeReceiversState { get; set; }

        // Receiver's zipcode on the envelope 
        public String envelopeReceiversZipCode { get; set; }

        // Envelope message 
        public String envelopeMessageBody { get; set; }


        //Validation method

        public String testEnvelopeSendersFirstName()
        {

            return envelopeSendersFirstName;

        } //end Validation

        //Default constructur
        public Envelope()
        {

        }
        /**
         * @param envelopeSendersFirstName
         * @param envelopeSendersMiddleInitial
         * @param envelopeSendersLastName
         * @param envelopeSendersStreetAddress
         * @param envelopeSendersCity
         * @param envelopeSendersState
         * @param envelopeSendersZipCode
         * @param envelopeReceiversFirstName
         * @param envelopeReceiversMiddleInitial
         * @param envelopeReceiversLastName
         * @param envelopeReceiversStreetAddress
         * @param envelopeReceiversCity
         * @param envelopeReceiversState
         * @param envelopeReceiversZipCode
         * @param envelopeMessageBody
         */
        public Envelope(String envelopeSendersFirstName, String envelopeSendersMiddleInitial, String envelopeSendersLastName, String envelopeSendersStreetAddress, String envelopeSendersCity, String envelopeSendersState, String envelopeSendersZipCode,
                String envelopeReceiversFirstName, String envelopeReceiversMiddleInitial, String envelopeReceiversLastName, String envelopeReceiversStreetAddress, String envelopeReceiversCity, String envelopeReceiversState, String envelopeReceiversZipCode,
                String envelopeMessageBody)

        {

            this.envelopeSendersFirstName = envelopeSendersFirstName;
            this.envelopeSendersMiddleInitial = envelopeSendersMiddleInitial;
            this.envelopeSendersLastName = envelopeSendersLastName;
            this.envelopeSendersStreetAddress = envelopeSendersStreetAddress;
            this.envelopeSendersCity = envelopeSendersCity;
            this.envelopeSendersState = envelopeSendersState;
            this.envelopeSendersZipCode = envelopeSendersZipCode;
            this.envelopeReceiversFirstName = envelopeReceiversFirstName;
            this.envelopeReceiversMiddleInitial = envelopeReceiversMiddleInitial;
            this.envelopeReceiversLastName = envelopeReceiversLastName;
            this.envelopeReceiversStreetAddress = envelopeReceiversStreetAddress;
            this.envelopeReceiversCity = envelopeReceiversCity;
            this.envelopeReceiversState = envelopeReceiversState;
            this.envelopeReceiversZipCode = envelopeReceiversZipCode;
            this.envelopeMessageBody = envelopeMessageBody;
        }

        // getters and setters

        /**
         * @return Returns the sender's envelope first name.
         */

        public String getEnvelopeSendersFirstName()
        {
            return envelopeSendersFirstName;
        }

        /**
         * @set Sets the sender's envelope first name.
         */

        public void setEnvelopeSendersFirstName(String envelopeSendersFirstName)
        {
            this.envelopeSendersFirstName = envelopeSendersFirstName;
        }

        /**
         * @return Returns the sender's envelope middle initial.
         */

        public String getEnvelopeSendersMiddleInitial()
        {
            return envelopeSendersMiddleInitial;
        }

        /**
         * @set Sets the sender's envelope middle initial.
         */

        public void setEnvelopeSendersMiddleInitial(String envelopeSendersMiddleInitial)
        {
            this.envelopeSendersMiddleInitial = envelopeSendersMiddleInitial;
        }

        /**
         * @return Returns the sender's envelope last name.
         */

        public String getEnvelopeSendersLastName()
        {
            return envelopeSendersLastName;
        }

        /**
         * @set Sets the sender's envelope last name.
         */

        public void setEnvelopeSendersLastName(String envelopeSendersLastName)
        {
            this.envelopeSendersLastName = envelopeSendersLastName;
        }

        /**
         * @return Returns the sender's envelope street address.
         */

        public String getEnvelopeSendersStreetAddress()
        {
            return envelopeSendersStreetAddress;
        }

        /**
         * @set Sets the sender's envelope street address.
         */

        public void setEnvelopeSendersStreetAddress(String envelopeSendersStreetAddress)
        {
            this.envelopeSendersStreetAddress = envelopeSendersStreetAddress;
        }

        /**
         * @return Returns the sender's envelope city location.
         */

        public String getEnvelopeSendersCity()
        {
            return envelopeSendersCity;
        }

        /**
         * @set Sets the sender's envelope city location.
         */

        public void setEnvelopeSendersCity(String envelopeSendersCity)
        {
            this.envelopeSendersCity = envelopeSendersCity;
        }

        /**
         * @return Returns the sender's envelope state location.
         */

        public String getEnvelopeSendersState()
        {
            return envelopeSendersState;
        }

        /**
         * @set Sets the sender's envelope state location.
         */

        public void setEnvelopeSendersState(String envelopeSendersState)
        {
            this.envelopeSendersState = envelopeSendersState;
        }

        /**
         * @return Returns the sender's envelope zip code.
         */

        public String getEnvelopeSendersZipCode()
        {
            return envelopeSendersZipCode;
        }

        /**
         * @set Sets the sender's envelope zip code.
         */

        public void setEnvelopeSendersZipCode(String envelopeSendersZipCode)
        {
            this.envelopeSendersZipCode = envelopeSendersZipCode;
        }

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
         * @return Returns the receiver's envelope message.
         */
        public String getEnvelopeMessageBody()
        {
            return envelopeMessageBody;
        }

        /**
         * @set Sets the receiver's envelope message.
         */
        public void setEnvelopeMessageBody(String envelopeMessageBody)
        {
            this.envelopeMessageBody = envelopeMessageBody;
        }

        /**
         * Validate if the instance variables are valid
         * 
         * @return boolean - true if instance variables are valid, else false
         */
        public bool validate()
        {

            if (envelopeSendersFirstName == null) return false;
            if (envelopeSendersMiddleInitial == null) return false;
            if (envelopeSendersLastName == null) return false;
            if (envelopeSendersStreetAddress == null) return false;
            if (envelopeSendersCity == null) return false;
            if (envelopeSendersState == null) return false;
            if (envelopeSendersZipCode == null) return false;
            if (envelopeReceiversFirstName == null) return false;
            if (envelopeReceiversMiddleInitial == null) return false;
            if (envelopeReceiversLastName == null) return false;
            if (envelopeReceiversStreetAddress == null) return false;
            if (envelopeReceiversCity == null) return false;
            if (envelopeReceiversState == null) return false;
            if (envelopeReceiversZipCode == null) return false;
            if (envelopeMessageBody == null) return false;

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
        * @param envelopeReceiversFirstName;
        * @param envelopeReceiversMiddleInitial;
        * @param envelopeReceiversLastName;
        * @param envelopeReceiversStreetAddress;
        * @param envelopeReceiversCity;
        * @param envelopeReceiversState;
        * @param envelopeReceiversZipCode;
        * @param envelopeMessageBody;
        */

        public bool Equals(Envelope envelope)
        {
            if (!envelopeSendersFirstName.Equals(envelope.envelopeSendersFirstName)) return false;
            if (!envelopeSendersMiddleInitial.Equals(envelope.envelopeSendersMiddleInitial)) return false;
            if (!envelopeSendersLastName.Equals(envelope.envelopeSendersLastName)) return false;
            if (!envelopeSendersStreetAddress.Equals(envelope.envelopeSendersStreetAddress)) return false;
            if (!envelopeSendersCity.Equals(envelope.envelopeSendersCity)) return false;
            if (!envelopeSendersState.Equals(envelope.envelopeSendersState)) return false;
            if (!envelopeSendersZipCode.Equals(envelope.envelopeSendersZipCode)) return false;
            if (!envelopeReceiversFirstName.Equals(envelope.envelopeReceiversFirstName)) return false;
            if (!envelopeReceiversMiddleInitial.Equals(envelope.envelopeReceiversMiddleInitial)) return false;
            if (!envelopeReceiversLastName.Equals(envelope.envelopeReceiversLastName)) return false;
            if (!envelopeReceiversStreetAddress.Equals(envelope.envelopeReceiversStreetAddress)) return false;
            if (!envelopeReceiversCity.Equals(envelope.envelopeReceiversCity)) return false;
            if (!envelopeReceiversState.Equals(envelope.envelopeReceiversState)) return false;
            if (!envelopeReceiversZipCode.Equals(envelope.envelopeReceiversZipCode)) return false;
            if (!envelopeMessageBody.Equals(envelope.envelopeMessageBody)) return false;

            return true;
        }


        /**
         * toString() method useful for logging
         *  
         */

        public String toString()
        {
            StringBuilder strBfr = new StringBuilder();
            strBfr.Append("envelopeSendersFirstName:");
            strBfr.Append(envelopeSendersFirstName);
            strBfr.Append("\nenvelopeSendersMiddleInitial:");
            strBfr.Append(envelopeSendersMiddleInitial);
            strBfr.Append("\nenvelopeSendersLastName:");
            strBfr.Append(envelopeSendersLastName);
            strBfr.Append("\nenvelopeSendersStreetAddress :");
            strBfr.Append(envelopeSendersStreetAddress);
            strBfr.Append("\nenvelopeSendersCity:");
            strBfr.Append(envelopeSendersCity);
            strBfr.Append("\nenvelopeSendersState:");
            strBfr.Append(envelopeSendersState);
            strBfr.Append("\nenvelopeSendersZipCode:");
            strBfr.Append(envelopeSendersZipCode);
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
            strBfr.Append("\nenvelopeMessageBody:");
            strBfr.Append(envelopeMessageBody);


            return strBfr.ToString();


        }
    }
}