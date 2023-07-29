using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.BL
{
    class product
    {
        private string medicineName;
        private int medicinePrice;
        private int quantity;
        [DisplayName("Medicine Name")]
        public string MedicineName { get => medicineName; set => medicineName = value; }
        [DisplayName("Medicine Price")]
        public int MedicinePrice { get => medicinePrice; set => medicinePrice = value; }
        [DisplayName("Stock")]
        public int Quantity { get => quantity; set => quantity = value; }
        public product(string medicineName, int medicinePrice)
        {
            this.medicineName = medicineName;
            this.medicinePrice = medicinePrice;
        }
        public product(string medicineName, int medicinePrice, int quantity)
        {
            this.medicineName = medicineName;
            this.medicinePrice = medicinePrice;
            this.quantity = quantity;
        }
    }
}
