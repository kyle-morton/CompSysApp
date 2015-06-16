using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication.Model
{
    class OrderItem
    {
        private UInt32 itemId;
        private UInt32 orderId;

        public OrderItem (UInt32 itemId, UInt32 orderId)
        {
            this.itemId = itemId;
            this.orderId = orderId;
        }

        public UInt32 getItemId () { return this.itemId; }
        public void setItemId (UInt32 itemId) { this.itemId = itemId; }

        public UInt32 getOrderId () { return this.orderId; }
        public void setOrderId (UInt32 orderId) { this.orderId = orderId; }

    }
}
