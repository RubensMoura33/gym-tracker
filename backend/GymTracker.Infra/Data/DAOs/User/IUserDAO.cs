using GymTracker.Utils.DTOs;

namespace GymTracker.Infra.Data.DAOs.User;

public interface IUserDAO
{
    Task<UserLoginDTO> GetUserByEmail(string userEmail);
    Task<IEnumerable<RankUserDTO>> RankUsersByLikes();
    Task<IEnumerable<RankUserDTO>> RankUsersByLastProfileUpdate();
}
