using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProgect.Helpers
{
    #region Buildings
    public class DBBuildings
    {
        public static string GetIdBuildingByName()
        {
            string idBuilding = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id" +
                    " FROM Buildings" + " WHERE BuildingName = 'Royal House'", db);
                db.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        idBuilding = reader.GetValue(0).ToString();
                    }
                }
            }

            return idBuilding;
        }

        public static string GetAddressIdBuildingByName()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT AddressId" +
                    " FROM Buildings" + " WHERE BuildingName = 'Royal House'", db);
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

        public static string GetLandlordIdForBuilding()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT LandlordId" +
                    " FROM Buildings" + " WHERE BuildingName = 'Royal House'", db);
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

    #endregion

    #region Apartments

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

    #endregion

    #region Admins

    public class DBAdmins
    {
        public static string GetIdForAdminFromAspNetUsersT()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id" +
                    " FROM AspNetUsers" + " WHERE UserName = 'testlivelandlord@gmail.com'", db);
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

        public static string GetIdForLandlordFromLandlordsT()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id" +
                    " FROM Landlords" + " WHERE Userid = '78cd1917-e267-428b-bb89-8cbc05c00a83'", db);
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

        public static string GetIdAdminFromLandlordsT(string idAdmin)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM Landlords WHERE UserId IN " +
                "(SELECT Id FROM AspNetUsers WHERE Email = 'su1per2ad3min@gmail.com')", db);
                command.Parameters.AddWithValue("@BuildingName", DbType.String).Value = idAdmin;
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

        public static string GetMarketplaceIdFromLandlordsT(string idMarketplace)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT MarketplaceId FROM Landlords WHERE UserId IN " +
                "(SELECT Id FROM AspNetUsers WHERE Email = 'su1per2ad3min@gmail.com')", db);
                command.Parameters.AddWithValue("@BuildingName", DbType.String).Value = idMarketplace;
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

        public static string GetMarketplaceIdForNewAdmin()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT MarketplaceId FROM Landlords" +
                    " WHERE Id = (SELECT MAX(Id) FROM Landlords);", db);
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

    #endregion
}
