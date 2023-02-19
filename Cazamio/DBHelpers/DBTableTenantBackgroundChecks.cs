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
    public class DBTableTenantBackgroundChecks
    {
        public static string GetLastIdByEmailMarketplaceId(string email, string marketplaceId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM TenantBackgroundChecks" +
                    " WHERE Id = (SELECT MAX(Id) FROM TenantBackgroundChecks) AND TenantId IN" +
                    " (SELECT Id FROM AspNetUsers WHERE Email = @Email AND MarketplaceId = @MarketplaceId);", db);
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

        public static string GetLastId()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM TenantBackgroundChecks" +
                    " WHERE Id = (SELECT MAX(Id) FROM TenantBackgroundChecks);", db);
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

        public static string GetLastIdCreditScreeningByBackgroundCheckTypeTenantId(string email, string marketplaceId, string backgroundCheckType)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM TenantBackgroundChecks" +
                    " WHERE BackgroundCheckType = @BackgroundCheckType AND TenantId IN" +
                    " (SELECT Id FROM AspNetUsers WHERE Email = @Email AND MarketplaceId = @MarketplaceId);", db);
                command.Parameters.AddWithValue("@Email", DbType.String).Value = email;
                command.Parameters.AddWithValue("@MarketplaceId", DbType.String).Value = marketplaceId;
                command.Parameters.AddWithValue("@BackgroundCheckType", DbType.String).Value = backgroundCheckType;
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

        public static string GetLastIdBackgroundCheckByTenantIdBackgroundCheckType(string email, string backgroundCheck)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM TenantBackgroundChecks" +
                    " WHERE TenantId = @TenantId AND BackgroundCheckType = @BackgroundCheckType ORDER BY Id DESC;", db);
                command.Parameters.AddWithValue("@TenantId", DbType.String).Value = email;
                command.Parameters.AddWithValue("@BackgroundCheckType", DbType.String).Value = backgroundCheck;
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

        public static string GetLastIdBackgroundCheckBackgroundCheckType(string backgroundCheck)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT TOP (1) Id" +
                    " FROM TenantBackgroundChecks WHERE BackgroundCheckType = @BackgroundCheckType ORDER BY Id DESC;", db);
                command.Parameters.AddWithValue("@BackgroundCheckType", DbType.String).Value = backgroundCheck;
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

        public static string GetNameBackgroundCheckTypeById(string id)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT BackgroundCheckType" +
                    " FROM TenantBackgroundChecks WHERE Id = @Id", db);
                command.Parameters.AddWithValue("@Id", DbType.String).Value = id;
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

        public static string GetNameCheckStatusByIdBackgroundCheckType(string id, string backgroundCheck)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT CheckStatus" +
                    " FROM TenantBackgroundChecks" +
                    " WHERE Id = @Id AND BackgroundCheckType = @BackgroundCheckType", db);
                command.Parameters.AddWithValue("@Id", DbType.String).Value = id;
                command.Parameters.AddWithValue("@BackgroundCheckType", DbType.String).Value = backgroundCheck;
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
