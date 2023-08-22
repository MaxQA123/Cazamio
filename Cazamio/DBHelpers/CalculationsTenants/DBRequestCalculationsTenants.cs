using CazamioProgect.Helpers;
using CazamioProject.DBHelpers.Calculations;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.DBHelpers
{
    public class DBRequestCalculationsTenants
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

        public class CalculationsTenant
        {
            public static DBModelCalculationsTenants GetPaymentForApartmentWithoutOwnerTenantPayCommissionsAndHoldingDeposit(string buildingAddress, string unitNumber, string marketplaceId)
            {
                var row = new DBModelCalculationsTenants();

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

            public static DBModelCalculationsTenants GetPaymentForApartmentWithoutOwnerTenantPayCommissionsWithHoldingDeposit(string buildingAddress, string unitNumber, string marketplaceId)
            {
                var row = new DBModelCalculationsTenants();

                // SQL запрос для выборки данных
                string query = "SELECT Prices.LeasePrice, Prices.DepositPrice, Prices.PaidMonths, PaymentOptions.Amount, ((LeasePrice*PaidMonths)+DepositPrice-PaymentOptions.Amount) AS PaymentOfApartment" +
                               " FROM Prices LEFT JOIN PaymentOptions" +
                               " ON Prices.ApartmentId = PaymentOptions.ApartmentId" +
                               " WHERE Prices.ApartmentId IN(SELECT AP.Id FROM Apartments AP" +
                               " LEFT JOIN Buildings B" +
                               " ON B.Id = BuildingId" +
                               " LEFT JOIN Addresses A" +
                               " ON A.Id = AddressId" +
                               " WHERE Ap.Unit = @unitNumber AND A.Street = @buildingAddress AND B.MarketplaceId = @marketplaceId)";
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
                        row.Amount = GetValueOrDefault<decimal>(reader, 3);
                        row.PaymentOfApartment = GetValueOrDefault<decimal>(reader, 4);
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

            public static DBModelCalculationCombinedPays GetPaymentForApartmentWithTenantPayTakeOffWithHoldingDepositWithoutCommission(string buildingAddress, string unitNumber, string marketplaceId)
            {
                var row = new DBModelCalculationCombinedPays();

                // SQL запрос для выборки данных
                string query = "SELECT Prices.LeasePrice, Prices.DepositPrice, Prices.PaidMonths, PaymentOptions.Amount," +
                       " AP.PayType, AP.TenantNumberOfMonths, AP.TakeOff," +
                       " ((LeasePrice * PaidMonths) + DepositPrice + ((AP.TenantNumberOfMonths * Prices.LeasePrice) - PaymentOptions.Amount)) AS FullPaymentOfApartment," +
                       " (AP.TenantNumberOfMonths * Prices.LeasePrice) AS BrokerFee" +
                       " FROM Prices" +
                       " LEFT JOIN PaymentOptions ON Prices.ApartmentId = PaymentOptions.ApartmentId" +
                       " JOIN Apartments AP ON Prices.ApartmentId = AP.Id" +
                       " JOIN Buildings B ON AP.BuildingId = B.Id" +
                       " JOIN Addresses A ON B.AddressId = A.Id" +
                       " WHERE AP.Unit = @unitNumber AND A.Street = @buildingAddress AND B.MarketplaceId = @marketplaceId";
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
                        row.Amount = GetValueOrDefault<decimal>(reader, 3);
                        row.PayType = GetValueOrDefault<string>(reader, 4);
                        row.TenantNumberOfMonths = GetValueOrDefault<decimal>(reader, 5);
                        row.TakeOff = GetValueOrDefault<decimal>(reader, 6);
                        row.FullPaymentOfApartment = GetValueOrDefault<decimal>(reader, 7);
                        row.BrokerFee = GetValueOrDefault<decimal>(reader, 8);
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

            public static DBModelCalculationCombinedComissions GetPaymentCreditScreeningFeeForBuildingWithCommission(string buildingAddress, string marketplaceId)
            {
                var row = new DBModelCalculationCombinedComissions();

                // SQL запрос для выборки данных
                string query = "SELECT PaymentOptions.Amount AS CreditScreeningFeeBuilding, CF.Screening AS CommissionScreeningFeeBuilding," +
                       " (PaymentOptions.Amount * (100 + CF.Screening) / 100) AS AScreeningFeeOf" +
                       " FROM PaymentOptions" +
                       " CROSS JOIN CommissionFees CF" +
                       " LEFT JOIN Buildings B ON PaymentOptions.BuildingId = B.Id" +
                       " JOIN Addresses A ON B.AddressId = A.Id" +
                       " WHERE A.Street = @buildingAddress AND CF.MarketplaceId = @marketplaceId AND B.MarketplaceId = @marketplaceId";
                try
                {
                    using SqlConnection connection = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB);
                    using SqlCommand command = new(query, connection);
                    connection.Open();

                    // Параметризованный запрос с двумя параметрами
                    command.Parameters.AddWithValue("@buildingAddress", DbType.String).Value = buildingAddress;
                    command.Parameters.AddWithValue("@marketplaceId", DbType.String).Value = marketplaceId;

                    using SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        row.CreditScreeningFeeBuilding = GetValueOrDefault<decimal>(reader, 0);
                        row.CommissionScreeningFeeBuilding = GetValueOrDefault<decimal>(reader, 1);
                        row.Total = GetValueOrDefault<decimal>(reader, 2);
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

            public static DBModelCalculationCombinedComissions GetPaymentHoldingDepositForApartmentWithCommission(string buildingAddress, string unitNumber, string marketplaceId)
            {
                var row = new DBModelCalculationCombinedComissions();

                // SQL запрос для выборки данных
                string query = "SELECT PaymentOptions.Amount AS HoldingDepositWithoutCommission," +
                       " CF.HoldingDeposit AS CommissionForHoldingDeposit," +
                       " (PaymentOptions.Amount * (100 + CF.HoldingDeposit) / 100) AS HoldingDepositWithCommission" +
                       " FROM PaymentOptions" +
                       " CROSS JOIN CommissionFees CF" +
                       " WHERE PaymentOptions.ApartmentId IN" +
                       " (SELECT AP.Id FROM Apartments AP" +
                       " LEFT JOIN Buildings B ON AP.BuildingId = B.Id" +
                       " LEFT JOIN Addresses A ON B.AddressId = A.Id" +
                       " WHERE AP.Unit = @unitNumber AND A.Street = '101 Franklin Avenue' AND B.MarketplaceId = '15')" +
                       " AND CF.MarketplaceId = '15'";
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
                        row.HoldingDepositWithoutCommission = GetValueOrDefault<decimal>(reader, 0);
                        row.CommissionForHoldingDeposit = GetValueOrDefault<decimal>(reader, 1);
                        row.HoldingDepositWithCommission = GetValueOrDefault<decimal>(reader, 2);
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

            public static DBModelCalculationCombinedComissions GetSignLeaseWithCommission(string buildingAddress, string unitNumber, string marketplaceId)
            {
                var row = new DBModelCalculationCombinedComissions();

                // SQL запрос для выборки данных
                string query = "SELECT ((LeasePrice * PaidMonths) + DepositPrice + ((AP.TenantNumberOfMonths * Prices.LeasePrice) - PaymentOptions.Amount))*(100 + CF.SigningLease)/100 AS Total" +
                       " FROM Prices" +
                       " CROSS JOIN CommissionFees CF" +
                       " LEFT JOIN PaymentOptions ON Prices.ApartmentId = PaymentOptions.ApartmentId" +
                       " JOIN Apartments AP ON Prices.ApartmentId = AP.Id" +
                       " JOIN Buildings B ON AP.BuildingId = B.Id" +
                       " JOIN Addresses A ON B.AddressId = A.Id" +
                       " WHERE AP.Unit = @unitNumber AND A.Street = @buildingAddress AND B.MarketplaceId = @marketplaceId AND CF.MarketplaceId = @marketplaceId";
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
                        row.Total = GetValueOrDefault<decimal>(reader, 0);
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
