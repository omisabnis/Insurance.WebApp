using Insurance.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Insurance.Web.Controllers
{
    
    public class OrdersController : Controller
    {
        private readonly IOrdersService _orderService;
        public OrdersController(IOrdersService orderService)
        {
            _orderService = orderService;
        }

        public ActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public JsonResult GetOrders()
        {
            var orders = _orderService.GetAllOrders();
            return Json(orders, JsonRequestBehavior.AllowGet);
        }
    }
}