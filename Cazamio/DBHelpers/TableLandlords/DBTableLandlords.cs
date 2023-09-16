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
    public class DBRequestLandlords
    {
        private static T GetValueOrDefault<T>(SqlDataReader reader, int index, T defaultValue = default(T))
        {
            if (!reader.IsDBNull(index))
            {
                return (T)reader.GetValue(index);
            }
            else
            {
                return defaultValue;
            }
        }
        public class Landlords
        {
            public static string DeleteCreatedUserBroker(string email, string marketplaceId)
            {
                string data = null;
                using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
                {
                    SqlCommand command = new("DELETE" + 
                               " FROM Landlords" +
                               " WHERE UserId IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @Email AND MarketplaceId = @MarketplaceId)", db);
                    command.Parameters.AddWithValue("@Email", DbType.String).Value = email;
                    command.Parameters.AddWithValue("@MarketplaceId", DbType.String).Value = marketplaceId;
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

    public class DBRequestLandlordsOld
    {
        public static string GetlastLandlordIdForBroker()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM Landlords WHERE" +
                    " Id = (SELECT MAX(Id) FROM Landlords)", db);
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

        public static string GetlastLandlordIdByUserIdForBroker(string userId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM Landlords" +
                    " WHERE UserId = @UserId", db);
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

        public static string GetIdLastForBroker()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT LandlordId FROM Buildings" +
                    " WHERE AddressId = (SELECT MAX(AddressId) FROM Buildings);", db);
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

        public static string GetLandlordIdForBroker(string idAdmin)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT DISTINCT LandlordId" +
                    " FROM Buildings B" +
                    " INNER JOIN Landlords L ON L.Id = B.LandlordId" +
                    " INNER JOIN AspNetUsers U ON U.Id = L.UserId" +
                    " WHERE U.Email = @Email;", db);
                command.Parameters.AddWithValue("@Email", DbType.String).Value = idAdmin;
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

        public static string GetIdForBroker(string idBroker)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM Landlords WHERE UserId IN " +
                "(SELECT Id FROM AspNetUsers WHERE Email = @Email)", db);
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

        public static string GetUserIdNewBroker()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT UserId FROM" +
                    " Landlords WHERE Id = (SELECT MAX(Id) FROM Landlords);", db);
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

        public static string GetMarketplaceIdBroker(string idMarketplace)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT MarketplaceId FROM Landlords WHERE UserId IN " +
                "(SELECT Id FROM AspNetUsers WHERE Email = @Email)", db);
                command.Parameters.AddWithValue("@Email", DbType.String).Value = idMarketplace;
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
