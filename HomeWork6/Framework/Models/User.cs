using System;
using System.IO;
using System.Collections.Generic;

namespace HomeWork6.Framework.Models
{
    public class User
    {
        
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string Subjects { get; set; }
        public int Hobbies { get; set; }

        public string CurrentAdress { get; set; }
        public int CurrentState { get; set; }




        public User(string rowData)
        {
            string[] data = rowData.Split(",");
            Login = data[0];
            Password = data[1];
            FirstName = data[2];
            LastName = data[3];
        }
        public User()
        {
            FirstName = Utils.RandomName(5);
            LastName = Utils.RandomName(5);
            Email = Utils.RandomName(10)+"g@mail.com";
            MobileNumber = Utils.RandomDigits(10);
            Subjects = Utils.RandomName(10);
            Hobbies = Utils.RandomDigit(0, 4);
            CurrentAdress = Utils.RandomName(10);
            CurrentState = Utils.RandomDigit(0, 4);
        }
        public static List<User> GetUsersFromCSVFile()
        {
            string[] lines = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources/NewUsers.csv"));
            List<User> usersList = new List<User>();
            for (int i = 0; i < lines.Length; i++)
            {
                User us = new User(lines[i]);
                usersList.Add(us);
            }

            return usersList;
        }
        public static User RandomUser()
        {
            User user = new User();
            return user;
        }


    }
}