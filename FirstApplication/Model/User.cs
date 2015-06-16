using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class User
    {
        private UInt32 id;
        private String name;
        private String address;
        private String phoneNumber;

        public User ()
        {

        }

        public User (UInt32 id, String name, String address, String phoneNumber)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        public UInt32 getId() { return id; }
        public void setId(UInt32 id) { this.id = id; }

        public String getName() { return name; }
        public void setName(String name) { this.name = name; }

        public String getAddress() { return address; }
        public void setAddress(String address) { this.address = address; }

        public String getPhoneNumber() { return phoneNumber; }
        public void setPhoneNumber(String phoneNumber) { this.phoneNumber = phoneNumber; }

        //override toString() for use in ComboBox
        public override string ToString()
        {
            return this.name;
        }


    }
}
