using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainClasses;

namespace DataLayer {
    public class Query
    {
        readonly PasswordEditConverterModel _db = Db.ConnectionString;
          

        public bool CheckUserAuthetication(string box1, string box2) {

             
            bool doesUserExist = _db.Users.Any(u => u.Name == box1 && u.Password == box2);

            return doesUserExist;

            }

        public void UpdatePassword(string name, string oldPass, string newPass)
        {
           var pass= _db.Users.FirstOrDefault(c => c.Name == name && c.Password == oldPass);
            pass.Password = newPass;
            _db.SaveChanges();

        }
        



            }


       
        }

    
