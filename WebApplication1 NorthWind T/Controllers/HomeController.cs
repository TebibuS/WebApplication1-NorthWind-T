using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication1_NorthWind_T.Models;

namespace WebApplication1_NorthWind_T.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            File_Gateway aGateway = new File_Gateway();
            
           
            
            List<Category> aListOfCategories = aGateway.GetCategory("C:\\Users\\tebib\\source\\repos\\WebApplication1 NorthWind T\\WebApplication1 NorthWind T\\Categories.csv");
            ViewBag.ListOfCategories = aListOfCategories;
        



            List<Employee> aListOfEmployees = aGateway.GetEmployee("C:\\Users\\tebib\\source\\repos\\WebApplication1 NorthWind T\\WebApplication1 NorthWind T\\Employees.csv");
            ViewBag.ListOfEmployees = aListOfEmployees;


            List<OrderDetail> aListOfOrderDetails = aGateway.GetOrderDetail("C:\\Users\\tebib\\source\\repos\\WebApplication1 NorthWind T\\WebApplication1 NorthWind T\\OrderDetails.csv");
            ViewBag.ListOfOrderDetails = aListOfOrderDetails;


            List<Product> aListOfProducts = aGateway.GetProduct("C:\\Users\\tebib\\source\\repos\\WebApplication1 NorthWind T\\WebApplication1 NorthWind T\\Products.csv");
            ViewBag.ListOfProducts = aListOfProducts;


            List<Shipper> aListOfShippers = aGateway.GetShipper("C:\\Users\\tebib\\source\\repos\\WebApplication1 NorthWind T\\WebApplication1 NorthWind T\\Shippers.csv");
            ViewBag.ListOfShippers = aListOfShippers;
        

            List<Supplier> aListOfSuppliers = aGateway.GetSupplier("C:\\Users\\tebib\\source\\repos\\WebApplication1 NorthWind T\\WebApplication1 NorthWind T\\suppliers.csv");
            ViewBag.ListOfSuppliers = aListOfSuppliers;



            return View();



        }


    }
}
