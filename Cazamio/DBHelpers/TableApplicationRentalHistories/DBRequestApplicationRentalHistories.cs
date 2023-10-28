using CazamioProgect.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.DBHelpers.TableApplicationRentalHistories
{
    public class DBRequestApplicationRentalHistories
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
        public class ApplicationRentalHistories
        {
            public static string DeleteRecordByApartmentApplicationId(long? apartmentApplicationId, string emailTenant, int marketplaceId)
            {
                string data = null;
                using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
                {
                    SqlCommand command = new("DELETE FROM ApplicationRentalHistories WHERE ApartmentApplicationId = @ApartmentApplicationId AND TenantId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @EmailTenant AND MarketplaceId = @MarketplaceId)", db);

                    command.Parameters.AddWithValue("@ApartmentApplicationId", DbType.String).Value = apartmentApplicationId;
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
        }
    }
}
