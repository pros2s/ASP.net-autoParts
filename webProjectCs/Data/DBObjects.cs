﻿using Microsoft.AspNetCore.Builder;
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
                        img = "../wwwroot/img/1.jpg",
                        durability = "350 000км",
                        manufacturer = "Mazda",
                        price = 7500,
                        Category = Categories["Двигатель"]
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
                        },
                        new Category {
                            categoryName = "Масла, фильтры Автохимия",
                            desc = "Масляный фильтр в двигателе выполняет одну из главных ролей. Смазывающая жидкость, проходящая сквозь него, оставляет на мембране крупные фракции грязи, нагара и стальной стружки, которые негативно сказывались бы на деталях силового агрегата, случись им беспрепятственно курсировать по нему."
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
