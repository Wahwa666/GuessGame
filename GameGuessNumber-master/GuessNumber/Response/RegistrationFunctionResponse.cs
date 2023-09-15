using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanGamesFunction.Response
{
    public class RegistrationFunctionResponse
    {
        public bool coincidencePassword {  get; set; }
        public bool successfulRegistration { get; set; }
        public string message { get; set; }
    }
}
