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
    public class DBTableTenantApartmentFavorites
    {
        public static string GetLastId()
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

        public static string GetLastIdByTenantIdEmail(string id)
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

        public static string GetLastTenantIdById()
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

        public static string GetLastApartmentIdById()
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
