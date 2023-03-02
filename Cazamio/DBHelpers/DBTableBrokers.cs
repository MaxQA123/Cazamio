using CazamioProgect.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.DBHelpers
{
    public class DBTableBrokers
    {
        public static string GetBrokerIdAgentByEmail(string idBroker)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM Brokers WHERE UserId IN" +
                           " (SELECT Id FROM AspNetUsers WHERE Email = @Email);", db);
                command.Parameters.AddWithValue("@Email", DbType.String).Value = idBroker;
                db.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        data = reader.GetValue(0).ToString();
                    }
                }
            }
            return data;
        }

        public static string GetLastIdNewAgent()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM" +
                    " Brokers WHERE Id = (SELECT MAX(Id) FROM Brokers);", db);
                db.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        data = reader.GetValue(0).ToString();
                    }
                }
            }
            return data;
        }

        public static string GetIdByUserId(string userId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM Brokers WHERE UserId = @UserId", db);
                command.Parameters.AddWithValue("@UserId", DbType.String).Value = userId;
                db.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        data = reader.GetValue(0).ToString();
                    }
                }
            }
            return data;
        }

        public static string GetLastMarketplaceIdNewAgentByUserId()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT MarketplaceId FROM Brokers" +
                    " WHERE UserId IN" +
                    " (SELECT UserId FROM Brokers WHERE Id = (SELECT MAX(Id) FROM Brokers));", db);
                db.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        data = reader.GetValue(0).ToString();
                    }
                }
            }
            return data;
        }

        public static string GetIsDeletedAgentByEmail(string idAgent)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT IsDeleted FROM Brokers WHERE UserId IN" +
                      " (SELECT Id FROM AspNetUsers WHERE Email = @Email);", db);
                command.Parameters.AddWithValue("@Email", DbType.String).Value = idAgent;
                db.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        data = reader.GetValue(0).ToString();
                    }
                }
            }
            return data;
        }
    }
}
