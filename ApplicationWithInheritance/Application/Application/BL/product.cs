using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BL
{
    class product
    {
        private string medicineName;
        private int medicinePrice;
        private int quantity;
        public string MedicineName { get => medicineName; set => medicineName = value; }
        public int MedicinePrice { get => medicinePrice; set => medicinePrice = value; }
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
