using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.Helpers
{
    public class DBApplications
    {
        public static string GetTenantIdApplicant(string idApplicant)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM Tenants WHERE UserId IN" +
                " (SELECT Id FROM AspNetUsers WHERE UserName = 'tenantswife@gmail.com'); ", db);
                command.Parameters.AddWithValue("@UserName", DbType.String).Value = idApplicant;
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

        public static string GetTenantIOccupant(string idOccupant)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM Tenants WHERE UserId IN" +
                " (SELECT Id FROM AspNetUsers WHERE UserName = 'apipostman65455@gmail.com'); ", db);
                command.Parameters.AddWithValue("@UserName", DbType.String).Value = idOccupant;
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

        public static string GetTenantIGuarantor(string idGuarantor)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM Tenants WHERE UserId IN" +
                " (SELECT Id FROM AspNetUsers WHERE UserName = 'guarantor5935@gmail.com'); ", db);
                command.Parameters.AddWithValue("@UserName", DbType.String).Value = idGuarantor;
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

        public static string GetLastIdFromApartmentApplicationProgress()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT ApartmentApplicationId" +
                    " FROM ApartmentApplicationProgress" +
                    " WHERE ApartmentApplicationId = (SELECT MAX(ApartmentApplicationId)" +
                    " FROM ApartmentApplicationProgress);", db);
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

        public static string GetApartmentApplicationIdApplicant()
        {
            string tenantIdApplicant = "38";

            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT ApartmentApplicationId" +
                    " FROM ApartmentApplicationProgress" +
                    " WHERE TenantId = '38'" +
                    " AND ApartmentApplicationId = (SELECT MAX(ApartmentApplicationId)" +
                    " FROM ApartmentApplicationProgress);", db);
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

        public static string GetApartmentApplicationIdOccupant()
        {
            string tenantIdOccupant = "47";

            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT ApartmentApplicationId" +
                    " FROM ApartmentApplicationProgress" +
                    " WHERE TenantId = '47'" +
                    " AND ApartmentApplicationId = (SELECT MAX(ApartmentApplicationId)" +
                    " FROM ApartmentApplicationProgress);", db);
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

        public static string GetApartmentApplicationIdGuarantor()
        {
            string tenantIdGuarantor = "48";

            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT ApartmentApplicationId" +
                    " FROM ApartmentApplicationProgress" +
                    " WHERE TenantId = '48'" +
                    " AND ApartmentApplicationId = (SELECT MAX(ApartmentApplicationId)" +
                    " FROM ApartmentApplicationProgress);", db);
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

        public static string GetNewApartmentApplicationId()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT MAX(ApartmentApplicationId) ApartmentApplicationId" +
                    " FROM ApartmentApplicationApplicants;", db);
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

        public static string GetApartmentApplicationIdOccGua()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT TOP (2) ApartmentApplicationId" +
                    " FROM ApartmentApplicationApplicants ORDER BY Id DESC;", db);
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

        public static string GetApartmentApplicationIdGuarantorS()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT MAX(ApartmentApplicationId) ApartmentApplicationId" +
                    " FROM ApartmentApplicationApplicants;", db);
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

        public static string GetApartmentApplicationIdByUserIdOcc()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT MAX(ApartmentApplicationId) ApartmentApplicationId" +
                    " FROM ApartmentApplicationApplicants" +
                    " WHERE UserId = '1397a512-6600-40d8-95cd-e76f1e3af5e2';", db);
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

        public static string GetApartmentApplicationIdByEmailOcc(string apartmentApplicationId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT ApartmentApplicationId" +
                    " FROM Occupants WHERE Contacts ='apipostman65455@gmail.com'" +
                    " AND ApartmentApplicationId = (SELECT MAX(ApartmentApplicationId) FROM Occupants);", db);
                command.Parameters.AddWithValue("@Contacts", DbType.String).Value = apartmentApplicationId;
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

        public static string GetApartmentApplicationIdByEmailGua(string apartmentApplicationId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT ApartmentApplicationId" +
                    " FROM Guarantors WHERE Contacts ='guarantor5935@gmail.com'" +
                    " AND ApartmentApplicationId = (SELECT MAX(ApartmentApplicationId) FROM Guarantors);", db);
                command.Parameters.AddWithValue("@Contacts", DbType.String).Value = apartmentApplicationId;
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

        public static string GetApartmentApplicationIdByUserIdGua()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT MAX(ApartmentApplicationId) ApartmentApplicationId" +
                    " FROM ApartmentApplicationApplicants" +
                    " WHERE UserId = '149fcd30-8ddb-4c3d-9ffb-4c466861f25a';", db);
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

