using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudwithconstructors
{
    class Muser
    {
        public string medicineName;
        public int medicinePrice;
        public int stock;
        public Muser(string medicineName, int medicinePrice, int stock)
        {
            this.medicineName = medicineName;
            this.medicinePrice = medicinePrice;
            this.stock = stock;

        }
    }
}
