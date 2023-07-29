using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.BL
{
    class discount
    {
        private float discountPrice;
        private float discountPercent;
        [DisplayName("Price")]
        public float DiscountPrice { get => discountPrice; set => discountPrice = value; }
        [DisplayName("Percent")]
        public float DiscountPercent { get => discountPercent; set => discountPercent = value; }
        public discount(float discountPrice, float discountPercent)
        {
            this.discountPrice = discountPrice;
            this.discountPercent = discountPercent;
        }
    }
}
