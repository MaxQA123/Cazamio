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
        public static string GetIdApartment()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id" +
                    " FROM Apartments" + " WHERE Unit = '20'", db);
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
                "(SELECT Id FROM Buildings WHERE BuildingName = 'Royal House')", db);
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

        public static string GetBuildingIdFromApartmentsT(string buildingName)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT BuildingId FROM Apartments WHERE BuildingId IN " +
                "(SELECT Id FROM Buildings WHERE BuildingName = 'Royal House')", db);
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

        public static string GetUnitFromApartmentsT(string buildingName)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Unit FROM Apartments WHERE BuildingId IN " +
                "(SELECT Id FROM Buildings WHERE BuildingName = 'Royal House')", db);
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
    }
}
