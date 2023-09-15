using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
//using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PanGamesFunction.DB;
using PanGamesFunction.Response;

namespace PanGamesFunction.Function
{
    public class AuthorizationFunction
    {
        [FunctionName("AuthorizationFunction")]
        public IActionResult RunEnter(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = "authorization/{login}/{password}")] HttpRequest req,
        string login, string password)
        {
            AuthorizationFunctionResponse response = new AuthorizationFunctionResponse();
            UserInfoRepository auth = new UserInfoRepository();
            response.userResponse = auth.GetUserByLogin(login);
            if (response.userResponse == null)
            {
                response.correctInformation = false;
                response.message = "Ќе правильный логин или пользовател€ не существует";
                return new OkObjectResult(response);
            } else
            if ((response.userResponse.Login == login) & (response.userResponse.Password != password))
            {
                response.correctInformation = false;
                response.message = "Ќе правильный пароль";
                return new OkObjectResult(response);
            } else
            if ((response.userResponse.Login == login) & (response.userResponse.Password == password))
            {
                response.correctInformation = true;
                return new OkObjectResult(response);
            }
            return null;
        }
    }
}
