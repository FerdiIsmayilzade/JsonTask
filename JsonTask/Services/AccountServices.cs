using JsonTask.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace JsonTask.Services
{
    internal class AccountServices
    {
        const string path = "C:\\Users\\Acer\\OneDrive\\Masaüstü\\CSharp\\JsonTask\\JsonTask\\User.json";
        public List<User> GetUsers()
        {
            using (StreamReader sr=new StreamReader(path))
            {
                var list=JsonConvert.DeserializeObject< List < User >> (sr.ReadToEnd());
                return list ?? new List<User>();
                
            }
            
        }
        public bool Login(string username, string password)
        {
            AccountServices accountServices = new AccountServices();
            var users = accountServices.GetUsers();
            foreach (var user in users)
            {
                if(user.Email == username && user.Password==password)
                {
                    return true;
                }
                
            }
            return false;
        }

        

       




        
    }
}
