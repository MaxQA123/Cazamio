using CazamioProgect.Helpers;
using CazamioProject.DBHelpers.TableAspNetUsers;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.DBHelpers
{
    public class DBRequestAspNetUsers
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
        public class AspNetUsers
        {
            public static DBModelsAspNetUsers GetMarketplaceIdByEmailAndMarketplaceId(string email, int marketplaceId)
            {
                var row = new DBModelsAspNetUsers();

                // SQL запрос для выборки данных
                string query = "SELECT MarketplaceId" +
                               " FROM AspNetUsers" +
                               " WHERE Email = @Email AND MarketplaceId = @MarketplaceId";
                try
                {
                    using SqlConnection connection = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB);
                    using SqlCommand command = new(query, connection);
                    connection.Open();

                    // Параметризованный запрос с двумя параметрами
                    command.Parameters.AddWithValue("@Email", DbType.String).Value = email;
                    command.Parameters.AddWithValue("@MrketplaceId", DbType.String).Value = marketplaceId;

                    using SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        row.MarketplaceId = GetValueOrDefault<long>(reader, 0);
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

            public static string DeleteCreatedUser(string email, int marketplaceId)
            {
                string data = null;
                using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
                {
                    SqlCommand command = new("DELETE" +
                               " FROM AspNetUsers" +
                               " WHERE Email = @Email AND MarketplaceId = @MarketplaceId", db);
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

            public static string DeleteNewlyCreatedTenantNotAddedToSystemAndApplication(long? apartmentId, long? apartmentApplicationId, string emailTenant, int marketplaceId)
            {
                string data = null;
                using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
                {
                    SqlCommand command = new("DELETE FROM ChatCursors WHERE UserId" +
                                " IN" +
                                " (SELECT UserId FROM Tenants WHERE UserId" +
                                " IN" +
                                " (SELECT Id FROM AspNetUsers WHERE Email = @emailTenant AND MarketplaceId = @marketplaceId))" +
                                " DELETE FROM ApartmentHistories WHERE TenantId" +
                                " IN" +
                                " (SELECT Id FROM AspNetUsers WHERE Email = @emailTenant AND MarketplaceId = @marketplaceId)" +
                                " DELETE FROM ApartmentApplicationProgress WHERE ApartmentApplicationId = @apartmentApplicationId" +
                                " AND TenantId" +
                                " IN" +
                                " (SELECT Id FROM Tenants WHERE UserId" +
                                " IN" +
                                " (SELECT Id FROM AspNetUsers WHERE Email = @emailTenant AND MarketplaceId = @marketplaceId))" +
                                " DELETE FROM ApplicationPrices WHERE ApartmentApplicationId = @apartmentApplicationId" +
                                " DELETE FROM TenantLeases WHERE ApartmentApplicationId = @apartmentApplicationId" +
                                " AND TenantId" +
                                " IN" +
                                " (SELECT Id FROM Tenants WHERE UserId" +
                                " IN" +
                                " (SELECT Id FROM AspNetUsers WHERE Email = @emailTenant AND MarketplaceId = @marketplaceId))" +
                                " DELETE FROM ApartmentApplications WHERE ApartmentId = @apartmentId" +
                                " AND TenantId" +
                                " IN" +
                                " (SELECT Id FROM AspNetUsers WHERE Email = @emailTenant AND MarketplaceId = @marketplaceId)" +
                                " DELETE FROM Tenants" +
                                " WHERE UserId IN(SELECT Id FROM AspNetUsers WHERE Email = @emailTenant AND MarketplaceId = @marketplaceId)" +
                                " DELETE FROM AspNetUsers" +
                                " WHERE Email = @emailTenant AND MarketplaceId = @marketplaceId", db);
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

            public static string GetEmailByEmailAndMarketplaceId(string email, int marketplaceId)
            {
                string data = null;
                using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
                {
                    SqlCommand command = new("SELECT Email" +
                               " FROM AspNetUsers" +
                               " WHERE Email = @Email AND MarketplaceId = @MarketplaceId", db);
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

            public static string GetMarketplaceId(string email, string marketplaceId)
            {
                string data = null;
                using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
                {
                    SqlCommand command = new("SELECT MarketplaceId" +
                               " FROM AspNetUsers" +
                               " WHERE Email = @Email AND MarketplaceId = @MarketplaceId", db);
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


    public class DBRequestAspNetUsersOld
    {
        public static string GetIdByEmailMarketplaceId(string idTenant, string marketplaceId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM AspNetUsers" +
                    " WHERE Email = @Email AND MarketplaceId = @MarketplaceId", db);
                command.Parameters.AddWithValue("@Email", DbType.String).Value = idTenant;
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

        public static string GetIdByEmail(string email)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new($"SELECT Id FROM AspNetUsers WHERE Email = {email}", db);
                //command.Parameters.AddWithValue("@Email", DbType.String).Value = email;
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

        public static string GetMarketplaceIdAgentByEmail(string marketplaceId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT MarketplaceId" +
                    " FROM AspNetUsers WHERE Email = @Email", db);
                command.Parameters.AddWithValue("@Email", DbType.String).Value = marketplaceId;
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

        public static string GetFirstNameAgentByEmail(string firstName)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT FirstName" +
                    " FROM AspNetUsers WHERE Email = @Email", db);
                command.Parameters.AddWithValue("@Email", DbType.String).Value = firstName;
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

        public static string GetIdForBrokerFromAspNetUsers(string idBroker)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM" +
                    " AspNetUsers WHERE Email = @Email;", db);
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

        public static string GetMarketplaceIdForBrokerByEmail(string idBroker)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT MarketplaceId FROM" +
                    " AspNetUsers WHERE Email = @Email;", db);
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

        public static string GetFirstNameBrokerByEmail(string firstName)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT FirstName" +
                    " FROM AspNetUsers WHERE Email = @Email", db);
                command.Parameters.AddWithValue("@Email", DbType.String).Value = firstName;
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

        public static string GetLastMarketplaceIdNewTenant()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT MarketplaceId FROM AspNetUsers" +
                           " WHERE Id = (SELECT MAX(Id) FROM AspNetUsers);", db);
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

        public static string GetEmailComfirmedByEmail(string emailConfirmed)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT EmailConfirmed FROM AspNetUsers" +
                           " WHERE Email = @Email", db);
                command.Parameters.AddWithValue("@Email", DbType.String).Value = emailConfirmed;
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

        public static string GetEmailByUserName(string email)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Email FROM" +
                    " AspNetUsers WHERE UserName = @UserName", db);
                command.Parameters.AddWithValue("@UserName", DbType.String).Value = email;
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

        public static string GetFirstNameByUserName(string firstName)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT FirstName FROM" +
                    " AspNetUsers WHERE UserName = @UserName", db);
                command.Parameters.AddWithValue("@UserName", DbType.String).Value = firstName;
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

        public static string GetMarketplaceIdTwoByEmailMaxMarketplaceId(string email)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT MarketplaceId" +
                    " FROM AspNetUsers" +
                    " WHERE MarketplaceId = (SELECT MAX(MarketplaceId) FROM AspNetUsers)" +
                    " AND Email = @Email", db);
                command.Parameters.AddWithValue("@Email", DbType.String).Value = email;
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

        public static string GetMarketplaceIdOneByEmailMinMarketplaceId(string email)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT MarketplaceId" +
                    " FROM AspNetUsers" +
                    " WHERE MarketplaceId = (SELECT MIN(MarketplaceId) FROM AspNetUsers)" +
                    " AND Email = @Email", db);
                command.Parameters.AddWithValue("@Email", DbType.String).Value = email;
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

        public static string GetIdByEmailMarketplaceIdNewTenant(string email, string marketplaceId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id" +
                    " FROM AspNetUsers WHERE Email = @Email AND MarketplaceId = @MarketplaceId", db);
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

        public static string GetEmailByIdNew(string id)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Email" +
                    " FROM AspNetUsers WHERE Id = @Id", db);
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
    }
}
