using HelloPlusApi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Newtonsoft.Json;

namespace HelloPlusApi
{
    public class DBNotifier : DataAccess, INotifier
    {

        public string Notify(Message message)
        {
            int insertMsg = DBHandler(message.messageText);

            return message.messageText;
        }


        private int DBHandler(string message)
        {
            try
            {
                DynamicParameters dp = new DynamicParameters();
                dp.Add("Message", message);
                dp.Add("@InsertedId", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                this.DbConnection.Open();
                SqlMapper.Query(this.DbConnection, "InsertMessage", dp, commandType: CommandType.StoredProcedure);
                this.DbConnection.Close();
                int insertedId = dp.Get<int>("@InsertedId");
               return insertedId;
            }
            finally
            {
                this.DbConnection.Close();
            }
        }

        public void Dispose()
        {
            this.Dispose();
        }

    }
}