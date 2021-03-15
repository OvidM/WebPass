using System.Threading.Tasks;
using System.Collections.Generic;
using EDataAccessLibrary.Models;

namespace EDataAccessLibrary
{
    public interface IUsersData
    {
        Task<List<UserModel>> GetUsers();
        Task<decimal> InsertUser(UserModel user);
    }
}