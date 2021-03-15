using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using EDataAccessLibrary.Models;

namespace EDataAccessLibrary
{

    public class UsersData : IUsersData
    {
        private readonly ISqlDataAccess _db;

        public UsersData(ISqlDataAccess db)
        {
            _db = db;
        }
        public Task<List<UserModel>> GetUsers()
        {
            string sql = "select Id,UserName, Password,PassIV,PassKey  from dbo.Users";

            return _db.LoadData<UserModel, dynamic>(sql, new { });
        }

        public async Task<decimal> InsertUser(UserModel user)
        {
            string sql = @"insert into dbo.Users (UserName, Password, PassIV, PassKey)
                           values (@UserName, @Password, @PassIV, @PassKey);select SCOPE_IDENTITY()";
            return await _db.SaveData(sql, user);
        }
    }
}