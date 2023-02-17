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
    public class DBTableTransactions
    {
        public static string GetLastId()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM Transactions" +
                    " WHERE Id = (SELECT MAX(Id) FROM Transactions)", db);
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

        public static string GetLastIdByTransactionType(string id)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT TOP (1) Id FROM Transactions" +
                    " WHERE TransactionType = @TransactionType ORDER BY Id DESC", db);
                command.Parameters.AddWithValue("@TransactionType", DbType.String).Value = id;
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

        public static string GetLastIdByTenantId(string tenantId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM Transactions" +
                    " WHERE Id = (SELECT MAX(Id) FROM Transactions)" +
                    " AND TenantId = @TenantId", db);
                command.Parameters.AddWithValue("@TenantId", DbType.String).Value = tenantId;
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

        public static string GetLastTenantIdByIdTransactionType(string transactionType)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT TenantId FROM Transactions" +
                    " WHERE Id = (SELECT MAX(Id) FROM Transactions)" +
                    " AND TransactionType = @TransactionType", db);
                command.Parameters.AddWithValue("@TransactionType", DbType.String).Value = transactionType;
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

        public static string GetLastTransactionId()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT TransactionId FROM Transactions" +
                    " WHERE Id = (SELECT MAX(Id) FROM Transactions)", db);
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

        public static string GetLastTransactionIdByTenantIdApartmentId(string tenantId, string apartmentId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT TransactionId FROM Transactions" +
                    " WHERE Id = (SELECT MAX(Id) FROM Transactions) AND TenantId = @TenantId AND ApartmentId = @ApartmentId", db);
                command.Parameters.AddWithValue("@TenantId", DbType.String).Value = tenantId;
                command.Parameters.AddWithValue("@ApartmentId", DbType.String).Value = apartmentId;
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

        public static string GetLastTransactionIdByTenantIdApartmentApplicationId(string tenantId, string apartmentApplicationId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT TransactionId FROM Transactions" +
                    " WHERE Id = (SELECT MAX(Id) FROM Transactions) AND TenantId = @TenantId AND ApartmentApplicationId = @ApartmentApplicationId", db);
                command.Parameters.AddWithValue("@TenantId", DbType.String).Value = tenantId;
                command.Parameters.AddWithValue("@ApartmentApplicationId", DbType.String).Value = apartmentApplicationId;
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

        public static string GetLastApartmentId()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT ApartmentId FROM Transactions" +
                    " WHERE Id = (SELECT MAX(Id) FROM Transactions)", db);
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

        public static string GetLastApartmentApplicationId()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT ApartmentApplicationId FROM Transactions" +
                    " WHERE Id = (SELECT MAX(Id) FROM Transactions)", db);
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

        public static string GetLastApartmentIdByTenantIdApartmentId(string tenantId, string apartmentId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT ApartmentId FROM Transactions" +
                    " WHERE Id = (SELECT MAX(Id) FROM Transactions) AND TenantId = @TenantId AND ApartmentId = @ApartmentId", db);
                command.Parameters.AddWithValue("@TenantId", DbType.String).Value = tenantId;
                command.Parameters.AddWithValue("@ApartmentId", DbType.String).Value = apartmentId;
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

        public static string GetLastApartmentApplicationIdByTenantIdTransactionType(string tenantId, string transactionType)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT ApartmentApplicationId FROM Transactions" +
                    " WHERE Id = (SELECT MAX(Id) FROM Transactions)" +
                    " AND TenantId = @TenantId AND TransactionType = @TransactionType", db);
                command.Parameters.AddWithValue("@TenantId", DbType.String).Value = tenantId;
                command.Parameters.AddWithValue("@TransactionType", DbType.String).Value = transactionType;
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

        public static string GetLastTransactionStatusdByIdApartmentIdTransactionType(string apartmentId, string transactionType)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT TransactionStatus FROM Transactions" +
                    " WHERE Id = (SELECT MAX(Id) FROM Transactions)" +
                    " AND ApartmentId = @ApartmentId AND TransactionType = @TransactionType", db);
                command.Parameters.AddWithValue("@ApartmentId", DbType.String).Value = apartmentId;
                command.Parameters.AddWithValue("@TransactionType", DbType.String).Value = transactionType;
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

        public static string GetLastTransactionStatusdByIdApartmentApplicationIdTransactionType(string apartmentApplicationId, string transactionType)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT TransactionStatus FROM Transactions" +
                    " WHERE Id = (SELECT MAX(Id) FROM Transactions)" +
                    " AND ApartmentApplicationId = @ApartmentApplicationId AND TransactionType = @TransactionType", db);
                command.Parameters.AddWithValue("@ApartmentApplicationId", DbType.String).Value = apartmentApplicationId;
                command.Parameters.AddWithValue("@TransactionType", DbType.String).Value = transactionType;
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
