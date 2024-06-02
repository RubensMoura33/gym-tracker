using Dapper;
using GymTracker.Utils.DTOs;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace GymTracker.Infra.Data.DAOs.User;

public class UserDAO : IUserDAO
{
    private readonly string _connectionString;

    public UserDAO()
    {
        IConfigurationRoot config = new ConfigurationBuilder()
            .AddUserSecrets<UserDAO>()
            .Build();

        _connectionString = config["ConnectionStrings:LocalHost"]!;
    }

    public async Task<UserLoginDTO> GetUserByEmail(string userEmail)
    {
        try
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                string query = @"
                    SELECT
                        users.user_id AS userId,
                        users.name AS userName,
                        users.password_hash AS userHash,
                        users.password_salt AS userSalt
                    FROM users
                    WHERE users.email = @email
                ";

                return (await connection.QueryFirstOrDefaultAsync<UserLoginDTO>(query, new { email = userEmail }))!;
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
}
