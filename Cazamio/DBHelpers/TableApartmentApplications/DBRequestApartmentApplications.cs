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

            public static string DeleteRecordByApartmentId(long? apartmentId, string emailTenant, int marketplaceId)
            {
                string data = null;
                using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
                {
                    SqlCommand command = new("DELETE FROM ApartmentApplications WHERE ApartmentId = @ApartmentId" +
                               " AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @EmailTenant AND MarketplaceId = @MarketplaceId)", db);

                    command.Parameters.AddWithValue("@ApartmentId", DbType.String).Value = apartmentId;
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

            public static string DeleteApartmentApplicationWithTenantsAppOccGuarAlreadyCreated(long? apartmentId, long? apartmentApplicationId, string emailTenantCreator, string emailTenantOccupant, string emailTenantGuarantor, int marketplaceId)
            {
                string data = null;
                using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
                {
                    SqlCommand command = new("DELETE FROM ApplicationGeneralQuestions WHERE ApartmentApplicationId = @ApartmentApplicationId AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @EmailTenantCreator AND MarketplaceId = @MarketplaceId)" +
                               " DELETE FROM ApplicationGeneralQuestions WHERE ApartmentApplicationId = @ApartmentApplicationId AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @EmailTenantOccupant AND MarketplaceId = @MarketplaceId)" +
                               " DELETE FROM ApplicationGeneralQuestions WHERE ApartmentApplicationId = @ApartmentApplicationId AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @EmailTenantGuarantor AND MarketplaceId = @MarketplaceId)" +
                               " DELETE FROM ApplicationBasicInformation WHERE ApartmentApplicationId = @ApartmentApplicationId AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @EmailTenantCreator AND MarketplaceId = @MarketplaceId)" +
                               " DELETE FROM ApplicationBasicInformation WHERE ApartmentApplicationId = @ApartmentApplicationId AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @EmailTenantOccupant AND MarketplaceId = @MarketplaceId)" +
                               " DELETE FROM ApplicationBasicInformation WHERE ApartmentApplicationId = @ApartmentApplicationId AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @EmailTenantGuarantor AND MarketplaceId = @MarketplaceId)" +
                               " DELETE FROM ApplicationRequiredDocuments WHERE ApartmentApplicationId = @ApartmentApplicationId AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @EmailTenantCreator AND MarketplaceId = @MarketplaceId)" +
                               " DELETE FROM ApplicationRequiredDocuments WHERE ApartmentApplicationId = @ApartmentApplicationId AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @EmailTenantOccupant AND MarketplaceId = @MarketplaceId)" +
                               " DELETE FROM ApplicationRequiredDocuments WHERE ApartmentApplicationId = @ApartmentApplicationId AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @EmailTenantGuarantor AND MarketplaceId = @MarketplaceId)" +
                               " DELETE FROM ApplicationRentalHistories WHERE ApartmentApplicationId = @ApartmentApplicationId AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @EmailTenantCreator AND MarketplaceId = @MarketplaceId)" +
                               " DELETE FROM ApplicationRentalHistories WHERE ApartmentApplicationId = @ApartmentApplicationId AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @EmailTenantOccupant AND MarketplaceId = @MarketplaceId)" +
                               " DELETE FROM ApplicationRentalHistories WHERE ApartmentApplicationId = @ApartmentApplicationId AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @EmailTenantGuarantor AND MarketplaceId = @MarketplaceId)" +
                               " DELETE FROM ApplicationOccupations WHERE ApartmentApplicationId = @ApartmentApplicationId AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @EmailTenantCreator AND MarketplaceId = @MarketplaceId)" +
                               " DELETE FROM ApplicationOccupations WHERE ApartmentApplicationId = @ApartmentApplicationId AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @EmailTenantOccupant AND MarketplaceId = @MarketplaceId)" +
                               " DELETE FROM ApplicationOccupations WHERE ApartmentApplicationId = @ApartmentApplicationId AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @EmailTenantGuarantor AND MarketplaceId = @MarketplaceId)" +
                               " DELETE FROM ApartmentApplicationApplicants WHERE ApartmentApplicationId = @ApartmentApplicationId" +
                               " AND UserId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @EmailTenantOccupant AND MarketplaceId = @MarketplaceId)" +
                               " DELETE FROM ApartmentApplicationApplicants WHERE ApartmentApplicationId = @ApartmentApplicationId" +
                               " AND UserId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = 'tenantgua123jim@putsbox.com' AND MarketplaceId = @MarketplaceId)" +
                               " DELETE FROM Guarantors WHERE ApartmentApplicationId = @ApartmentApplicationId AND Email = @EmailTenantGuarantor" +
                               " DELETE FROM Occupants WHERE ApartmentApplicationId = @ApartmentApplicationId AND Contacts = @EmailTenantOccupant" +
                               " DELETE FROM ApplicationPrices WHERE ApartmentApplicationId = @ApartmentApplicationId" +
                               " DELETE FROM ApartmentApplicationProgress WHERE ApartmentApplicationId = @ApartmentApplicationId" +
                               " AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM Tenants WHERE UserId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @EmailTenantCreator AND MarketplaceId = @MarketplaceId))" +
                               " DELETE FROM TenantLeases WHERE ApartmentApplicationId = @ApartmentApplicationId" +
                               " AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM Tenants WHERE UserId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @EmailTenantCreator AND MarketplaceId = @MarketplaceId))" +
                               " DELETE FROM TenantLeases WHERE ApartmentApplicationId = @ApartmentApplicationId" +
                               " AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM Tenants WHERE UserId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @EmailTenantOccupant AND MarketplaceId = @MarketplaceId))" +
                               " DELETE FROM TenantLeases WHERE ApartmentApplicationId = @ApartmentApplicationId" +
                               " AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM Tenants WHERE UserId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @EmailTenantGuarantor AND MarketplaceId = @MarketplaceId))" +
                               " DELETE FROM ApartmentApplications WHERE ApartmentId = @ApartmentId" +
                               " AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @EmailTenantCreator AND MarketplaceId = @MarketplaceId)", db);

                    command.Parameters.AddWithValue("@ApartmentId", DbType.String).Value = apartmentId;
                    command.Parameters.AddWithValue("@ApartmentApplicationId", DbType.String).Value = apartmentApplicationId;
                    command.Parameters.AddWithValue("@EmailTenantCreator", DbType.String).Value = emailTenantCreator;
                    command.Parameters.AddWithValue("@EmailTenantOccupant", DbType.String).Value = emailTenantOccupant;
                    command.Parameters.AddWithValue("@EmailTenantGuarantor", DbType.String).Value = emailTenantGuarantor;
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

            public static string DeleteApartmentApplicationWithTenantsAppOccGuarNotAddedToSystem(long? apartmentId, long? apartmentApplicationId, string emailTenantCreator, string emailTenantOccupant, string emailTenantGuarantor, int marketplaceId)
            {
                string data = null;
                using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
                {
                    SqlCommand command = new("DELETE FROM TenantLeases WHERE ApartmentApplicationId = @apartmentApplicationId" +
                               " AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM Tenants WHERE UserId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @emailTenantCreator OR Email = @emailTenantOccupant OR Email = @emailTenantGuarantor AND MarketplaceId = @marketplaceId))" +
                               " DELETE FROM ApartmentApplicationApplicants WHERE ApartmentApplicationId = @apartmentApplicationId" +
                               " AND UserId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @emailTenantOccupant AND MarketplaceId = @marketplaceId)" +
                               " DELETE FROM ApartmentApplicationApplicants WHERE ApartmentApplicationId = @apartmentApplicationId" +
                               " AND UserId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @emailTenantGuarantor AND MarketplaceId = @marketplaceId)" +
                               " DELETE FROM Guarantors WHERE ApartmentApplicationId = @apartmentApplicationId AND Email = @emailTenantGuarantor" +
                               " DELETE FROM Occupants WHERE ApartmentApplicationId = @apartmentApplicationId AND Contacts = @emailTenantOccupant" +
                               " DELETE FROM ApartmentApplicationProgress WHERE ApartmentApplicationId = @apartmentApplicationId" +
                               " AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM Tenants WHERE UserId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @emailTenantCreator AND MarketplaceId = @marketplaceId))" +
                               " DELETE FROM ApplicationPrices WHERE ApartmentApplicationId = @apartmentApplicationId" +
                               " DELETE FROM ApartmentApplications WHERE ApartmentId = @apartmentId" +
                               " AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @emailTenantCreator AND MarketplaceId = @marketplaceId)", db);

                    command.Parameters.AddWithValue("@apartmentId", DbType.String).Value = apartmentId;
                    command.Parameters.AddWithValue("@apartmentApplicationId", DbType.String).Value = apartmentApplicationId;
                    command.Parameters.AddWithValue("@emailTenantCreator", DbType.String).Value = emailTenantCreator;
                    command.Parameters.AddWithValue("@emailTenantOccupant", DbType.String).Value = emailTenantOccupant;
                    command.Parameters.AddWithValue("@emailTenantGuarantor", DbType.String).Value = emailTenantGuarantor;
                    command.Parameters.AddWithValue("@marketplaceId", DbType.String).Value = marketplaceId;

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

            public static string DeleteApartmentApplicationWithAlreadyCrtdTenantApplicant(long? apartmentId, long? apartmentApplicationId, string emailTenant, int marketplaceId)
            {
                string data = null;
                using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
                {
                    SqlCommand command = new("DELETE FROM TenantLeases WHERE ApartmentApplicationId = @apartmentApplicationId" +
                               " AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM Tenants WHERE UserId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @emailTenant AND MarketplaceId = @marketplaceId))" +
                               " DELETE FROM ApplicationGeneralQuestions WHERE ApartmentApplicationId = @apartmentApplicationId AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @emailTenant AND MarketplaceId = @marketplaceId)" +
                               " DELETE FROM ApplicationBasicInformation WHERE ApartmentApplicationId = @apartmentApplicationId AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @emailTenant AND MarketplaceId = @marketplaceId)" +
                               " DELETE FROM ApplicationRequiredDocuments WHERE ApartmentApplicationId = @apartmentApplicationId AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @emailTenant AND MarketplaceId = @marketplaceId)" +
                               " DELETE FROM ApplicationRentalHistories WHERE ApartmentApplicationId = @apartmentApplicationId AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @emailTenant AND MarketplaceId = @marketplaceId)" +
                               " DELETE FROM ApplicationOccupations WHERE ApartmentApplicationId = @apartmentApplicationId AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @emailTenant AND MarketplaceId = @marketplaceId)" +
                               " DELETE FROM ApplicationPrices WHERE ApartmentApplicationId = @apartmentApplicationId" +
                               " DELETE FROM ApartmentApplicationProgress WHERE ApartmentApplicationId = @apartmentApplicationId" +
                               " AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM Tenants WHERE UserId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @emailTenant AND MarketplaceId = @marketplaceId))" +
                               " DELETE FROM ApartmentApplications WHERE ApartmentId = @apartmentId" +
                               " AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @emailTenant AND MarketplaceId = @marketplaceId)", db);

                    command.Parameters.AddWithValue("@apartmentId", DbType.String).Value = apartmentId;
                    command.Parameters.AddWithValue("@apartmentApplicationId", DbType.String).Value = apartmentApplicationId;
                    command.Parameters.AddWithValue("@emailTenant", DbType.String).Value = emailTenant;
                    command.Parameters.AddWithValue("@marketplaceId", DbType.String).Value = marketplaceId;

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

            public static string DeleteApartmentApplicationWithNewlyCreatedTenantApplicant(long? apartmentId, long? apartmentApplicationId, string emailTenantCreator, int marketplaceId)
            {
                string data = null;
                using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
                {
                    SqlCommand command = new("DELETE FROM TenantLeases WHERE ApartmentApplicationId = @apartmentApplicationId" +
                               " AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM Tenants WHERE UserId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @emailTenantCreator AND MarketplaceId = @marketplaceId))" +
                               " DELETE FROM ApplicationPrices WHERE ApartmentApplicationId = @apartmentApplicationId" +
                               " DELETE FROM ApartmentApplicationProgress WHERE ApartmentApplicationId = @apartmentApplicationId" +
                               " AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM Tenants WHERE UserId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @emailTenantCreator AND MarketplaceId = @marketplaceId))" +
                               " DELETE FROM ApartmentApplications WHERE ApartmentId = @apartmentId" +
                               " AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @emailTenantCreator AND MarketplaceId = @marketplaceId)", db);
                    command.Parameters.AddWithValue("@apartmentId", DbType.String).Value = apartmentId;
                    command.Parameters.AddWithValue("@apartmentApplicationId", DbType.String).Value = apartmentApplicationId;
                    command.Parameters.AddWithValue("@emailTenantCreator", DbType.String).Value = emailTenantCreator;
                    command.Parameters.AddWithValue("@marketplaceId", DbType.String).Value = marketplaceId;

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
