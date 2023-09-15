using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs;
using PanGamesFunction.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanGamesFunction.Function
{
    public class GameStartFunction
    {
        [FunctionName("GameStartFunction")]
        public IActionResult RunStartGame(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "startgame/{login}/{password}")] HttpRequest req, string login, string password)
        {
            Random random = new Random();
            UserInfo user = new UserInfo();
            user.Login = login;
            user.Password = password;
            user.HiddenNumber = random.Next(1, 5);
            UserInfoRepository userInfoCRUD = new UserInfoRepository();
            user.GamesCount = userInfoCRUD.GetUserByLogin(user.Login).GamesCount + 1;
            userInfoCRUD.Update(user);
            return new OkObjectResult(user);
        }
    }
}
