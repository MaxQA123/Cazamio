using CazamioProgect.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.DBHelpers.TableOwnerCommissionsStructure
{
    public class DBRequestOwnerCommissionsStructure
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
        public class OwnerCommissionsStructure
        {
            public static DBModelOwnerCommissionsStructure GetBasicDataOwnerCommissionStructure(string ownerEmail)
            {
                var row = new DBModelOwnerCommissionsStructure();

                // SQL запрос для выборки данных
                string query = "SELECT PayType, TenantNumberOfMonths, TenantPercentage, OwnerNumberOfMonths, OwnerPercentage, TakeOff" +
                       " FROM OwnerCommissionsStructure" +
                       " WHERE OwnerId IN" +
                       " (SELECT Id FROM Owners WHERE OwnerEmail = @ownerEmail)";
                try
                {
                    using SqlConnection connection = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB);
                    using SqlCommand command = new(query, connection);
                    connection.Open();

                    // Параметризованный запрос с двумя параметрами
                    command.Parameters.AddWithValue("@ownerEmail", DbType.String).Value = ownerEmail;

                    using SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        row.PayType = GetValueOrDefault<string>(reader, 0);
                        row.TenantNumberOfMonths = GetValueOrDefault<decimal>(reader, 1);
                        row.TenantPercentage = GetValueOrDefault<decimal>(reader, 2);
                        row.OwnerNumberOfMonths = GetValueOrDefault<decimal>(reader, 3);
                        row.OwnerPercentage = GetValueOrDefault<decimal>(reader, 4);
                        row.TakeOff = GetValueOrDefault<decimal>(reader, 5);
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


        }
    }
}
