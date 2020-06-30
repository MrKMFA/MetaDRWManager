//Author: Kenneth Arnesen
//Date Created: 2020/06/20
//Description:
//Last Updated: 2020/06/20

using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace MetaDomingoLibrary.Internal.DataAccess
{
    public class SqlDataAccess : IDisposable, ISqlDataAccess
    {
        // *** Private Fields ***
        private IConfiguration _config;
        private readonly ILogger<SqlDataAccess> _logger;
        private bool isClosed = false;
        private IDbConnection _connection;
        private IDbTransaction _transaction;


        // *** Constructor ***
        public SqlDataAccess(IConfiguration config, ILogger<SqlDataAccess> logger)
        {
            _config = config;
            _logger = logger;
        }


        // *** Methods ***
        //-Retrieve DB Connection String from Configuration file based on Key Name 
        public string GetConnString(string name)
        {
            return _config.GetConnectionString(name);
            //var section = _config.GetSection($"{name}");

            //return section.Value;
        }

        //-Generic Method that Retrieves a List of objects from DB 
        public List<T> LoadData<T, U>(string storedProcedure, U parameters, string connectionStringName)
        {
            string connectionString = GetConnString(connectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(storedProcedure, parameters,
                    commandType: CommandType.StoredProcedure).ToList();

                return rows;
            }
        }

        //-Generic Method that Saves a List of objects to DB
        public void SaveData<T>(string storedProcedure, T parameters, string connectionStringName)
        {
            string connectionString = GetConnString(connectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(storedProcedure, parameters,
                    commandType: CommandType.StoredProcedure);
            }
        }

        public void SaveData<T, U>(string storedProcedure, U parameters, string connectionStringName)
        {
            string connectionString = GetConnString(connectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(storedProcedure, parameters,
                    commandType: CommandType.StoredProcedure);
            }
        }

        //-Start a transaction within selected DB
        public void StartTransaction(string connectionStringName)
        {
            string connectionString = GetConnString(connectionStringName);

            _connection = new SqlConnection(connectionString);
            _connection.Open();

            _transaction = _connection.BeginTransaction();

            isClosed = false;
        }

        //-Generic Method to Persist data within an open transaction 
        public void SaveDataInTransaction<T>(string storedProcedure, T parameters)
        {
            _connection.Execute(storedProcedure, parameters,
               commandType: CommandType.StoredProcedure, transaction: _transaction);
        }

        //-Generic Method to Retrieve data within an open transaction
        public List<T> LoadDataInTransaction<T, U>(string storedProcedure, U parameters)
        {
            List<T> rows = _connection.Query<T>(storedProcedure, parameters,
                commandType: CommandType.StoredProcedure, transaction: _transaction).ToList();

            return rows;
        }

        //-Used to commit an open transaction
        public void CommitTransaction()
        {
            _transaction?.Commit();
            _connection?.Close();

            isClosed = true;
        }

        //-Used to rollback changes within an open transaction
        public void RollbackTransaction()
        {
            _transaction?.Rollback();
            _connection?.Close();

            isClosed = true;
        }

        //-Used to Dispose of a connection object/close connection and free up resources
        public void Dispose()
        {
            if (isClosed == false)
            {
                try
                {
                    CommitTransaction();
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Commit transaction failed in dispose method.");
                }
            }

            _transaction = null;
            _connection = null;
        }
    }
}
