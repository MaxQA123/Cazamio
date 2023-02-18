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
    public class DBTenants
    {

        public static string GetLastIdByEmailFromTenantBackgroundChecks(string email, string marketplaceId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM TenantBackgroundChecks" +
                    " WHERE Id = (SELECT MAX(Id) FROM TenantBackgroundChecks) OR TenantId IN" +
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

        public static string GetLastIdFromTenantBackgroundChecks()
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

        public static string GetLastIdCreditScreeningFromTenantBackgroundChecks(string email, string marketplaceId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM TenantBackgroundChecks" +
                    " WHERE BackgroundCheckType = 'CreditScreening' AND TenantId IN" +
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

        public static string GetLastBackgroundCheckByTenantIdFromTenantBackgroundChecks(string email, string backgroundCheck)
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

        public static string GetLastBackgroundCheckFromTenantBackgroundChecks(string backgroundCheck)
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

        public static string GetNameBackgroundCheckFromTenantBackgroundChecks(string id)
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

        public static string GetNameCreditScreeningFromTenantBackgroundChecks(string id)
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

        public static string GetCheckStatusBackgroundCheckFromTenantBackgroundChecks(string id, string backgroundCheck)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT CheckStatus" +
                    " FROM TenantBackgroundChecks" +
                    " WHERE Id = @Id AND BackgroundCheckType = @BackgroundCheck", db);
                command.Parameters.AddWithValue("@Id", DbType.String).Value = id;
                command.Parameters.AddWithValue("@BackgroundCheck", DbType.String).Value = backgroundCheck;
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

        public static string GetCheckStatusCreditScreeningFromTenantBackgroundChecks(string id, string creditScreening)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT CheckStatus" +
                    " FROM TenantBackgroundChecks" +
                    " WHERE Id = @Id AND BackgroundCheckType = @CreditScreening", db);
                command.Parameters.AddWithValue("@Id", DbType.String).Value = id;
                command.Parameters.AddWithValue("@CreditScreening", DbType.String).Value = creditScreening;
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

        public static string GetFirstNameTenantTableTenantExtractedIdentities()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT FirstName" +
                    " FROM TenantExtractedIdentities" +
                    " WHERE TenantId = (SELECT MAX(TenantId) FROM TenantExtractedIdentities);", db);
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

        public static string GetLastNameTenantTableTenantExtractedIdentities()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT LastName" +
                    " FROM TenantExtractedIdentities" +
                    " WHERE TenantId = (SELECT MAX(TenantId) FROM TenantExtractedIdentities);", db);
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

        public static string GetLastApartmentApplicationIdfromTenantLeases()
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

        public static string GetApartmentApplicationIdForApplicantTableTenantLeases(string id)
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

        public static string GetApartmentApplicationIdForOccupantTableTenantLeases(string id)
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

        public static string GetApartmentApplicationIdForGuarantorTableTenantLeases(string id)
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

        public static string GetIsLeaseSignedFromTenantLeases(string id, string apartmentApplicationId)
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

        public static string GetNewIdTableTenantApartmentFavorites()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM TenantApartmentFavorites" +
                    " WHERE Id = (SELECT MAX(Id) FROM TenantApartmentFavorites);", db);
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

        public static string GetNewIdByTenantIdFromTenantApartmentFavorites(string id)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM" +
                    " TenantApartmentFavorites WHERE TenantId IN" +
                    " (SELECT Id FROM AspNetUsers WHERE Email = @Email);", db);
                command.Parameters.AddWithValue("@Email", DbType.String).Value = id;
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

        public static string GetNewTenantIdTableTenantApartmentFavorites()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT TenantId" +
                    " FROM TenantApartmentFavorites WHERE Id IN" +
                    " (SELECT MAX(Id) FROM TenantApartmentFavorites);", db);
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

        public static string GetNewApartmentIdTableTenantApartmentFavorites()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT ApartmentId" +
                    " FROM TenantApartmentFavorites WHERE Id IN" +
                    " (SELECT MAX(Id) FROM TenantApartmentFavorites);", db);
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
