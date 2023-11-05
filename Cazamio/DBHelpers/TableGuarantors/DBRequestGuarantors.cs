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
    public class DBRequestGuarantors
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
        public class Guarantors
        {
            public static string DeleteRecordByEmailMarketplaceIdForTenantGuar(long? apartmentApplicationId, string emailTenantGuarantor)
            {
                string data = null;
                using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
                {
                    SqlCommand command = new("DELETE FROM Guarantors" +
                               " WHERE ApartmentApplicationId = @ApartmentApplicationId AND Email = @EmailTenantGuarantor", db);
                    command.Parameters.AddWithValue("@ApartmentApplicationId", DbType.String).Value = apartmentApplicationId;
                    command.Parameters.AddWithValue("@EmailTenantGuarantor", DbType.String).Value = emailTenantGuarantor;
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

    public class DBRequestGuarantorsOLD
    {
        public static string GetLastGuarantorIdByApartmentApplicationId(string guarantorId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM Guarantors WHERE ApartmentApplicationId = @ApartmentApplicationId", db);
                command.Parameters.AddWithValue("@ApartmentApplicationId", DbType.String).Value = guarantorId;
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
