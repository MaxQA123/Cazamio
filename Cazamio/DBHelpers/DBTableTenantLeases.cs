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
    public class DBTableTenantLeases
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
