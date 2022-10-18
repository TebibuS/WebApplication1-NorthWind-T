//Tebibu Solomon
//8/26/2022
//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WebApplication1_NorthWind_T.Models
{
    public class Product
    {
        //class variables
        private int productId = -1;
        private string productName = "n/a";
        private int supplierId = -1;
        private int categoryId = -1;
        private string quantityPerUnit = "n/a";
        private double unitPrice = 0;
        private int unitsInStock = -1;
        private int unitsInOrder = -1;
        private int reorderLevel = 0;
        private bool discontinued = true; // by default , boolean is true

        // gets and sets
        // public properties
        // encapsulation
        public int ProductId
        {
            get { return this.productId; }
            set
            {
                // must be greater than -1
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
        public string ProductName
        {
            get { return this.productName; }
            set { this.productName = value; }
        }
        public int SupplierId
        {
            get { return this.supplierId; }
            set
            {
                // must be greater than -1
                if (value > -1)
                {
                    this.supplierId = value;
                }
                else
                {
                    this.supplierId = 0;
                }
            }
        }
        public int CategoryId
        {
            get { return this.categoryId; }
            set
            {
                // must be greater than -1
                if (value > -1)
                {
                    this.categoryId = value;
                }
                else
                {
                    this.categoryId = 0;
                }
            }
        }
        public string QuantityPerUnit
        {

            get { return this.quantityPerUnit; }
            set { this.quantityPerUnit = value; }
        }
        public double UnitPrice
        {
            get { return this.unitPrice; }
            set
            {
                // must be greater than 0
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
        public int UnitsInStock
        {
            get { return this.unitsInStock; }
            set
            {
                // must be greater than -1
                if (value > -1)
                {
                    this.unitsInStock = value;
                }
                else
                {
                    this.unitsInStock = 0;
                }
            }
        }
        public int UnitsInOrder
        {

            get { return this.unitsInOrder; }
            set
            {
                // must be greater than -1
                if (value > -1)
                {
                    this.unitsInOrder = value;
                }
                else
                {
                    this.unitsInOrder = 0;
                }
            }

        }
        public int ReorderLevel
        {
            get { return this.reorderLevel; }
            set
            {
                // must be greater than 0
                if (value > 0)
                {
                    this.reorderLevel = value;
                }
                else
                {
                    this.reorderLevel = 0;
                }
            }
        }
        public bool Discontinued
        {
            get { return this.discontinued; }
            set { this.discontinued = true; }
        }

        public Product(int v, string v1, int v2) : this(-1, "n/a", -1, -1, "n/a", 0, -1, -1, 0, true)

        {

            // Empty Constructor


        }
        // Methods
        public Product(int aProductId, string aProductName, int aSupplierId, int aCategoryId, string aQuantityPerUnit, double aUnitPrice, int aUnitsInStock,
           int aUnitsInOrder, int aReorderLevel, bool aDiscontinued)




        {

            this.ProductId = aProductId;
            this.ProductName = aProductName;
            this.SupplierId = aSupplierId;
            this.CategoryId = aCategoryId;
            this.QuantityPerUnit = aQuantityPerUnit;
            this.UnitPrice = aUnitPrice;
            this.UnitsInStock = aUnitsInStock;
            this.UnitsInOrder = aUnitsInOrder;
            this.ReorderLevel = aReorderLevel;
            this.Discontinued = aDiscontinued;

        }

        // Methods Go Here
        public override string ToString()
        {
            string message = "";
            message = message + "ProductId: " + this.ProductId + "\n";
            message = message + "ProductName: " + this.ProductName + "\n";
            message = message + "SuppplierId " + this.SupplierId + "\n";
            message = message + "CategoryId: " + this.CategoryId + "\n";
            message = message + "QuantityPerUnit: " + this.QuantityPerUnit + "\n";
            message = message + "UnitPrice: " + this.UnitPrice + "\n";
            message = message + "UnitsInStock: " + this.UnitsInStock + "\n";
            message = message + "UnitsInOrder: " + this.UnitsInOrder + "\n";
            message = message + "ReorderLevel: " + this.ReorderLevel + "\n";
            message = message + "Discontinued: " + this.Discontinued + "\n";
            return message;


        }








    }
}

