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
    public class DBAgents
    {
        public static string GetIdAgentFromAspNetUsers(string idBroker)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM AspNetUsers WHERE Email = @Email", db);
                command.Parameters.AddWithValue("@Email", DbType.String).Value = idBroker;
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

        public static string GetBrokerIdAgentFromBrokers(string idBroker)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM Brokers WHERE UserId IN" +
                           " (SELECT Id FROM AspNetUsers WHERE Email = @Email);", db);
                command.Parameters.AddWithValue("@Email", DbType.String).Value = idBroker;
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

        public static string GetLandlordIdByBrokerIdFromLandlordBrokers(string landlordId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT LandlordId FROM LandlordBrokers WHERE BrokerId IN" +
                           " (SELECT Id FROM Brokers WHERE UserId IN" +
                           " (SELECT Id FROM AspNetUsers WHERE Email = @Email));", db);
                command.Parameters.AddWithValue("@Email", DbType.String).Value = landlordId;
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

        public static string GetBrokerIdNewAgentFromBrokers()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM" +
                    " Brokers WHERE Id = (SELECT MAX(Id) FROM Brokers);", db);
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

        public static string GetRoleIdNewAgentFromAspNetUserRoles()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT RoleId FROM AspNetUserRoles" +
                    " WHERE UserId IN" +
                    " (SELECT UserId FROM Brokers WHERE Id = (SELECT MAX(Id) FROM Brokers));", db);
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

        public static string GetMarketplaceIDNewAgentFromBrokers()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT MarketplaceId FROM Brokers" +
                    " WHERE UserId IN" +
                    " (SELECT UserId FROM Brokers WHERE Id = (SELECT MAX(Id) FROM Brokers));", db);
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

        public static string GetMarketplaceIDAgentFromAspNetUsers(string marketplaceId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT MarketplaceId" +
                    " FROM AspNetUsers WHERE Email = @Email", db);
                command.Parameters.AddWithValue("@Email", DbType.String).Value = marketplaceId;
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

        public static string GetBrokerIdForNewAgent()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT BrokerId FROM LandlordBrokers" +
                    " WHERE Id = (SELECT MAX(Id) FROM LandlordBrokers);", db);
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

        public static string GetRoleNameAgentFromAspNetRoles(string roleName)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Name FROM AspNetRoles WHERE Id IN" +
                           " (SELECT RoleId FROM AspNetUserRoles WHERE UserId IN" +
                           " (SELECT Id FROM AspNetUsers WHERE Email = @Email));", db);
                command.Parameters.AddWithValue("@Email", DbType.String).Value = roleName;
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

        public static string GetFirstNameAgentFromAspNetUsers(string firstName)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT FirstName" +
                    " FROM AspNetUsers WHERE Email = @Email", db);
                command.Parameters.AddWithValue("@Email", DbType.String).Value = firstName;
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

        public static string GetDeleteAgentTableBrokers(string idAgent)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT IsDeleted FROM Brokers WHERE UserId IN" +
                      $" (SELECT Id FROM AspNetUsers WHERE Email = @Email);", db);
                command.Parameters.AddWithValue("@Email", DbType.String).Value = idAgent;
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

        public static string GetDeleteAgentTableLandlordBrokers(string idAgent)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT IsDeleted FROM LandlordBrokers WHERE Id IN" +
                           " (SELECT Id FROM Brokers WHERE UserId IN" +
                           $" (SELECT Id FROM AspNetUsers WHERE Email = @Email));", db);
                command.Parameters.AddWithValue("@Email", DbType.String).Value = idAgent;
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
