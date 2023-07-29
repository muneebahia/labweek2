using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.BL
{
    internal class feedback
    {
        private string username;
        private string goodProduct;
        private string feedBack;

        [DisplayName("UserName")]
        public string Username { get => username; set => username = value; }
        [DisplayName("BestMedicine")]
        public string GoodProduct { get => goodProduct; set => goodProduct = value; }
        [DisplayName("FeedBack")]
        public string FeedBack { get => feedBack; set => feedBack = value; }
       
        public feedback(string username,string goodProduct,string feedback) 
        {
        this.username = username;
        this.goodProduct = goodProduct;        
        this.FeedBack = feedback;
        }


    }
}
