using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal interface IAuthenticationService
    {
        public bool AuthenticateUser(string user_n, string user_password);
        public bool AuthorizeUser(string username);

    }

    internal class BasicAuthenticationService : IAuthenticationService
    {
        public string? user_name { set; get; }
        public string? password { get; set; }

        public BasicAuthenticationService()
        {
            user_name = "mohamedwalid@gmail.com" ;
            password = "Mody24636";
        }



        public bool AuthenticateUser(string user_n,string user_password )
        {
            if (user_name == user_n && password == user_password)
                return true;
            else 
                return false;
        }


        public bool AuthorizeUser (string username)
        {
            if (username == "mohamed")
                return true;
            else return false;
        }



       

    }







}
