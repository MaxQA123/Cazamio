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
    public class DBRequestTenantLeases
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
        public class TenantLeases
        {
            public static string DeleteRecordByEmailMarketplaceIdOnlyTenantApplicant(int marketplaceId, string email)
            {
                string data = null;
                using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
                {
                    SqlCommand command = new("DELETE FROM TenantLeases WHERE TenantId" + 
                               " IN" +
                               " (SELECT Id FROM Tenants WHERE UserId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @Email AND MarketplaceId = @MarketplaceId))", db);
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

            public static string DeleteRecordByApartmentApplicationIdOnlyTenantApplicant(long? apartmentApplicationId, string emailTenant, int marketplaceId)
            {
                string data = null;
                using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
                {
                    SqlCommand command = new("DELETE FROM TenantLeases WHERE ApartmentApplicationId = @ApartmentApplicationId" +
                               " AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM Tenants WHERE UserId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @EmailTenant AND MarketplaceId = @MarketplaceId))", db);

                    command.Parameters.AddWithValue("@ApartmentApplicationId", DbType.String).Value = apartmentApplicationId;
                    command.Parameters.AddWithValue("@EmailTenant", DbType.String).Value = emailTenant;
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

            public static string DeleteRecordByApartmentApplicationIdTenantAppOccGuar(long? apartmentApplicationId, string emailTenantCreator, int marketplaceId, string emailTenantOccupant, string emailTenantGuarantor)
            {
                string data = null;
                using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
                {
                    SqlCommand command = new("DELETE FROM TenantLeases" +
                               " WHERE ApartmentApplicationId = @ApartmentApplicationId" +
                               " AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM Tenants WHERE UserId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @EmailTenantCreator OR Email = @EmailTenantOccupant OR Email = @EmailTenantGuarantor AND MarketplaceId = @MarketplaceId))", db);

                    command.Parameters.AddWithValue("@ApartmentApplicationId", DbType.String).Value = apartmentApplicationId;
                    command.Parameters.AddWithValue("@EmailTenantCreator", DbType.String).Value = emailTenantCreator;
                    command.Parameters.AddWithValue("@MarketplaceId", DbType.String).Value = marketplaceId;
                    command.Parameters.AddWithValue("@EmailTenantOccupant", DbType.String).Value = emailTenantOccupant;
                    command.Parameters.AddWithValue("@EmailTenantGuarantor", DbType.String).Value = emailTenantGuarantor;

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

    public class DBRequestTenantLeasesOLD
    {
        public static string GetLastApartmentApplicationId()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT DISTINCT ApartmentApplicationId" +
                    " FROM TenantLeases" +
                    " WHERE ApartmentApplicationId = (SELECT MAX(ApartmentApplicationId)" +
                    " FROM TenantLeases); ", db);
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

        public static string GetApartmentApplicationIdByIdTenantId(string id)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT TOP(1) ApartmentApplicationId" +
                    " FROM Tenants INNER JOIN TenantLeases" +
                    " ON TenantId IN" +
                    " (SELECT Id FROM Tenants WHERE Id = @Id)" +
                    " AND TenantLeases.ApartmentApplicationId = (SELECT MAX(ApartmentApplicationId)" +
                    " FROM TenantLeases);", db);
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

        public static string GetIsLeaseSignedByTenantIdApartmentApplicationId(string id, string apartmentApplicationId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT IsLeaseSigned" +
                    " FROM TenantLeases WHERE TenantId = @Id AND ApartmentApplicationId = @ApartmentApplicationId", db);
                command.Parameters.AddWithValue("@Id", DbType.String).Value = id;
                command.Parameters.AddWithValue("@ApartmentApplicationId", DbType.String).Value = apartmentApplicationId;
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
