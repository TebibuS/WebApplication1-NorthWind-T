//Tebibu Solomon
//8/26/2022
//using System;using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WebApplication1_NorthWind_T.Models
{
    public class Shipper
    {
        //class variables
        private int shipperId = -1;
        private string companyName = "n/a";
        private string phone = "n/a";

        //gets and sets
        // public properties
        // encapsulation
        public int ShipperId
        {
            get { return this.shipperId; }
            set
            {

                //must be greater than -1
                if (value > -1)
                {
                    this.shipperId = value;
                }
                else
                {
                    this.shipperId = 0;
                }
            }
        }
        public string CompanyName
        {
            get { return this.companyName; }
            set { this.companyName = value; }
        }
        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }

        public Shipper() : this(-1, "n/a", "n/a")

        {

            // Empty Constructor


        }
        // Methods
        public Shipper(int aShipperId, string aCompanyName, string aPhone)



        {

            this.ShipperId = aShipperId;
            this.CompanyName = aCompanyName;
            this.Phone = aPhone;


        }
        // Methods Go Here
        public override string ToString()
        {
            string message = "";
            message = message + "ShipperId: " + this.ShipperId + "\n";
            message = message + "CompanyName: " + this.CompanyName + "\n";
            message = message + "Phone" + this.Phone + "\n";
            return message;



        }

    }

}