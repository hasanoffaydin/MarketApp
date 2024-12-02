using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp.Entity
{
    internal class Product
    {
        private int id;
        private int sellerId;
        private string productName;
        private int productPrice;
        private int productQuantity;
        private int purchasePrice;  
        public int ProductId { get { return id; } set { id = value; } }
        public int ProductSellerId { get { return sellerId; } set { sellerId = value; } }
        public string ProductName { get { return productName; } set { productName = value; } }
        public int ProductPrice { get { return productPrice; } set { productPrice = value; } }
        public int ProductQuantity { get {  return productQuantity; } set { productQuantity = value; } }    
        public int PurchasePrice { get { return purchasePrice; } set {purchasePrice = value; } }

    }
}
