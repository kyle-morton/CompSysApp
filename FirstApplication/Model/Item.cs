using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication.Model
{
    class Item
    {
        private UInt32 id;
        private String name;
        private decimal price;
        private String unitOfMeasure;
        private decimal standProfMargin;

        public UInt32 getId() { return this.id; }
        public void setId(UInt32 id) { this.id = id; }

        public String getName () { return this.name; }
        public void setName(String name) { this.name = name; }

        public decimal getPrice () { return this.price; }
        public void setPrice (decimal price) { this.price = price; }

        public String getUnitOfMeasure () { return this.unitOfMeasure; }
        public void setUnitOfMeasure (String unitOfMeasure) { this.unitOfMeasure = unitOfMeasure; }

        public decimal getStandProfitMargin () { return this.standProfMargin; }
        public void setStandProfMargin(decimal sPM) { this.standProfMargin = sPM; }

        //override toString() for use in ComboBox
        public override string ToString()
        {
            return this.name + " $" + this.price;
        }

    }
}
