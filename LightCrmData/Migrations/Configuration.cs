namespace LightCrmData.Migrations
{
    using LightCrmData.Helpers;
    using LightCrmData.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LightCrmData.CrmContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LightCrmData.CrmContext context)
        {
            /*if (!context.Users.Any())
            {
                User c = new User
                {
                    Id = 1,
                    Name = "admin", Surname = "", Patronymic = "",
                    Password = Cripto.Sha256("admin"),
                };

                context.Users.Add(c);
                context.SaveChanges();
            }*/

           /* try
            {
                context.IncomesCategories.AddOrUpdate(
                    p => p.Name,
                    new IncomesCategory { Name = "Аренда", Id = Guid.NewGuid() },
                    new IncomesCategory { Name = "Бизнес", Id = Guid.NewGuid() },
                    new IncomesCategory { Name = "Дивиденды", Id = Guid.NewGuid() },
                    new IncomesCategory { Name = "Зарплата", Id = Guid.NewGuid() },
                    new IncomesCategory { Name = "Иное", Id = Guid.NewGuid() },
                    new IncomesCategory { Name = "Корректировка", Id = Guid.NewGuid() },
                    new IncomesCategory { Name = "Кредит", Id = Guid.NewGuid() },
                    new IncomesCategory { Name = "Пенсия", Id = Guid.NewGuid() },
                    new IncomesCategory { Name = "Подарки", Id = Guid.NewGuid() },
                    new IncomesCategory { Name = "Премия", Id = Guid.NewGuid() },
                    new IncomesCategory { Name = "Проценты", Id = Guid.NewGuid() },
                    new IncomesCategory { Name = "Фриланс", Id = Guid.NewGuid() }
                );
            }
            catch
            {

            }

            try
            {
                context.ExpensesCategories.AddOrUpdate(
                    p => p.Name,
                    new ExpensesCategory { Name = "Авто", Id = Guid.NewGuid() },
                    new ExpensesCategory { Name = "Автозапчасти", Id = Guid.NewGuid() },
                    new ExpensesCategory { Name = "Алкоголь", Id = Guid.NewGuid() },
                    new ExpensesCategory { Name = "Бары", Id = Guid.NewGuid() },
                    new ExpensesCategory { Name = "Бензин", Id = Guid.NewGuid() },
                    new ExpensesCategory { Name = "Бизнес", Id = Guid.NewGuid() },
                    new ExpensesCategory { Name = "Благотворительность", Id = Guid.NewGuid() },
                    new ExpensesCategory { Name = "Сбережения", Id = Guid.NewGuid() },
                    new ExpensesCategory { Name = "Гигиена", Id = Guid.NewGuid() },
                    new ExpensesCategory { Name = "Для дома", Id = Guid.NewGuid() },
                    new ExpensesCategory { Name = "Домашние животные", Id = Guid.NewGuid() },
                    new ExpensesCategory { Name = "Еда", Id = Guid.NewGuid() },
                    new ExpensesCategory { Name = "Здоровье", Id = Guid.NewGuid() },
                    new ExpensesCategory { Name = "Иное", Id = Guid.NewGuid() },
                    new ExpensesCategory { Name = "Интернет", Id = Guid.NewGuid() },
                    new ExpensesCategory { Name = "Кафе", Id = Guid.NewGuid() },
                    new ExpensesCategory { Name = "Косметика", Id = Guid.NewGuid() },
                    new ExpensesCategory { Name = "Лекарства", Id = Guid.NewGuid() },
                    new ExpensesCategory { Name = "Образование", Id = Guid.NewGuid() },
                    new ExpensesCategory { Name = "Одежа", Id = Guid.NewGuid() },
                    new ExpensesCategory { Name = "Отдых", Id = Guid.NewGuid() },
                    new ExpensesCategory { Name = "Подарки", Id = Guid.NewGuid() },
                    new ExpensesCategory { Name = "Развлечения", Id = Guid.NewGuid() },
                    new ExpensesCategory { Name = "Ремонт", Id = Guid.NewGuid() },
                    new ExpensesCategory { Name = "Рестораны", Id = Guid.NewGuid() },
                    new ExpensesCategory { Name = "Саморазвитие", Id = Guid.NewGuid() },
                    new ExpensesCategory { Name = "Сладости", Id = Guid.NewGuid() },
                    new ExpensesCategory { Name = "Такси", Id = Guid.NewGuid() },
                    new ExpensesCategory { Name = "Телефон", Id = Guid.NewGuid() },
                    new ExpensesCategory { Name = "Техника", Id = Guid.NewGuid() },
                    new ExpensesCategory { Name = "Транспорт", Id = Guid.NewGuid() },
                    new ExpensesCategory { Name = "Хотелки", Id = Guid.NewGuid() }
                );
            }
            catch
            {

            }*/
        }
    }
}
