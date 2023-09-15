using PanGamesFunction.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanGamesFunction.Response
{
    public class AuthorizationFunctionResponse
    {
        public bool correctInformation {  get; set; }
        public string message { get; set; }
        public UserInfo userResponse { get; set; }
    }
}
