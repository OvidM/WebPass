using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using EDataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace EDataAccessLibrary
{
    public interface ISqlDataAccess
    {
        string ConnectionStringName { get; set; }

        Task<List<T>> LoadData<T, U>(string sql, U parameters);
        Task<decimal> SaveData<T>(string sql, T parameters);
    }
}