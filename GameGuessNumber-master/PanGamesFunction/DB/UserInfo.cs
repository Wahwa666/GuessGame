using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PanGamesFunction.DB
{

    public class UserInfo
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }
        [JsonPropertyName("login")]
        public string Login { get; set; }
        [JsonPropertyName("password")]
        public string Password { get; set; }
        [JsonPropertyName("gamesCount")]
        public int? GamesCount { get; set; }
        [JsonPropertyName("hiddenNumber")]
        public int? HiddenNumber { get; set; }


        public static UserInfo ReadUser(NpgsqlDataReader reader)
        {
            int? id = reader["id"] as Int32?;
            string login = reader["login"] as string;
            string password = reader["password"] as string;
            int? gamesCount = reader["gamesCount"] as Int32?;
            int? hidenNumber = reader["hiddenNumber"] as Int32?;
            UserInfo user = new UserInfo
            {
                Id = id,
                Login = login,
                Password = password,
                GamesCount = gamesCount,
                HiddenNumber = hidenNumber
            };
            return user;
        }

    }
}
