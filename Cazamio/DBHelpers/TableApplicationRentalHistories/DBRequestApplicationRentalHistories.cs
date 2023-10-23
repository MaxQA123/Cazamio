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
            public static string DeleteRecordByApartmentApplicationId(long? apartmentApplicationId)
            {
                string data = null;
                using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
                {
                    SqlCommand command = new("DELETE FROM ApplicationRentalHistories WHERE ApartmentApplicationId = @apartmentApplicationId", db);

                    command.Parameters.AddWithValue("@apartmentApplicationId", DbType.String).Value = apartmentApplicationId;

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
