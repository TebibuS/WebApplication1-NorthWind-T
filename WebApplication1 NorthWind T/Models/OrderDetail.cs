//Tebibu Solomon
//8/26/2022
//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WebApplication1_NorthWind_T.Models
{
    public class OrderDetail
    {
        //class variables
        private int orderId = -1;
        private int productId = -1;
        private double unitPrice = 0;
        private int quantity = 0;
        private double discount = 0;

        //gets and sets
        // public properties
        // encapsulation
        public int OrderId
        {
            get { return this.orderId; }
            set
            {
                //must be greater than -1
                if (value > -1)
                {

                    this.orderId = value;
                }
                else
                {
                    this.orderId = 0;
                }
            }
        }
        public int ProductId
        {
            get { return this.productId; }
            set
            {
                //must be greater than -1
                if (value > -1)
                {
                    this.productId = value;
                }
                else
                {
                    this.productId = 0;
                }
            }
        }
        public double UnitPrice
        {
            get { return this.unitPrice; }
            set
            {
                //must be greater than 0
                if (value > 0)
                {
                    this.unitPrice = value;
                }
                else
                {
                    this.unitPrice = 0;
                }
            }

        }
        public int Quantity
        {
            get { return this.quantity; }
            set
            {

                //must be greater than 0
                if (value > 0)
                {
                    this.quantity = value;
                }
                else
                {
                    this.quantity = 0;
                }

            }
        }
        public double Discount
        {
            get { return this.discount; }
            set
            {
                //must be greater than or equal to 0
                if (value >= 0)
                {
                    this.quantity = (int)value;
                }
                else
                {

                    this.quantity = 0;
                }

            }

        }
        public OrderDetail() : this(-1, -1, 0, 0, 0)

        {

            // Empty Constructor


        }
        // Methods
        public OrderDetail(int aOrderId, int aProductId, double aUnitPrice, int aQuantity, double aDiscount)



        {

            this.OrderId = aOrderId;
            this.ProductId = aProductId;
            this.UnitPrice = aUnitPrice;
            this.Quantity = aQuantity;
            this.Discount = aDiscount;

        }

        // Methods Go Here
        public override string ToString()
        {
            string message = "";
            message = message + "OrderId: " + this.OrderId + "\n";
            message = message + "ProductId: " + this.ProductId + "\n";
            message = message + "UnitPrice: " + this.UnitPrice + "\n";
            message = message + "Quantity: " + this.Quantity + "\n";
            message = message + "Discount: " + this.Discount + "\n";
            return message;




        }

    }

}




