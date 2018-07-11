namespace Univesity.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Univesity.Data.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Univesity.Data.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Faculties.AddOrUpdate(_ => _.DecanName, new Domain.Faculty
            {
                Name = "Информационные Технологии",
                DecanName = "Тесля"
            });
            context.Faculties.AddOrUpdate(_ => _.DecanName, new Domain.Faculty
            {
                Name = "ФИСИД",
                DecanName = "Вощаев"
            });
            context.SaveChanges();

            context.Groups.AddOrUpdate(_ => _.Name, new Domain.Group
            {
                Name = "PI-33",
                FacultyId = 1
            });            
            context.Groups.AddOrUpdate(_ => _.Name, new Domain.Group
            {
                Name = "PI-31",
                FacultyId = 2
            });
            context.Groups.AddOrUpdate(_ => _.Name, new Domain.Group
            {
                Name = "PI-32",
                FacultyId = 1
            });
            context.SaveChanges();

            context.Students.AddOrUpdate(_ => _.CardNumber, new Domain.Student
            {
                FirstName = "Stas",
                LastName = "Netavskyy",
                Age = 21,
                CardNumber = 21565,
                GroupId = 1,
            });
            context.Students.AddOrUpdate(_ => _.CardNumber, new Domain.Student
            {
                FirstName = "Андрей",
                LastName = "Хоменко",
                Age = 22,
                CardNumber = 49031,
                GroupId = 3,
            });
            context.Students.AddOrUpdate(_ => _.CardNumber, new Domain.Student
            {
                FirstName = "Александр",
                LastName = "Константинов",
                Age = 20,
                CardNumber = 67894,
                GroupId = 2,
            });
            context.Students.AddOrUpdate(_ => _.CardNumber, new Domain.Student
            {
                FirstName = "Егор",
                LastName = "Бодянов",
                Age = 19,
                CardNumber = 58391,
                GroupId = 1,
            });
            context.Students.AddOrUpdate(_ => _.CardNumber, new Domain.Student
            {
                FirstName = "Влад",
                LastName = "Тюрин",
                Age = 23,
                CardNumber = 57493,
                GroupId = 2,
            });
            context.Students.AddOrUpdate(_ => _.CardNumber, new Domain.Student
            {
                FirstName = "Саша",
                LastName = "Netavskyy",
                Age = 20,
                CardNumber = 48503,
                GroupId = 3,
            });
            context.Students.AddOrUpdate(_ => _.CardNumber, new Domain.Student
            {
                FirstName = "Рома",
                LastName = "Щукин",
                Age = 21,
                CardNumber = 68493,
                GroupId = 2,
            });
            context.Students.AddOrUpdate(_ => _.CardNumber, new Domain.Student
            {
                FirstName = "Михаил",
                LastName = "Решетняк",
                Age = 21,
                CardNumber = 58431,
                GroupId = 2,
            });
            context.Students.AddOrUpdate(_ => _.CardNumber, new Domain.Student
            {
                FirstName = "Белюк",
                LastName = "Дмитрий",
                Age = 21,
                CardNumber = 57493,
                GroupId = 3,
            });
            context.Students.AddOrUpdate(_ => _.CardNumber, new Domain.Student
            {
                FirstName = "Максим",
                LastName = "Бражененко",
                Age = 40,
                CardNumber = 68503,
                GroupId = 1,
            });
            context.Students.AddOrUpdate(_ => _.CardNumber, new Domain.Student
            {
                FirstName = "Наталия",
                LastName = "Бойченко",
                Age = 19,
                CardNumber = 57593,
                GroupId = 3,
            });
            context.Students.AddOrUpdate(_ => _.CardNumber, new Domain.Student
            {
                FirstName = "Паша",
                LastName = "Козачок",
                Age = 22,
                CardNumber = 57593,
                GroupId = 2,
            });
            context.Students.AddOrUpdate(_ => _.CardNumber, new Domain.Student
            {
                FirstName = "Максим",
                LastName = "Петренко",
                Age = 22,
                CardNumber = 57392,
                GroupId = 1,
            });
            context.Students.AddOrUpdate(_ => _.CardNumber, new Domain.Student
            {
                FirstName = "Женя",
                LastName = "Шевченко",
                Age = 20,
                CardNumber = 75830,
                GroupId = 1,
            });
            context.Students.AddOrUpdate(_ => _.CardNumber, new Domain.Student
            {
                FirstName = "Ясь",
                LastName = "Владимр",
                Age = 31,
                CardNumber = 58493,
                GroupId = 1,
            });
            context.Students.AddOrUpdate(_ => _.CardNumber, new Domain.Student
            {
                FirstName = "Максим",
                LastName = "Соболев",
                Age = 21,
                CardNumber = 57912,
                GroupId = 1,
            });
            context.Students.AddOrUpdate(_ => _.CardNumber, new Domain.Student
            {
                FirstName = "Максим",
                LastName = "Черевко",
                Age = 26,
                CardNumber = 67493,
                GroupId = 3,
            });
            context.Students.AddOrUpdate(_ => _.CardNumber, new Domain.Student
            {
                FirstName = "Сергей",
                LastName = "Кордонец",
                Age = 24,
                CardNumber = 58493,
                GroupId = 3,
            });
            context.Students.AddOrUpdate(_ => _.CardNumber, new Domain.Student
            {
                FirstName = "Святослав",
                LastName = "Давиденко",
                Age = 28,
                CardNumber = 56749,
                GroupId = 3,
            });
        }
    }
}
