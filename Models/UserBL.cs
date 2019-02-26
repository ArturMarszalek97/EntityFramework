using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication7.Models;
using WebApplication7.DAL;

namespace WebApplication7.Models
{
    public class UserBL
    {
        public List<User> GetUsers()
        {
            DB mDB = new DB();
            return mDB.userDB.ToList();
        }
        public void AddUser(User u)
        {
            DB mDB = new DB();
            mDB.userDB.Add(u);
            mDB.SaveChanges();
        }
        public void EditUser(User model)
        {
            DB mDB = new DB();
            User user = mDB.userDB.Where(u => u.UserID == model.UserID).Single();
            user.Firstname = model.Firstname;
            user.LastName = model.LastName;
            user.Age = model.Age;
            mDB.SaveChanges();
        }
        public void RemoveUser(int id)
        {
            DB mDB = new DB();
            User user = mDB.userDB.Where(u => u.UserID == id).FirstOrDefault();
            mDB.userDB.Remove(user);
            mDB.SaveChanges();
        }
    }
}