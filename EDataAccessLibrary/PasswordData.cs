using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using EDataAccessLibrary.Models;


namespace EDataAccessLibrary
{

    public class PasswordData : IPasswordData
    {
        private readonly ISqlDataAccess _db;

        public PasswordData(ISqlDataAccess db)
        {
            _db = db;
        }
        public Task<List<PasswordModel>> GetPasswords()
        {
            string sql = "select Id,Service, UserName, Password, UserId, PassKey, PassIV from dbo.Passwords";

            return _db.LoadData<PasswordModel, dynamic>(sql, new { });
        }

        public async Task<decimal> InsertPassword(PasswordModel password)
        {
            string sql = @"insert into dbo.Passwords (Service, UserName, Password, UserId, PassKey, PassIV)
                           values (@Service, @UserName, @Password, @UserId, @PassKey, @PassIV)";
            return await _db.SaveData(sql, password);
        }
        public Task UpdatePassword(PasswordModel password, int ID)
        {
            string sql = @"update dbo.Passwords set Service = @Service, UserName = @UserName, Password = @Password where Id = @ID;";
            return _db.SaveData(sql, password);
        }
        public Task DeletePassword(int ID)
        {
            string sql = @"delete from dbo.Passwords where Id = @Id;";
            return _db.SaveData(sql, new { Id = ID });
        }

    }
}