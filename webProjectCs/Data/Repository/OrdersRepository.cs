using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webProjects.Data.Interfaces;
using webProjects.Data.Models;

namespace webProjects.Data.Repository {
    public class OrdersRepository : IAllOrders {
        private readonly AppDBContent appDbContent;
        private readonly ShopCart shopCart;

        public OrdersRepository(AppDBContent appDbContent, ShopCart shopCart) {
            this.appDbContent = appDbContent;
            this.shopCart = shopCart;
        }
        public void createOrder(Order order) {
            order.orderTime = DateTime.Now;
            appDbContent.Order.Add(order);

            var items = shopCart.listShopItems;

            foreach(var el in items) {
                var orderDetail = new orderDetail() {
                    carId = el.car.id,
                    orderId = order.id,
                    price = el.car.price
                };
                appDbContent.orderDetail.Add(orderDetail);
            }
            appDbContent.SaveChanges();
        }
    }
}
