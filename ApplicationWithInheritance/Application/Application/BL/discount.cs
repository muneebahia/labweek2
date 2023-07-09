using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BL
{
    class discount
    {
        private float discountPrice;
        private float discountPercent;
        public float DiscountPrice { get => discountPrice; set => discountPrice = value; }
        public float DiscountPercent { get => discountPercent; set => discountPercent = value; }
        public discount(float discountPrice, float discountPercent)
        {
            this.discountPrice = discountPrice;
            this.discountPercent = discountPercent;
        }
    }
}
