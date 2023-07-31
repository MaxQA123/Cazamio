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
        }

        public class Apartments
        {
            public static List<DBModelPrices> GetUserExercisesList(string userEmail, string membershipName)
            {
                var list = new List<DBModelPrices>();

                // SQL запит для вибірки даних
                string query = "SELECT *" +
                               "FROM [JsonUserExercises] WHERE UserId in " +
                                     "(SELECT id FROM[dbo].[AspNetUsers] WHERE email = @userEmail) and WorkoutExerciseId in" +
                                        "(SELECT Id FROM WorkoutExercises WHERE WorkoutId in " +
                                            "(SELECT Id FROM Workouts WHERE ProgramId in " +
                                                "(SELECT Id FROM Programs WHERE MembershipId in " +
                                                    "(SELECT Id FROM Memberships WHERE Name = @membershipName)" +
                                                ")" +
                                            ")" +
                                        ")";
                try
                {
                    using SqlConnection connection = new(DB.GET_CONNECTION_STRING);
                    using SqlCommand command = new(query, connection);
                    connection.Open();

                    // Параметризований запит з одним параметром
                    command.Parameters.AddWithValue("@userEmail", DbType.String).Value = userEmail;
                    command.Parameters.AddWithValue("@membershipName", DbType.String).Value = membershipName;

                    using SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var row = new DBModelPrices();
                        row.Id = GetValueOrDefault<object>(reader, 0);
                        row.ApartmentId = GetValueOrDefault<string>(reader, 1);
                        row.LeasePrice = GetValueOrDefault<string>(reader, 2);
                        row.DepositPrice = GetValueOrDefault<string>(reader, 3);
                        row.DateFrom = GetValueOrDefault<DateTime>(reader, 4);
                        row.DateTo = GetValueOrDefault<DateTime>(reader, 5);
                        row.CreationDate = GetValueOrDefault<DateTime>(reader, 6);
                        row.ModifyDate = GetValueOrDefault<DateTime>(reader, 7);
                        row.IsDeleted = GetValueOrDefault<bool>(reader, 8);
                        row.PaidMonths = GetValueOrDefault<string>(reader, 9);


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

        public static string GetProba(string apartmentId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT LeasePrice, DepositPrice, PaidMonths, ((LeasePrice*PaidMonths)+DepositPrice) AS PaymentOfApartment" +
                   " FROM Prices" +
                   " WHERE ApartmentId IN(SELECT Id FROM Apartments WHERE Unit = '26' AND BuildingId" +
                   " IN(SELECT Id FROM Buildings Where AddressId" +
                   " IN(SELECT Id FROM Addresses WHERE Street = '101 Franklin Avenue')))", db);
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
