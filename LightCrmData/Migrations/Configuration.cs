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
            if (!context.Roles.Any())
            {
                Role role = new Role
                {
                    Id = 1,
                    Name = "Администратор"
                };

                context.Roles.Add(role);
                context.SaveChanges();
            }

            if (!context.Departments.Any())
            {
                Department department = new Department
                {
                    Id = 1,
                    Name = "Администратор"
                };

                context.Departments.Add(department);
                context.SaveChanges();
            }

            if (!context.Users.Any())
            {
                User user = new User
                {
                    Id = 1, 
                    Username = "admin",
                    Name = "Администратор",
                    Surname = "",
                    Patronymic = "",
                    Password = Cripto.Sha256("admin"), 
                    RoleId = 1,
                    DepartmentId = 1
                };

                context.Users.Add(user);
                context.SaveChanges();
            }



            try
            {
                context.Roles.AddOrUpdate(
                    p => p.Name,
                    new Role { Name = "Оператор", Id = 2 },
                    new Role { Name = "Врач", Id = 3 },
                    new Role { Name = "Медсестра", Id = 4 }
                );
            }
            catch
            {

            }

            try
            {
                context.Departments.AddOrUpdate(
                    p => p.Name,
                    new Department { Name = "Хирургия", Id = 2 },
                    new Department { Name = "Гинекология", Id = 3 },
                    new Department { Name = "Гастроэнтерология", Id = 4 },
                    new Department { Name = "Гематология", Id = 5 },
                    new Department { Name = "Детская хирургия", Id = 6 },
                    new Department { Name = "Дерматовенерология", Id = 7 },
                    new Department { Name = "Комбустиология", Id = 8 },
                    new Department { Name = "Нейрохирургия", Id = 9 },
                    new Department { Name = "Неонатология", Id = 10 },
                    new Department { Name = "Онкология", Id = 11 },
                    new Department { Name = "Оториноларингология", Id = 12 },
                    new Department { Name = "Офтальмология", Id = 13 },
                    new Department { Name = "Педиатрия", Id = 14 },
                    new Department { Name = "Ревматология", Id = 15 },
                    new Department { Name = "Сердечно-сосудистая хирургия", Id = 16 },
                    new Department { Name = "Травматология", Id = 17 },
                    new Department { Name = "Урология", Id = 18 }
                );
            }
            catch
            {

            }
        }
    }
}
