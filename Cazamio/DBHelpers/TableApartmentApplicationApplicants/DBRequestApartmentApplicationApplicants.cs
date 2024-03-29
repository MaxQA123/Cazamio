﻿using CazamioProgect.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioProject.DBHelpers
{
    public class DBRequestApartmentApplicationApplicants
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
        public class ApartmentApplicationApplicants
        {
            public static string DeleteRecordByEmailMarketplaceIdForTenantOcc(long? apartmentApplicationId, string emailTenantOccupant, int marketplaceId)
            {
                string data = null;
                using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
                {
                    SqlCommand command = new("DELETE FROM ApartmentApplicationApplicants WHERE ApartmentApplicationId = @ApartmentApplicationId" +
                               " AND UserId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @EmailTenantOccupant AND MarketplaceId = @MarketplaceId)", db);
                    command.Parameters.AddWithValue("@ApartmentApplicationId", DbType.String).Value = apartmentApplicationId;
                    command.Parameters.AddWithValue("@EmailTenantOccupant", DbType.String).Value = emailTenantOccupant;
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

            public static string DeleteRecordByEmailMarketplaceIdForTenantGuar(long? apartmentApplicationId, string emailTenantGuarantor, int marketplaceId)
            {
                string data = null;
                using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
                {
                    SqlCommand command = new("DELETE FROM ApartmentApplicationApplicants WHERE ApartmentApplicationId = @ApartmentApplicationId" +
                               " AND UserId" +
                               " IN" +
                               " (SELECT Id FROM AspNetUsers WHERE Email = @EmailTenantGuarantor AND MarketplaceId = @MarketplaceId)", db);
                    command.Parameters.AddWithValue("@ApartmentApplicationId", DbType.String).Value = apartmentApplicationId;
                    command.Parameters.AddWithValue("@EmailTenantGuarantor", DbType.String).Value = emailTenantGuarantor;
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
        }
    }
    public class DBRequestApartmentApplicationApplicantsOLD
    {
        public static string GetIdByGuarantorIdApartmentApplicationId(string apartmentApplicationId, string guarantorId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM ApartmentApplicationApplicants" +
                    " WHERE ApartmentApplicationId = @ApartmentApplicationId AND GuarantorId = @GuarantorId", db);
                command.Parameters.AddWithValue("@ApartmentApplicationId", DbType.String).Value = apartmentApplicationId;
                command.Parameters.AddWithValue("@GuarantorId", DbType.String).Value = guarantorId;
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

        public static string GetIdByOccupantIdApartmentApplicationId(string apartmentApplicationId, string occupantId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM ApartmentApplicationApplicants" +
                    " WHERE ApartmentApplicationId = @ApartmentApplicationId AND OccupantId = @OccupantId", db);
                command.Parameters.AddWithValue("@ApartmentApplicationId", DbType.String).Value = apartmentApplicationId;
                command.Parameters.AddWithValue("@OccupantId", DbType.String).Value = occupantId;
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

        public static string GetLastIdByUserIdOccupant(string userId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT TOP (1) Id FROM ApartmentApplicationApplicants" +
                    " WHERE UserId = @UserId ORDER BY Id DESC", db);
                command.Parameters.AddWithValue("@UserId", DbType.String).Value = userId;
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

        public static string GetLastIdByOccupantId(string occupantId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT TOP (1) Id FROM ApartmentApplicationApplicants" +
                    " WHERE OccupantId = @OccupantId ORDER BY Id DESC", db);
                command.Parameters.AddWithValue("@OccupantId", DbType.String).Value = occupantId;
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

        public static string GetLastIdByGuarantorId(string guarantorId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT TOP (1) Id" +
                    " FROM ApartmentApplicationApplicants" +
                    " WHERE GuarantorId = @GuarantorId ORDER BY Id DESC", db);
                command.Parameters.AddWithValue("@GuarantorId", DbType.String).Value = guarantorId;
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