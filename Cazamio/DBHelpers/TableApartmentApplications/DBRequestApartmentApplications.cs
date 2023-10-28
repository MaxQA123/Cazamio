using CazamioProgect.Helpers;
using CazamioProject.DBHelpers.TableApartmentApplications;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.Helpers
{
    public class DBRequestApartmentApplications
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
        public class ApartmentApplications
        {
            public static string DeleteRecordByEmailMarketplaceId(int marketplaceId, string email)
            {
                string data = null;
                using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
                {
                    SqlCommand command = new("DELETE FROM ApartmentApplications WHERE TenantId" + 
                               " IN" +
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

            public static DBModelsApartmentApplications GetApartmentApplicationIdByApartmentIdTenantEmail(long? apartmentId, string tenantEmail, int marketplaceId)
            {
                var row = new DBModelsApartmentApplications();

                // SQL запрос для выборки данных
                string query = "SELECT AA.Id" +
                       " FROM ApartmentApplications AA" +
                       " LEFT JOIN AspNetUsers ANU" +
                       " ON ANU.Id = TenantId" +
                       " WHERE ApartmentId = @ApartmentId AND ANU.Id" +
                       " IN" +
                       " (SELECT Id FROM AspNetUsers WHERE Email = @TenantEmail AND MarketplaceId = @MarketplaceId)";
                try
                {
                    using SqlConnection connection = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB);
                    using SqlCommand command = new(query, connection);
                    connection.Open();

                    // Параметризованный запрос с двумя параметрами
                    command.Parameters.AddWithValue("@ApartmentId", DbType.String).Value = apartmentId;
                    command.Parameters.AddWithValue("@TenantEmail", DbType.String).Value = tenantEmail;
                    command.Parameters.AddWithValue("@MarketplaceId", DbType.String).Value = marketplaceId;

                    using SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        row.Id = GetValueOrDefault<long?>(reader, 0);
                    }

                }
                catch (Exception ex)
                {
                    throw new ArgumentException($"Error: {ex.Message}\r\n{ex.StackTrace}");
                }
                finally
                {

                    // Обеспечиваем освобождение ресурсов
                    SqlConnection.ClearAllPools();
                }

                return row;
            }

            public static string DeleteRecordByApartmentId(long? apartmentId, string emailTenant)
            {
                string data = null;
                using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
                {
                    SqlCommand command = new("DELETE FROM ApartmentApplications WHERE ApartmentId = @ApartmentId" +
                               " AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @Email)", db);

                    command.Parameters.AddWithValue("@ApartmentId", DbType.String).Value = apartmentId;
                    command.Parameters.AddWithValue("@Email", DbType.String).Value = emailTenant;

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

    public class DBRequestApartmentApplicationsOLD
    {
        public static string GetLastApartmentApplicationId()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM ApartmentApplications" +
                    " WHERE Id = (SELECT MAX(Id) FROM ApartmentApplications)", db);
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

        public static string GetLastApartmentApplicationIdByApartmentId(string apartmentId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id" +
                    " FROM ApartmentApplications" +
                    " WHERE ApartmentId = @ApartmentId", db);
                command.Parameters.AddWithValue("@ApartmentId", DbType.String).Value = apartmentId;
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

        public static string GetLastApartmentApplicationIdByTenantId(string tenantId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id" +
                    " FROM ApartmentApplications" +
                    " WHERE TenantId = @TenantId", db);
                command.Parameters.AddWithValue("@TenantId", DbType.String).Value = tenantId;
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

        public static string GetApartmentApplicationIdByTenantIdApartmentid(string tenantId, string buildingId, string unit)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM ApartmentApplications" +
                    " WHERE TenantId = @TenantId AND ApartmentId IN" +
                    " (SELECT Id FROM Apartments WHERE BuildingId = @BuildingId AND Unit = @Unit)", db);
                command.Parameters.AddWithValue("@TenantId", DbType.String).Value = tenantId;
                command.Parameters.AddWithValue("@BuildingId", DbType.String).Value = buildingId;
                command.Parameters.AddWithValue("@Unit", DbType.String).Value = unit;
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
