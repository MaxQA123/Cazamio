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
    public class DBTableAspNetUsers
    {
        public static string GetIdByEmailMarketplaceIdForTenant(string idTenant, string marketplaceId)
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
    }
}
