//Tebibu Solomon
//8/26/2022
//using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WebApplication1_NorthWind_T.Models
{
    public class Category
    {
        //Class variables
        private int categoryId = -1;
        private string categoryName = "n/a";
        private string description = "n/a";

        // Gets and sets
        // public properties
        // encapsulation
        public int CategoryId
        {
            get { return this.categoryId; }
            set
            {
                //must be greater than -1
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

        public string CategoryName
        {
            get { return this.categoryName; }
            set { this.categoryName = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        //Constructors
        //Empty Constructor
        public Category() : this(-1, "n/a", "n/a")

        {

            // Empty Constructor


        }
        // Methods
        public Category(int aCategoryId, string aCategoryName, string aDescription)

        {

            this.CategoryId = aCategoryId;
            this.CategoryName = aCategoryName;
            this.Description = aDescription;



        }













        // Methods Go Here
        public override string ToString()
        {
            string message = "";
            message = message + "CategoryId: " + this.CategoryId + "\n";
            message = message + "CategoryName: " + this.CategoryName + "\n";
            message = message + "Description: " + this.Description + "\n";
            return message;

        }
    }

}


