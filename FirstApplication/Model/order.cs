using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication.Model
{
    class Order
    {
        private UInt32 id;
        private UInt32 customerId;
        private double totalPrice;
        private DateTime date;

        public Order ()
        { 
        }

        public UInt32 getId () { return this.id; }
        public void setId (UInt32 id) { this.id = id; }

        public UInt32 getCustomerId() { return this.customerId; }
        public void setCustomerId (UInt32 customerId) { this.customerId = customerId; }

        public double getTotalPrice () { return this.totalPrice; }
        public void setTotalPrice (double totalPrice) { this.totalPrice = totalPrice; }

        public DateTime getDate () { return this.date; }
        public void setDate (DateTime date) { this.date = date; }


    }
}
