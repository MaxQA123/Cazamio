using CazamioProgect.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.DBHelpers
{
    public class DBTableTenantExtractedIdentities
    {
        public static string GetFirstNameTenantByTenantId()
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

        public static string GetLastNameTenantByTenantId()
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
    }
}
