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
using PanGamesFunction.Response;

namespace PanGamesFunction.Function
{
    public class GameFunction
    {
        [FunctionName("GameFunction")]
        public IActionResult RunGame(
    [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "game/{number}/{login}")] HttpRequest req, string number, string login)
        {
            ResponseGame response = new ResponseGame();
            UserInfo user = new UserInfo();
            UserInfoRepository userInfoCRUD = new UserInfoRepository();
            user.Login = login;
            user.HiddenNumber = userInfoCRUD.GetUserByLogin(user.Login).HiddenNumber;
            try
            {
                int? example = Convert.ToInt16(number);
            }
            catch(Exception ex)
            {
                response.numberGuessed = false;
                response.message = "Введите число от 1 до 100";
                return new OkObjectResult(response);
            }
            if (Convert.ToInt16(number) == user.HiddenNumber)
            {
                response.message = "Число отгадано";
                return new OkObjectResult(response);
            }
            else if (Convert.ToInt16(number) < user.HiddenNumber)
            {
                response.message = "Ваше число меньше загаданного";
                return new OkObjectResult(response);
            }
            else if (Convert.ToInt16(number) > user.HiddenNumber)
            {
                response.message = "Ваше число больше загаданного";
                return new OkObjectResult(response);
            }
            return null;
        }
    }
}
