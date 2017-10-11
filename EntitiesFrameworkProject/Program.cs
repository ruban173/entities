﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesFrameworkProject
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UserContext db = new UserContext())
            {
                // создаем два объекта User
                User user1 = new User { login = "Tom"};
                db.Users.Add(user1);
                db.Users.Add(user1);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                var result = db.Users;
                Console.WriteLine("Список объектов:");
                foreach (User u in result)
                {
                    Console.WriteLine("{0}.{1} - {2}", u.id, u.login, u.password);
                }
            }
            Console.Read();
        }
    }
}
