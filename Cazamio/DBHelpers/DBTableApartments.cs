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
    public class DBTableApartments
    {
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
