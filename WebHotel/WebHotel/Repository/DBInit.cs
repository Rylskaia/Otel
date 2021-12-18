using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebHotel.Models;

namespace WebHotel.Repository
{
    public static class DBInit
    {
        public static void Initialize(HotelContext context)
        {
            context.Database.EnsureCreated();
            if (context.Сотрудник.Any())
            {
                return;
            }

            var user = new Сотрудник
            {
                ФИО = "Admin",
                Логин = "Admin",
                Пароль = "admin",
            };
            context.Сотрудник.Add(user);
            context.SaveChanges();

        }
    }
}