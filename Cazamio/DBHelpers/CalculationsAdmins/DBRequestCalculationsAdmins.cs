using CazamioProgect.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.DBHelpers.CalculationsAdmins
{
    public class DBRequestCalculationsAdmins
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

        public class CalculationsAdmins
        {
            public static DBModelCalculationsAdmins GetPaymentForApartmentWithoutOwnerTenantPayCommissionsAndHoldingDeposit(string buildingAddress, string unitNumber, string marketplaceId)
            {
                var row = new DBModelCalculationsAdmins();

                // SQL запрос для выборки данных
                string query = "SELECT LeasePrice, DepositPrice, PaidMonths, ((LeasePrice*PaidMonths)+DepositPrice) AS PaymentOfApartment" +
                   " FROM Prices" +
                   " WHERE ApartmentId" +
                   " IN(SELECT Id FROM Apartments WHERE Unit = @unitNumber AND MarketplaceId = @marketplaceId AND BuildingId" +
                   " IN(SELECT Id FROM Buildings Where AddressId" +
                   " IN(SELECT Id FROM Addresses WHERE Street = @buildingAddress)))";
                try
                {
                    using SqlConnection connection = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB);
                    using SqlCommand command = new(query, connection);
                    connection.Open();

                    // Параметризованный запрос с двумя параметрами
                    command.Parameters.AddWithValue("@buildingAddress", DbType.String).Value = buildingAddress;
                    command.Parameters.AddWithValue("@unitNumber", DbType.String).Value = unitNumber;
                    command.Parameters.AddWithValue("@marketplaceId", DbType.String).Value = marketplaceId;

                    using SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        row.LeasePrice = GetValueOrDefault<decimal>(reader, 0);
                        row.DepositPrice = GetValueOrDefault<decimal>(reader, 1);
                        row.PaidMonths = GetValueOrDefault<int>(reader, 2);
                        row.PaymentOfApartment = GetValueOrDefault<decimal>(reader, 3);
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
