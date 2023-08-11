using CazamioProgect.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.DBHelpers.TablePrices
{
    //Вариант где мы учитываем возможность отображения значения NULL в ячейке.
    public class DBRequestPrices
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

        public class Prices
        {
            // Если в селекте больше одного значения
            public static DBModelPrices GetPaymentForApartmentWithoutCommissionsHoldingDeposit(string buildingAddress, string unitNumber)
            {
                var row = new DBModelPrices();

                // SQL запрос для выборки данных
                string query = "SELECT LeasePrice, DepositPrice, PaidMonths, ((LeasePrice*PaidMonths)+DepositPrice) AS PaymentOfApartment" +
                   " FROM [dbo].[Prices]" +
                   " WHERE ApartmentId" +
                   " IN(SELECT Id FROM [dbo].[Apartments] WHERE Unit = @unitNumber AND BuildingId" +
                   " IN(SELECT Id FROM [dbo].[Buildings] Where AddressId" +
                   " IN(SELECT Id FROM [dbo].[Addresses] WHERE Street = @buildingAddress)))";
                try
                {
                    using SqlConnection connection = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB);
                    using SqlCommand command = new(query, connection);
                    connection.Open();

                    // Параметризованный запрос с двумя параметрами
                    command.Parameters.AddWithValue("@buildingAddress", DbType.String).Value = buildingAddress;
                    command.Parameters.AddWithValue("@unitNumber", DbType.String).Value = unitNumber;

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

        // Если в селекте одно значение
        public static DBModelPrices GetLeasePrice(string buildingAddress, string unitNumber)
        {
            var row = new DBModelPrices();

            // SQL запрос для выборки данных
            string query = "SELECT LeasePrice" +
               " FROM [dbo].[Prices]" +
               " WHERE ApartmentId" +
               " IN(SELECT Id FROM [dbo].[Apartments] WHERE Unit = @unitNumber AND BuildingId" +
               " IN(SELECT Id FROM [dbo].[Buildings] Where AddressId" +
               " IN(SELECT Id FROM [dbo].[Addresses] WHERE Street = @buildingAddress)))";
            try
            {
                using SqlConnection connection = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB);
                using SqlCommand command = new(query, connection);
                connection.Open();

                // Параметризованный запрос с двумя параметрами
                command.Parameters.AddWithValue("@buildingAddress", DbType.String).Value = buildingAddress;
                command.Parameters.AddWithValue("@unitNumber", DbType.String).Value = unitNumber;

                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    row.LeasePrice = GetValueOrDefault<decimal>(reader, 0);
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
