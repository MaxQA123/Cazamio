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
    public class DBOwners
    {
        public static string GetIdOwnerByEmail()
        {
            string idBuilding = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM Owners" +
                    " WHERE Id = (SELECT MAX(Id) FROM Owners);", db);
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

        public static string GetLandlordIdByOwnerEmail(string landlordId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT LandlordId FROM Owners" +
                " WHERE OwnerEmail = 'g6gd433j@xitroo.com'", db);
                command.Parameters.AddWithValue("@OwnerEmail", DbType.String).Value = landlordId;
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

        public static string GetMarketplaceIdByOwnerEmail(string marketplaceId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT MarketplaceId FROM Owners" +
                " WHERE OwnerEmail = 'g6gd433j@xitroo.com'", db);
                command.Parameters.AddWithValue("@OwnerEmail", DbType.String).Value = marketplaceId;
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

        public static string GetOwnerIdByNameOwnerMgmt(string ownerId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT OwnerId FROM OwnerManagements" +
                " WHERE Email = 'gf645gd43h@xitroo.com'", db);
                command.Parameters.AddWithValue("@Email", DbType.String).Value = ownerId;
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
