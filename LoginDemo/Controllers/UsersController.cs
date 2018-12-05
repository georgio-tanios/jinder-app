using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using LoginDemo.DTO;

namespace LoginDemo.Controllers
{
    public class UsersController : ApiController
    {
        [Route ("api/users/Signup")]
        public HttpResponseMessage Post([FromBody] SignupInfo info)
        {
            JinderDBEntities dbContext = new JinderDBEntities();
            var usersTable = dbContext.JinderUsers;

            JinderUser jinderUser = (from user in usersTable
                                     where user.Username == info.Username
                                     select user).FirstOrDefault<JinderUser>();

            HttpResponseMessage message = new HttpResponseMessage();

            if (jinderUser != null)
            {
                message.StatusCode = HttpStatusCode.Conflict;
                message.Content = new StringContent("Username: " + info.Username + " is already registered.");

                return message;
            }

            JinderUser newUser = new JinderUser();

            newUser.Username = info.Username;
            newUser.Password = info.Password;
            newUser.FullName = info.Fullname;
            newUser.DateOfBirth = info.DateOfBirth;
            newUser.Gender = info.Gender;
            newUser.Address = info.Address;
            newUser.UserType = info.UserType;

            usersTable.Add(newUser);
            dbContext.SaveChanges();

            
            message.StatusCode = HttpStatusCode.Created;
            return message;
        }

        [Route("api/users/Login")]
        public HttpResponseMessage Post([FromBody] LoginInfo info)
        {

        }
    }
}
