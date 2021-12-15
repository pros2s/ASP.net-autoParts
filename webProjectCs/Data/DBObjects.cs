using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webProjects.Data.Models;

namespace webProjects.Data {
    public class DBObjects {
        public static void Initial(AppDBContent content) {

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));
            if (!content.Car.Any()) {
                content.AddRange(
                    new Car {
                        name = "Блок управления реле",
                        shortDesc = "",
                        img = "/img/1.jpg",
                        durability = "350 000км",
                        manufacturer = "Mazda",
                        isFavorite = true,
                        price = 7500,
                        Category = Categories["Двигатель"]
                    },
                    new Car {
                        name = "Катушка зажигания",
                        shortDesc = "",
                        img = "/img/2.jpg",
                        durability = "200 000км",
                        manufacturer = "Mazda",
                        price = 17289,
                        Category = Categories["Двигатель"]
                    },
                    new Car {
                        name = "Свечи зажигания",
                        shortDesc = "",
                        img = "/img/3.jpg",
                        durability = "60 000км",
                        isFavorite = true,
                        manufacturer = "Mazda",
                        price = 2000,
                        Category = Categories["Двигатель"]
                    },
                    new Car {
                        name = "Провода высоковольтные ",
                        shortDesc = "",
                        img = "/img/4.jpg",
                        durability = "нет заявленного срока",
                        manufacturer = "Mazda",
                        price = 5000,
                        Category = Categories["Двигатель"]
                    },
                    new Car {
                        name = "Подушка двигателя",
                        shortDesc = "",
                        img = "/img/5.jpg",
                        durability = "350 000км",
                        manufacturer = "Mazda",
                        price = 4000,
                        Category = Categories["Двигатель"]
                    },
                    new Car {
                        name = "Ролик натяжителя",
                        shortDesc = "",
                        img = "/img/6.jpg",
                        durability = "100 000км",
                        manufacturer = "Mazda",
                        price = 2500,
                        Category = Categories["Двигатель"]
                    },
                    new Car {
                        name = "Дроссельная заслонка",
                        shortDesc = "",
                        img = "/img/7.jpg",
                        durability = "350 000км",
                        manufacturer = "Mazda",
                        price = 54000,
                        Category = Categories["Двигатель"]
                    },
                    new Car {
                        name = "Блок воздушного фильтра",
                        shortDesc = "",
                        img = "/img/8.jpeg",
                        durability = "нет заявленного срока",
                        manufacturer = "Mazda",
                        price = 5000,
                        Category = Categories["Двигатель"]
                    },
                    new Car {
                        name = "Блок цилиндров",
                        shortDesc = "",
                        img = "/img/9.jpg",
                        durability = "350 000км",
                        manufacturer = "Mazda",
                        price = 60000,
                        Category = Categories["Двигатель"]
                    },
                    new Car {
                        name = "Ремень приводной",
                        shortDesc = "",
                        img = "/img/10.jpg",
                        durability = "В зависимости от манеры езды",
                        manufacturer = "Mazda",
                        price = 6000,
                        Category = Categories["Двигатель"]
                    },
                    new Car {
                        name = "Рычаги",
                        shortDesc = "",
                        img = "/img/11.jpg",
                        durability = "120 000км",
                        manufacturer = "Mazda",
                        price = 12000,
                        Category = Categories["Ходовая"]
                    },
                    new Car {
                        name = "Стойки стабилизатора",
                        shortDesc = "",
                        img = "/img/12.jpg",
                        durability = "80 000км",
                        manufacturer = "Mazda",
                        price = 2000,
                        Category = Categories["Ходовая"]
                    },
                    new Car {
                        name = "Сайлентблок",
                        shortDesc = "",
                        img = "/img/13.jpg",
                        durability = "60 000км",
                        manufacturer = "Mazda",
                        price = 800,
                        Category = Categories["Ходовая"]
                    },
                    new Car {
                        name = "Амортизаторы",
                        shortDesc = "",
                        img = "/img/14.jpg",
                        durability = "120 000км",
                        manufacturer = "Mazda",
                        isFavorite = true,
                        price = 17000,
                        Category = Categories["Ходовая"]
                    },
                    new Car {
                        name = "Шаровая опора",
                        shortDesc = "",
                        img = "/img/15.jpg",
                        durability = "60 000км",
                        manufacturer = "Mazda",
                        price = 4000,
                        Category = Categories["Ходовая"]
                    },
                    new Car {
                        name = "Ступичный подшипник",
                        shortDesc = "",
                        img = "/img/17.jpg",
                        durability = "120 000 км",
                        isFavorite = true,
                        manufacturer = "Mazda",
                        price = 6000,
                        Category = Categories["Ходовая"]
                    },
                    new Car {
                        name = "Шрус",
                        shortDesc = "",
                        img = "/img/18.jpg",
                        durability = "120 000 км",
                        manufacturer = "Mazda",
                        price = 4000,
                        Category = Categories["Ходовая"]
                    },
                    new Car {
                        name = "Тормозные диски",
                        shortDesc = "",
                        img = "/img/19.jpg",
                        durability = "В зависимости от манеры езды",
                        manufacturer = "Mazda",
                        price = 6000,
                        Category = Categories["Ходовая"]
                    },
                    new Car {
                        name = "Суппорта",
                        shortDesc = "",
                        img = "/img/20.1.jpg",
                        durability = "В зависимости от манеры езды",
                        manufacturer = "Mazda",
                        price = 15000,
                        Category = Categories["Ходовая"]
                    },
                    new Car {
                        name = "Защита картера",
                        shortDesc = "",
                        img = "/img/21.jpg",
                        durability = "В зависимости от манеры езды",
                        manufacturer = "Mazda",
                        price = 4000,
                        Category = Categories["Ходовая"]
                    },
                    new Car {
                        name = "Магнитола",
                        shortDesc = "",
                        img = "/img/22.jpg",
                        durability = "нет заявленного срока",
                        manufacturer = "Mazda",
                        price = 12000,
                        Category = Categories["Салон"]
                    },
                    new Car {
                        name = "Подлокотник",
                        shortDesc = "",
                        img = "/img/23.jpg",
                        durability = "нет заявленного срока",
                        manufacturer = "Mazda",
                        price = 4000,
                        Category = Categories["Салон"]
                    },
                    new Car {
                        name = "Ручка КПП",
                        shortDesc = "",
                        img = "/img/24.jpg",
                        durability = "нет заявленного срока",
                        manufacturer = "Mazda",
                        price = 2000,
                        Category = Categories["Салон"]
                    },
                    new Car {
                        name = "Рулевое колесо",
                        shortDesc = "",
                        img = "/img/25.jpg",
                        durability = "нет заявленного срока",
                        manufacturer = "Mazda",
                        price = 20000,
                        Category = Categories["Салон"]
                    },
                    new Car {
                        name = "Дверные карты",
                        shortDesc = "",
                        img = "/img/26.jpg",
                        isFavorite = true,
                        durability = "нет заявленного срока",
                        manufacturer = "Mazda",
                        price = 10000,
                        Category = Categories["Салон"]
                    },
                    new Car {
                        name = "Панель приборов",
                        shortDesc = "",
                        isFavorite = true,
                        img = "/img/27.jpg",
                        durability = "нет заявленного срока",
                        manufacturer = "Mazda",
                        price = 40000,
                        Category = Categories["Салон"]
                    },
                    new Car {
                        name = "Подстаканники",
                        shortDesc = "",
                        img = "/img/28.jpg",
                        durability = "нет заявленного срока",
                        manufacturer = "Mazda",
                        price = 2000,
                        Category = Categories["Салон"]
                    },
                    new Car {
                        name = "Бардачок",
                        shortDesc = "",
                        img = "/img/29.jpg",
                        durability = "нет заявленного срока",
                        manufacturer = "Mazda",
                        price = 4000,
                        Category = Categories["Салон"]
                    },
                    new Car {
                        name = "Зеркало заднего вида",
                        shortDesc = "",
                        img = "/img/30.jpg",
                        durability = "нет заявленного срока",
                        manufacturer = "Mazda",
                        price = 6000,
                        Category = Categories["Салон"]
                    },
                    new Car {
                        name = "Устройство беспроводной зарядки ",
                        shortDesc = "",
                        img = "/img/31.jpg",
                        durability = "нет заявленного срока",
                        manufacturer = "Mazda",
                        price = 15000,
                        Category = Categories["Салон"]
                    },
                    new Car {
                        name = "Капот",
                        shortDesc = "",
                        img = "/img/32.jpg",
                        durability = "нет заявленного срока",
                        manufacturer = "Mazda",
                        price = 30000,
                        Category = Categories["Кузов"]
                    },
                    new Car {
                        name = "Двери",
                        shortDesc = "",
                        img = "/img/33.jpg",
                        durability = "нет заявленного срока",
                        manufacturer = "Mazda",
                        isFavorite = true,
                        price = 28000,
                        Category = Categories["Кузов"]
                    },
                    new Car {
                        name = "Крышка багажника",
                        shortDesc = "",
                        img = "/img/34.jpg",
                        durability = "нет заявленного срока",
                        isFavorite = true,
                        manufacturer = "Mazda",
                        price = 40000,
                        Category = Categories["Кузов"]
                    },
                    new Car {
                        name = "накладки на пороги",
                        shortDesc = "",
                        img = "/img/35.jpg",
                        durability = "нет заявленного срока",
                        manufacturer = "AKS",
                        price = 2000,
                        Category = Categories["Кузов"]
                    },
                    new Car {
                        name = "Спойлер",
                        shortDesc = "",
                        img = "/img/36.jpg",
                        durability = "нет заявленного срока",
                        manufacturer = "AKS",
                        price = 4000,
                        Category = Categories["Кузов"]
                    },
                    new Car {
                        name = "Бампер передний",
                        shortDesc = "",
                        img = "/img/37.jpg",
                        durability = "нет заявленного срока",
                        manufacturer = "Mazda",
                        price = 20000,
                        Category = Categories["Кузов"]
                    },
                    new Car {
                        name = "Бампер задний",
                        shortDesc = "",
                        img = "/img/38.jpg",
                        durability = "нет заявленного срока",
                        manufacturer = "Mazda",
                        price = 12000,
                        Category = Categories["Кузов"]
                    },
                    new Car {
                        name = "Лобовое стекло",
                        shortDesc = "",
                        img = "/img/39.jpg",
                        isFavorite = true,
                        durability = "нет заявленного срока",
                        manufacturer = "Mazda",
                        price = 15000,
                        Category = Categories["Кузов"]
                    },
                    new Car {
                        name = "Зеркала заднего вида",
                        shortDesc = "",
                        img = "/img/40.jpg",
                        durability = "нет заявленного срока",
                        manufacturer = "Mazda",
                        price = 7000,
                        Category = Categories["Кузов"]
                    },
                    new Car {
                        name = "Заднее стекло",
                        shortDesc = "",
                        img = "/img/41.jpg",
                        isFavorite = true,
                        durability = "нет заявленного срока",
                        manufacturer = "Mazda",
                        price = 12000,
                        Category = Categories["Кузов"]
                    }
                );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories {
            get {
                if (category == null) {
                    var list = new Category[] {
                        new Category {
                            categoryName = "Двигатель",
                            desc = "Двигатель — устройство, преобразующее какой-либо вид энергии в механическую работу. Термин мотор заимствован в первой половине XIX века из немецкого языка и преимущественно им называют электрические двигатели и двигатели внутреннего сгорания. Двигатели подразделяют на первичные и вторичные. К первичным относят непосредственно преобразующие природные энергетические ресурсы в механическую работу, а ко вторичным — преобразующие энергию, выработанную или накопленную другими источниками. К первичным двигателям (ПД) относятся ветряное колесо, использующее силу ветра, водяное колесо и гиревой механизм — их приводит в действие сила гравитации (падающая вода и сила притяжения), тепловые двигатели — в них химическая энергия топлива или ядерная энергия преобразуются в другие виды энергии. Ко вторичным двигателям (ВД) относятся электрические, пневматические и гидравлические двигатели."
                        },
                        new Category {
                            categoryName = "Ходовая",
                            desc = "Ходовая часть автомобиля служит для перемещения транспортного по дороге. Ходовая часть устроена таким образом, чтобы человеку было удобно, комфортно передвигаться."
                        },
                        new Category {
                            categoryName = "Салон",
                            desc = "При выборе машины человек отталкивается от различных требований, пожеланий и личных предпочтений. Одним важна повышенная проходимость, и низкий уровень комфорта они готовы простить. Другие расставляют приоритеты так, чтобы на первом месте была безопасность и удобство для пассажиров и самого водителя."
                        },
                        new Category {
                            categoryName = "Кузов",
                            desc = "Автомобиль состоит из множества элементов, которые слаженно работают вместе. Основными из них принято считать двигатель, ходовую часть и трансмиссию. Однако, все они закреплены на несущей системе, которая и обеспечивает их взаимодействие. Несущая система может быть представлена разными вариантами, но наиболее популярным является кузов автомобиля. Это важный конструктивный элемент, который обеспечивает крепление составных частей транспортного средства, размещение пассажиров и грузов в салоне, а также воспринимает все нагрузки во время движения."
                        }
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category element in list)
                        category.Add(element.categoryName, element);
                }

                return category;
            }
        }
    }
}
