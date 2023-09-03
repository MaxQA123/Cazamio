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

            public static DBModelApartmentsCombinedPrices GetPayTypeTenantNumberOfMonhsTakeOffAvailableCommission(string buildingAddress, string unitNumber, string marketplaceId)
            {
                var row = new DBModelApartmentsCombinedPrices();

                // SQL запрос для выборки данных
                string query = "SELECT AP.PayType, AP.TenantNumberOfMonths," +
                       " (AP.TenantNumberOfMonths * PR.LeasePrice) * (AP.TakeOff / 100) AS TakeOff," +
                       " (AP.TenantNumberOfMonths * PR.LeasePrice) *((100 - AP.TakeOff) / 100) AS AvailableForCommission" +
                       " FROM Apartments AP" +
                       " LEFT JOIN Prices PR" +
                       " ON PR.ApartmentId = AP.Id" +
                       " LEFT JOIN Buildings B" +
                       " ON B.Id = BuildingId" +
                       " LEFT JOIN Addresses A" +
                       " ON A.Id = AddressId" +
                       " WHERE AP.Unit = @unitNumber AND A.Street = @buildingAddress AND AP.MarketplaceId = @marketplaceId";
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
                        row.PayType = GetValueOrDefault<string>(reader, 0);
                        row.TenantNumberOfMonths = GetValueOrDefault<decimal>(reader, 1);
                        row.TakeOff = GetValueOrDefault<decimal>(reader, 2);
                        row.AvailableForCommission = GetValueOrDefault<decimal>(reader, 3);
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

            public static DBModelApartmentsCombinedPrices GetPayTypeOwnerNumberOfMonhsTakeOffAvailableCommission(string buildingAddress, string unitNumber, string marketplaceId)
            {
                var row = new DBModelApartmentsCombinedPrices();

                // SQL запрос для выборки данных
                string query = "SELECT AP.PayType, AP.OwnerNumberOfMonths," +
                       " (AP.OwnerNumberOfMonths * PR.LeasePrice) * (AP.TakeOff / 100) AS TakeOff," +
                       " (AP.OwnerNumberOfMonths * PR.LeasePrice) *((100 - AP.TakeOff) / 100) AS AvailableForCommission" +
                       " FROM Apartments AP" +
                       " LEFT JOIN Prices PR" +
                       " ON PR.ApartmentId = AP.Id" +
                       " LEFT JOIN Buildings B" +
                       " ON B.Id = BuildingId" +
                       " LEFT JOIN Addresses A" +
                       " ON A.Id = AddressId" +
                       " WHERE AP.Unit = @unitNumber AND A.Street = @buildingAddress AND AP.MarketplaceId = @marketplaceId";
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
                        row.PayType = GetValueOrDefault<string>(reader, 0);
                        row.OwnerNumberOfMonths = GetValueOrDefault<decimal>(reader, 1);
                        row.TakeOff = GetValueOrDefault<decimal>(reader, 2);
                        row.AvailableForCommission = GetValueOrDefault<decimal>(reader, 3);
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

            public static DBModelApartmentsCombinedPrices GetPayTypeOwnerAndTenantNumberOfMonhsTakeOffAvailableCommission(string buildingAddress, string unitNumber, string marketplaceId)
            {
                var row = new DBModelApartmentsCombinedPrices();

                // SQL запрос для выборки данных
                string query = "SELECT AP.PayType, AP.OwnerNumberOfMonths, AP.TenantNumberOfMonths, AP.OwnerPercentage, AP.TenantPercentage," +
                       " ((AP.OwnerNumberOfMonths * PR.LeasePrice * (AP.OwnerPercentage / 100)) + (AP.TenantNumberOfMonths * PR.LeasePrice * (AP.TenantPercentage / 100))) * (AP.TakeOff / 100) AS TakeOff," +
                       " ((AP.OwnerNumberOfMonths * PR.LeasePrice * (AP.OwnerPercentage / 100)) + (AP.TenantNumberOfMonths * PR.LeasePrice * (AP.TenantPercentage / 100))) *((100 - AP.TakeOff) / 100) AS AvailableForCommission" +
                       " FROM Apartments AP" +
                       " LEFT JOIN Prices PR" +
                       " ON PR.ApartmentId = AP.Id" +
                       " LEFT JOIN Buildings B" +
                       " ON B.Id = BuildingId" +
                       " LEFT JOIN Addresses A" +
                       " ON A.Id = AddressId" +
                       " WHERE AP.Unit = @unitNumber AND A.Street = @buildingAddress AND AP.MarketplaceId = @marketplaceId";
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
                        row.PayType = GetValueOrDefault<string>(reader, 0);
                        row.OwnerNumberOfMonths = GetValueOrDefault<decimal>(reader, 1);
                        row.TenantNumberOfMonths = GetValueOrDefault<decimal>(reader, 2);
                        row.OwnerPercentage = GetValueOrDefault<decimal>(reader, 3);
                        row.TenantPercentage = GetValueOrDefault<decimal>(reader, 4);
                        row.TakeOff = GetValueOrDefault<decimal>(reader, 5);
                        row.AvailableForCommission = GetValueOrDefault<decimal>(reader, 6);
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
