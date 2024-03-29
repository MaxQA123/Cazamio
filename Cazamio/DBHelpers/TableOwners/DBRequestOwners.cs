﻿using CazamioProgect.Helpers;
using CazamioProject.DBHelpers.TableOwners;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.DBHelpers
{
    public class DbRequestOwners
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

        public class DBOwners
        {
            public static string DeleteCreatedUserOwner(string email, int marketplaceId)
            {
                string data = null;
                using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
                {
                    SqlCommand command = new("DELETE" +
                               " FROM Owners" +
                               " WHERE OwnerEmail = @Email AND MarketplaceId = @MarketplaceId", db);
                    command.Parameters.AddWithValue("@Email", DbType.String).Value = email;
                    command.Parameters.AddWithValue("@MarketplaceId", DbType.String).Value = marketplaceId;
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

            public static string GetMarketplaceIdByEmailUserOwner(string email)
            {
                string data = null;
                using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
                {
                    SqlCommand command = new("SELECT MarketplaceId" +
                               " FROM Owners" +
                               " WHERE OwnerEmail = @Email", db);
                    command.Parameters.AddWithValue("@Email", DbType.String).Value = email;
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

    public class DBRequestOwnersOld
    {
        public static string GetCreatedByUserIdOwnerByOwnerEmail(string createdByUserId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT CreatedByUserId FROM Owners" +
                " WHERE OwnerEmail = @OwnerEmail", db);
                command.Parameters.AddWithValue("@OwnerEmail", DbType.String).Value = createdByUserId;
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

        public static string GetLasCreatedByUserIdById()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT CreatedByUserId FROM Owners" +
                " WHERE Id = (SELECT MAX(Id) FROM Owners)", db);
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

        public static string GetIdOwnerByOwnerEmail(string ownerId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM Owners" +
                " WHERE OwnerEmail = @OwnerEmail", db);
                command.Parameters.AddWithValue("@OwnerEmail", DbType.String).Value = ownerId;
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

        public static string GetIdBrokerByOwnerEmail(string ownerId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT BrokerId FROM Owners" +
                " WHERE OwnerEmail = @OwnerEmail", db);
                command.Parameters.AddWithValue("@OwnerEmail", DbType.String).Value = ownerId;
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

        public static string GetLastIdNewOwner()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM Owners" +
                " WHERE Id = (SELECT MAX(Id) FROM Owners)", db);
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

        public static string GetMarketplaceIdOwnerByOwnerEmail(string landlordId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT MarketplaceId" +
                    " FROM Owners WHERE OwnerEmail = @OwnerEmail", db);
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

        public static string GetLastMarketplaceIdOwner()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT MarketplaceId FROM Owners" +
                " WHERE Id = (SELECT MAX(Id) FROM Owners)", db);
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

        public static string GetLastOwnerEmailNewOwnerByIdOwners()
        {
            string idBuilding = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT OwnerEmail FROM Owners" +
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

        public static string GetOwnerNameNewOwnerByIdOwners()
        {
            string idBuilding = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT OwnerName FROM Owners" +
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

        public static string GetLastCompanyNameNewOwnerByIdOwners()
        {
            string idBuilding = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT CompanyName FROM Owners" +
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
    }
}
