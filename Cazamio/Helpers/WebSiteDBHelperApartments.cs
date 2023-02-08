using CazamioProgect.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.Helpers
{
    public class DBApartments
    {
        public static string GetApartmentIdApartmentForApartments()
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

        public static string GetApartmentIdApartmentByBuildingNameForApartments(string apartmentId)
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

        public static string GetLandlordIdApartmentForApartments()
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

        public static string GetBuildingIdNewApartmentForApartments()
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

        public static string GetMarketplaceIdApartmentForApartments()
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

        public static string GetUnitNameNewApartmentForApartments()
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

        public static string GetBrokerIdApartmentForApartments()
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

        public static string GetOwnerIdApartmentForApartments()
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

        public static string GetIdApartment()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id" +
                    " FROM Apartments" + " WHERE Unit = '1'", db);
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

        public static string GetLandlordIdFromApartmentsT(string buildingName)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT LandlordId FROM Apartments WHERE BuildingId IN " +
                "(SELECT Id FROM Buildings WHERE BuildingName = @BuildingName)", db);
                command.Parameters.AddWithValue("@BuildingName", DbType.String).Value = buildingName;
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

        public static string GetBuildingIdApartmentFromApartments(string buildingName)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT BuildingId FROM Apartments WHERE BuildingId IN " +
                "(SELECT Id FROM Buildings WHERE BuildingName = @BuildingName)", db);
                command.Parameters.AddWithValue("@BuildingName", DbType.String).Value = buildingName;
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

        public static string GetUnitByBuildingNameFromApartmentsT(string buildingName)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Unit FROM Apartments WHERE BuildingId IN " +
                "(SELECT Id FROM Buildings WHERE BuildingName = 'LLC Atlant House')", db);
                command.Parameters.AddWithValue("@BuildingName", DbType.String).Value = buildingName;
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

        public static string GetIdForUnitFromApartments(string buildingName)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM Apartments WHERE BuildingId IN" +
                " (SELECT Id FROM Buildings WHERE BuildingName = 'Creator Martin two') AND Unit = '3';", db);
                command.Parameters.AddWithValue("@BuildingName", DbType.String).Value = buildingName;
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
            return data;        }
    }
}
