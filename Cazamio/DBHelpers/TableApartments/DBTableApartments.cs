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
    //Вариант где мы учитываем возможность отображения значения NULL в ячейке.
    public class DBTableApartments
    {
        //public class DBCalculations
        //{
        //    private static T GetValueOrDefault<T>(SqlDataReader reader, int index, T defaultValue = default(T))
        //    {
        //        if (!reader.IsDBNull(index))
        //        {
        //            return (T)reader.GetValue(index);
        //        }
        //        else
        //        {
        //            return defaultValue;
        //        }
        //    }
        //}

        //public class Apartments
        //{
        //    public static List<TableApartments> GetUserExercisesList(string userEmail, string membershipName)
        //    {
        //        var list = new List<TableApartments>();

        //        // SQL запит для вибірки даних
        //        string query = "SELECT *" +
        //                       "FROM [JsonUserExercises] WHERE UserId in " +
        //                             "(SELECT id FROM[dbo].[AspNetUsers] WHERE email = @userEmail) and WorkoutExerciseId in" +
        //                                "(SELECT Id FROM WorkoutExercises WHERE WorkoutId in " +
        //                                    "(SELECT Id FROM Workouts WHERE ProgramId in " +
        //                                        "(SELECT Id FROM Programs WHERE MembershipId in " +
        //                                            "(SELECT Id FROM Memberships WHERE Name = @membershipName)" +
        //                                        ")" +
        //                                    ")" +
        //                                ")";
        //        try
        //        {
        //            using SqlConnection connection = new(DB.GET_CONNECTION_STRING);
        //            using SqlCommand command = new(query, connection);
        //            connection.Open();

        //            // Параметризований запит з одним параметром
        //            command.Parameters.AddWithValue("@userEmail", DbType.String).Value = userEmail;
        //            command.Parameters.AddWithValue("@membershipName", DbType.String).Value = membershipName;

        //            using SqlDataReader reader = command.ExecuteReader();
        //            while (reader.Read())
        //            {
        //                var row = new TableApartments();
        //                row.Id = GetValueOrDefault<object>(reader, 0);
        //                row.SetDescription = GetValueOrDefault<string>(reader, 1);
        //                row.WorkoutExerciseId = GetValueOrDefault<long>(reader, 2);
        //                row.UserId = GetValueOrDefault<string>(reader, 3);
        //                row.IsDone = GetValueOrDefault<bool>(reader, 4);
        //                row.CreationDate = GetValueOrDefault<DateTime>(reader, 5);
        //                row.IsDeleted = GetValueOrDefault<bool>(reader, 6);
        //                row.UpdatedDate = GetValueOrDefault<DateTime>(reader, 7);


        //                list.Add(row);
        //            }

        //        }
        //        catch (Exception ex)
        //        {
        //            throw new ArgumentException($"Error: {ex.Message}\r\n{ex.StackTrace}");
        //        }
        //        finally
        //        {

        //            // Забезпечуємо вивільнення ресурсів
        //            SqlConnection.ClearAllPools();
        //        }
        //        return list;
        //    }
        //}

        //Вариант где мы не учитываем возможность отображения значения NULL в ячейке.
        public static string GetLastApartmentId()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id" +
                    " FROM Apartments WHERE Id = (SELECT MAX(Id) FROM Apartments);", db);
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

        public static string GetApartmentIdByBuildingIdUnit(string buildingId, string unit)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM Apartments" +
                    " WHERE BuildingId = @BuildingId AND Unit = @Unit", db);
                command.Parameters.AddWithValue("@BuildingId", DbType.String).Value = buildingId;
                command.Parameters.AddWithValue("@Unit", DbType.String).Value = unit;
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

        public static string GetLastLandlordIdNewApartment()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT LandlordId FROM Apartments" +
                    " WHERE Id = (SELECT MAX(Id) FROM Apartments);", db);
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

        public static string GetLastBuildingIdNewApartment()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT BuildingId FROM Apartments" +
                    " WHERE Id = (SELECT MAX(Id) FROM Apartments);", db);
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

        public static string GetLastMarketplaceIdNewApartment()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT MarketplaceId FROM Apartments" +
                    " WHERE Id = (SELECT MAX(Id) FROM Apartments);", db);
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

        public static string GetLastUnitNameNewApartmentById()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Unit FROM Apartments" +
                    " WHERE Id = (SELECT MAX(Id) FROM Apartments);", db);
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

        public static string GetLastBrokerIdApartmentById()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT BrokerId FROM Apartments" +
                    " WHERE Id = (SELECT MAX(Id) FROM Apartments);", db);
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

        public static string GetLastOwnerIdApartmentById()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT OwnerId FROM Apartments" +
                    " WHERE Id = (SELECT MAX(Id) FROM Apartments);", db);
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

        public static string GetIdForUnitFromApartments(string buildingName, string unit)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM Apartments WHERE BuildingId IN" +
                " (SELECT Id FROM Buildings WHERE BuildingName = @BuildingName) AND Unit = @Unit", db);
                command.Parameters.AddWithValue("@BuildingName", DbType.String).Value = buildingName;
                command.Parameters.AddWithValue("@Unit", DbType.String).Value = unit;
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
