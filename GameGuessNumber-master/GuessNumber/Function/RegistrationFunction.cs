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
    public class RegistrationFunction
    {
        [FunctionName("RegistrationFunction")]
        public IActionResult RunAuth(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = "registration/{login}/{password}/{repeatPassword}")] HttpRequest req,
        string login, string password, string repeatPassword)
        {
            RegistrationFunctionResponse respose = new RegistrationFunctionResponse();
            if (password == repeatPassword)
            {
                UserInfoRepository auth = new UserInfoRepository();
                UserInfo user = new UserInfo();
                user.Login = login;
                user.Password = password;
                if (auth.Add(user) == true)
                {
                    respose.successfulRegistration = true;
                    respose.message = "Успешная регистрация";
                    return new OkObjectResult(respose);
                }else
                {
                    respose.successfulRegistration = false;
                    respose.message = "Такой логин уже используется";
                    return new OkObjectResult(respose);
                }
            }else
            {
                respose.coincidencePassword = false;
                respose.message = "Пароли не совпадают";
                return new OkObjectResult(respose);
            }

        }
    }
}
