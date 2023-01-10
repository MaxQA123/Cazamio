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
        public static string GetIdForNewTenantTableTenants()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT MAX(Id) Id FROM Tenants;", db);
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

        public static string GetUserIdForNewTenantTableTenants()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT UserId" +
                    " FROM Tenants WHERE Id = (SELECT MAX(Id) FROM Tenants);", db);
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

        public static string GetIdForNewTenantTableAspNetUsers(string idTenantAspNetUsers)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id" +
                    " FROM AspNetUsers WHERE UserName = 'indigo123fgh@putsbox.com'", db);
                command.Parameters.AddWithValue("@Contacts", DbType.String).Value = idTenantAspNetUsers;
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

        public static string GetRoleIdForNewTenantTableAspNetUserRoles()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT RoleId FROM AspNetUserRoles" +
                    " WHERE UserId IN" +
                    " (SELECT UserId FROM Tenants WHERE Id = (SELECT MAX(Id) FROM Tenants));", db);
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

        public static string GetTenantIdForNewTenantTableTenantBackgroundChecks()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT TOP(1) CheckStatus" +
                    " FROM TenantBackgroundChecks INNER JOIN Tenants" +
                    " ON TenantId IN" +
                    " (SELECT UserId FROM Tenants WHERE Id = (SELECT MAX(Id) FROM Tenants)" +
                    " AND TenantBackgroundChecks.BackgroundCheckType = 'BackgroundCheck'); ", db);
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

        public static string GetTenantIdForNewTenantTableTenantCreditScreening()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT TOP(1) CheckStatus" +
                    " FROM TenantBackgroundChecks INNER JOIN Tenants" +
                    " ON TenantId IN" +
                    " (SELECT UserId FROM Tenants WHERE Id = (SELECT MAX(Id) FROM Tenants)" +
                    " AND TenantBackgroundChecks.BackgroundCheckType = 'CreditScreening'); ", db);
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

        public static string GetNewApartmentApplicationIdTableTenantLeases()
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

        public static string GetApartmentApplicationIdForApplicantTableTenantLeases()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT TOP(1) TenantId, ApartmentApplicationId" +
                    " FROM Tenants INNER JOIN TenantLeases" +
                    " ON TenantId IN" +
                    " (SELECT Id FROM Tenants WHERE Id = '38')" +
                    " AND TenantLeases.ApartmentApplicationId = (SELECT MAX(ApartmentApplicationId) FROM TenantLeases);", db);
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

        public static string GetApartmentApplicationIdForOccupantTableTenantLeases()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT TOP(1) TenantId, ApartmentApplicationId" +
                    " FROM Tenants INNER JOIN TenantLeases" +
                    " ON TenantId IN" +
                    " (SELECT Id FROM Tenants WHERE Id = '47')" +
                    " AND TenantLeases.ApartmentApplicationId = (SELECT MAX(ApartmentApplicationId) FROM TenantLeases);", db);
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

        public static string GetApartmentApplicationIdForGuarantorTableTenantLeases()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT TOP(1) TenantId, ApartmentApplicationId" +
                    " FROM Tenants INNER JOIN TenantLeases" +
                    " ON TenantId IN" +
                    " (SELECT Id FROM Tenants WHERE Id = '48')" +
                    " AND TenantLeases.ApartmentApplicationId = (SELECT MAX(ApartmentApplicationId) FROM TenantLeases);", db);
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
