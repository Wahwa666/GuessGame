using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Npgsql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace PanGamesFunction.DB
{
    public class UserInfoRepository
    {
        private Settings settings = new Settings();

        public bool Add(UserInfo user)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(settings.connectionString))
            {
                connection.Open();
                if ((GetUserByLogin(user.Login) == null))
                {
                    string commandText = $"INSERT INTO {"userinfo"} (Login, Password) VALUES (@login, @password)";
                    using (var cmd = new NpgsqlCommand(commandText, connection))
                    {
                        cmd.Parameters.AddWithValue("Login", user.Login);
                        cmd.Parameters.AddWithValue("Password", user.Password);
                        cmd.ExecuteNonQuery();
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public UserInfo GetUserByLogin(string login)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(settings.connectionString))
            {
                connection.Open();
                string commandText = $"SELECT * FROM {"userinfo"} WHERE Login = @Login";
                using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, connection))
                {
                    cmd.Parameters.AddWithValue("Login", login);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            UserInfo user = UserInfo.ReadUser(reader);
                            return user;
                        }
                }
                return null;
            }
        }
        public bool Update(UserInfo user)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(settings.connectionString))
            {
                connection.Open();
                var commandText = $@"UPDATE {"userinfo"}
                SET Password = @password, GamesCount = @gamescount, HiddenNumber = @hiddennumber
                WHERE login = @login";

                using (var cmd = new NpgsqlCommand(commandText, connection))
                {
                    cmd.Parameters.AddWithValue("Login", user.Login);
                    cmd.Parameters.AddWithValue("Password", user.Password);
                    cmd.Parameters.AddWithValue("GamesCount", user.GamesCount);
                    cmd.Parameters.AddWithValue("HiddenNumber", user.HiddenNumber);
                    cmd.ExecuteNonQuery();
                }
            }
            return true;
        }
    }

   
}
