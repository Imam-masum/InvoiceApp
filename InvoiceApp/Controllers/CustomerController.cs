using InvoiceApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceApp.Controllers
{
    
    public class CustomerController : Controller
    {
        private AppDbContext context;
        public CustomerController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var cust=context.Customers.ToList();
            return View(cust);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            if(ModelState.IsValid)
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
            return View();
        }
        public IActionResult Edit(int id)
        {
            var cus=context.Customers.FirstOrDefault(x => x.Id == id);
            return View(cus);
        }
        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            if(ModelState.IsValid)
            {
                context.Customers.Update(customer);
                context.SaveChanges();
            }
            return View();
        }
        public IActionResult Delete(Customer customer)
        {
           
               context.Remove(customer);
            
            return View();
        }
    }
}
