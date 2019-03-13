using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using UserManagement.Data;
using UserManagement.Models;
using Microsoft.Azure.ServiceBus;
using Newtonsoft.Json;
using System.Text;

namespace UserManagement.Controllers
{
    public class UsersController : Controller
    {
        private readonly FitnessDbContext fitnessDbContext;
        private readonly ITopicClient topicClient;

        public UsersController(FitnessDbContext fitnessDbContext, ITopicClient topicClient)
        {
            this.fitnessDbContext = fitnessDbContext;
            this.topicClient = topicClient;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterUserViewModel user)
        {
            var userToRegister = new User
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                BirthDate = user.BirthDate,
                EmailAddress = user.EmailAddress,
                MembershipToken = $"{Guid.NewGuid()}"
            };

            fitnessDbContext.Users.Add(userToRegister);
            await fitnessDbContext.SaveChangesAsync();

            await SendMessageAsync(userToRegister);
            await topicClient.CloseAsync();

            return Ok(userToRegister);
        }

        private Task SendMessageAsync(User createdUser)
        {
            var userJson = JsonConvert.SerializeObject(createdUser);
            var message = new Message(Encoding.UTF8.GetBytes(userJson));
            return topicClient.SendAsync(message);
        }
    }
}
