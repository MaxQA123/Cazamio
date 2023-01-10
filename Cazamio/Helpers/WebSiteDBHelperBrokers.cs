using CazamioProgect.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.Helpers
{
    public class DBBrokers
    {
        public static string GetUserIdNewBrokerFromBrokers()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT UserId FROM" +
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

        public static string GetRoleIdNewBrokerFromAspNetUserRoles()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT RoleId FROM AspNetUserRoles" +
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

        public static string GetMarketplaceIdFromBrokers()
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

        public static string GetIdBrokerFromBrokersT(string idBroker)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM Brokers WHERE UserId IN " +
                "(SELECT Id FROM AspNetUsers WHERE Email = 'lkjh456@putsbox.com')", db);
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

        public static string GetLandlordIdByBrokerId(string idBroker)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT LandlordId FROM LandlordBrokers" +
                    " WHERE BrokerId IN" +
                    " (SELECT Id FROM Brokers WHERE UserId IN" +
                    " (SELECT Id FROM AspNetUsers WHERE Email = 'lkjh456@putsbox.com'));", db);
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

        public static string GetLandlordIdForNewBroker()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT LandlordId FROM LandlordBrokers" +
                    " WHERE BrokerId = (SELECT MAX(BrokerId) FROM LandlordBrokers);", db);
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
