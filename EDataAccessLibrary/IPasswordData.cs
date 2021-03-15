using System.Threading.Tasks;
using System.Collections.Generic;
using EDataAccessLibrary.Models;


namespace EDataAccessLibrary
{
    public interface IPasswordData
    {
        Task DeletePassword(int ID);
        Task<List<PasswordModel>> GetPasswords(int Id);
        Task<decimal> InsertPassword(PasswordModel password);
        Task UpdatePassword(PasswordModel password, int ID);
    }
}