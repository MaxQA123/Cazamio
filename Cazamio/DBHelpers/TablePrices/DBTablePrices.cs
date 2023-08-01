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
    public class DBTablePrices
    {
        public class DBCalculations
        {
            public static T GetValueOrDefault<T>(SqlDataReader reader, int index, T defaultValue = default(T))
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
        }

        public class Prices
        {
            public static List<DBModelPricesCombined> GetPaymentForApartmentWithoutCommissionsHoldingDeposit(string buildingAddress, string unitNumber)
            {
                var list = new List<DBModelPricesCombined>();

                // SQL запит для вибірки даних
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

                    // Параметризований запит з одним параметром
                    command.Parameters.AddWithValue("@buildingAddress", DbType.String).Value = buildingAddress;
                    command.Parameters.AddWithValue("@unitNumber", DbType.String).Value = unitNumber;

                    using SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var row = new DBModelPricesCombined();
                        row.LeasePrice = DBCalculations.GetValueOrDefault<decimal>(reader, 0);
                        row.DepositPrice = DBCalculations.GetValueOrDefault<decimal>(reader, 1);
                        row.PaidMonths = DBCalculations.GetValueOrDefault<int>(reader, 2);
                        row.PaymentOfApartment = DBCalculations.GetValueOrDefault<decimal>(reader, 3);

                        list.Add(row);
                    }

                }
                catch (Exception ex)
                {
                    throw new ArgumentException($"Error: {ex.Message}\r\n{ex.StackTrace}");
                }
                finally
                {

                    // Забезпечуємо вивільнення ресурсів
                    SqlConnection.ClearAllPools();
                }
                return list;
            }
        }

        public static string GetProba()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT LeasePrice, DepositPrice, PaidMonths, ((LeasePrice*PaidMonths)+DepositPrice) AS PaymentOfApartment" +
                   " FROM [Prices]" +
                   " WHERE ApartmentId" +
                   " IN(SELECT Id FROM [dbo].[Apartments] WHERE Unit = '26' AND BuildingId" +
                   " IN(SELECT Id FROM [dbo].[Buildings] Where AddressId" +
                   " IN(SELECT Id FROM [dbo].[Addresses] WHERE Street = '101 Franklin Avenue')))", db);
                //command.Parameters.AddWithValue("@BuildingName", DbType.String).Value = apartmentId;
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

        //public static string GetProba()
        //{
        //    string data = null;
        //    using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
        //    {
        //        SqlCommand command = new("SELECT LeasePrice, DepositPrice, PaidMonths, ((LeasePrice*PaidMonths)+DepositPrice) AS PaymentOfApartment" +
        //           " FROM Prices" +
        //           " WHERE ApartmentId IN(SELECT Id FROM Apartments WHERE Unit = '26' AND BuildingId" +
        //           " IN(SELECT Id FROM Buildings Where AddressId" +
        //           " IN(SELECT Id FROM Addresses WHERE Street = '101 Franklin Avenue')))", db);
        //        //command.Parameters.AddWithValue("@BuildingName", DbType.String).Value = apartmentId;
        //        db.Open();

        //        SqlDataReader reader = command.ExecuteReader();
        //        if (reader.HasRows)
        //        {
        //            while (reader.Read())
        //            {
        //                data = reader.GetValue(0).ToString();
        //            }
        //        }
        //    }
        //    return data;
        //}

        public static string GetApartmentIdByBuildingNameF(string apartmentId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM" +
                    " Apartments WHERE Id = (SELECT MAX(Id) FROM Apartments) AND BuildingId IN" +
                    " (SELECT Id FROM Buildings WHERE BuildingName = @BuildingName);", db);
                command.Parameters.AddWithValue("@BuildingName", DbType.String).Value = apartmentId;
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
