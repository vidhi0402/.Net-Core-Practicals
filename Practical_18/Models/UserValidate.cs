﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pr18.Models
{
    public class UserValidate
    {
        public static bool Login(string username, string password)
        {
            UserBL userBL = new UserBL();
            var UserLists = userBL.GetUsers();
            return UserLists.Any(user =>
                user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase)
                && user.Password == password);
        }
        //This method is used to return the User Details
        public static User GetUserDetails(string username, string password)
        {
            UserBL userBL = new UserBL();
            return userBL.GetUsers().FirstOrDefault(user =>
                user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase)
                && user.Password == password);
        }
    }
}