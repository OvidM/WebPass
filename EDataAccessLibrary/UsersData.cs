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
            string sql = "select Id,UserName, Password from dbo.Users";

            return _db.LoadData<UserModel, dynamic>(sql, new { });
        }

        public Task InsertUser(UserModel user)
        {
            string sql = @"insert into dbo.Users (UserName, Password)
                           values (@UserName, @Password);";
            return _db.SaveData(sql, user);
        }
    }
}