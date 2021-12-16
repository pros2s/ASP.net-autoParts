using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webProjects.Data.Interfaces;
using webProjects.Data.Models;

namespace webProjects.Controllers {
    public class OrderController : Controller {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;

        public OrderController(IAllOrders allOrders, ShopCart shopCart) {
            this.allOrders = allOrders;
            this.shopCart = shopCart;
        }

        public IActionResult checkout() {
            return View();
        }

        [HttpPost]
        public IActionResult checkout(Order order) {
            shopCart.listShopItems = shopCart.getShopItems();

            if(shopCart.listShopItems.Count == 0) {
                ModelState.AddModelError("", "Отсутствуют товары в корзине");
            }

            if(ModelState.IsValid) {
                allOrders.createOrder(order);

                return RedirectToAction("Complete");
            }

            return View(order);
        }

        public IActionResult Complete() {
            ViewBag.Message = "Заказ успешно обработан";
            return View();
        }
    }
}
