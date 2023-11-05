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
    public class DBRequestOccupants
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
        public class Occupants
        {
            public static string DeleteRecordByEmailMarketplaceIdForTenantOcc(long? apartmentApplicationId, string emailTenantOccupant)
            {
                string data = null;
                using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
                {
                    SqlCommand command = new("DELETE FROM Occupants" +
                               " WHERE ApartmentApplicationId = ApartmentApplicationId AND Contacts = @EmailTenantOccupant", db);
                    command.Parameters.AddWithValue("@ApartmentApplicationId", DbType.String).Value = apartmentApplicationId;
                    command.Parameters.AddWithValue("@EmailTenantOccupant", DbType.String).Value = emailTenantOccupant;
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

    public class DBRequestOccupantsOLD
    {
        public static string GetLastOccupantIdByApartmentApplicationId(string guarantorId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM Occupants WHERE ApartmentApplicationId = @ApartmentApplicationId", db);
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
