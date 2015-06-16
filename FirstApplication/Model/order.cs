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
        private decimal totalPrice;
        private decimal totalCost;
        private String totalPriceStr;
        private String totalSaleCost;

        public Order ()
        {
            totalPrice = 0;
            totalCost = 0;

        }

        public UInt32 getId () { return this.id; }
        public void setId (UInt32 id) { this.id = id; }

        public UInt32 getCustomerId() { return this.customerId; }
        public void setCustomerId (UInt32 customerId) { this.customerId = customerId; }

        public decimal getTotalPrice () { return this.totalPrice; }
        public void setTotalPrice (decimal totalPrice) { this.totalPrice = totalPrice; }

        public decimal getTotalCost() { return this.totalCost; }
        public void setTotalCost(decimal totalCost) { this.totalCost = totalCost; }

        public String getTotalPriceStr ()
        {
            return String.Format("{0:C}", totalPrice);
        }

        public String getTotalCostStr ()
        {
            return String.Format("{0:C}", totalCost);
        }


    }
}
