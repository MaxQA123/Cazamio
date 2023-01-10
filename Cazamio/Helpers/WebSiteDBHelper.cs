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

    #region Applications

    public class DBApplications
    {
        public static string GetTenantIdApplicant(string idApplicant)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM Tenants WHERE UserId IN" +
                " (SELECT Id FROM AspNetUsers WHERE UserName = 'tenantswife@gmail.com'); ", db);
                command.Parameters.AddWithValue("@UserName", DbType.String).Value = idApplicant;
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

        public static string GetTenantIOccupant(string idOccupant)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM Tenants WHERE UserId IN" +
                " (SELECT Id FROM AspNetUsers WHERE UserName = 'apipostman65455@gmail.com'); ", db);
                command.Parameters.AddWithValue("@UserName", DbType.String).Value = idOccupant;
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

        public static string GetTenantIGuarantor(string idGuarantor)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM Tenants WHERE UserId IN" +
                " (SELECT Id FROM AspNetUsers WHERE UserName = 'guarantor5935@gmail.com'); ", db);
                command.Parameters.AddWithValue("@UserName", DbType.String).Value = idGuarantor;
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

        public static string GetIdNewApplication()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT ApartmentApplicationId" +
                    " FROM ApartmentApplicationProgress" +
                    " WHERE ApartmentApplicationId = (SELECT MAX(ApartmentApplicationId)" +
                    " FROM ApartmentApplicationProgress);", db);
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

        public static string GetApartmentApplicationIdApplicant()
        {
            string tenantIdApplicant = "38";

            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT ApartmentApplicationId" +
                    " FROM ApartmentApplicationProgress" +
                    " WHERE TenantId = '38'" +
                    " AND ApartmentApplicationId = (SELECT MAX(ApartmentApplicationId)" +
                    " FROM ApartmentApplicationProgress);", db);
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

        public static string GetApartmentApplicationIdOccupant()
        {
            string tenantIdOccupant = "47";

            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT ApartmentApplicationId" +
                    " FROM ApartmentApplicationProgress" +
                    " WHERE TenantId = '47'" +
                    " AND ApartmentApplicationId = (SELECT MAX(ApartmentApplicationId)" +
                    " FROM ApartmentApplicationProgress);", db);
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

        public static string GetApartmentApplicationIdGuarantor()
        {
            string tenantIdGuarantor = "48";

            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT ApartmentApplicationId" +
                    " FROM ApartmentApplicationProgress" +
                    " WHERE TenantId = '48'" +
                    " AND ApartmentApplicationId = (SELECT MAX(ApartmentApplicationId)" +
                    " FROM ApartmentApplicationProgress);", db);
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

        public static string GetApartmentId()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT ApartmentId" +
                    " FROM ApartmentApplications" +
                    " WHERE Id = (SELECT MAX(Id)" +
                    " FROM ApartmentApplications);", db);
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

        public static string GetNewApartmentApplicationId()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT MAX(ApartmentApplicationId) ApartmentApplicationId" +
                    " FROM ApartmentApplicationApplicants;", db);
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

        public static string GetApartmentApplicationIdOccGua()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT TOP (2) ApartmentApplicationId" +
                    " FROM ApartmentApplicationApplicants ORDER BY Id DESC;", db);
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

        public static string GetApartmentApplicationIdGuarantorS()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT MAX(ApartmentApplicationId) ApartmentApplicationId" +
                    " FROM ApartmentApplicationApplicants;", db);
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

        public static string GetApartmentApplicationIdByUserIdOcc()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT MAX(ApartmentApplicationId) ApartmentApplicationId" +
                    " FROM ApartmentApplicationApplicants" +
                    " WHERE UserId = '1397a512-6600-40d8-95cd-e76f1e3af5e2';", db);
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

        public static string GetApartmentApplicationIdByEmailOcc(string apartmentApplicationId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT ApartmentApplicationId" +
                    " FROM Occupants WHERE Contacts ='apipostman65455@gmail.com'" +
                    " AND ApartmentApplicationId = (SELECT MAX(ApartmentApplicationId) FROM Occupants);", db);
                command.Parameters.AddWithValue("@Contacts", DbType.String).Value = apartmentApplicationId;
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

        public static string GetApartmentApplicationIdByEmailGua(string apartmentApplicationId)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT ApartmentApplicationId" +
                    " FROM Guarantors WHERE Contacts ='guarantor5935@gmail.com'" +
                    " AND ApartmentApplicationId = (SELECT MAX(ApartmentApplicationId) FROM Guarantors);", db);
                command.Parameters.AddWithValue("@Contacts", DbType.String).Value = apartmentApplicationId;
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

        public static string GetApartmentApplicationIdByUserIdGua()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT MAX(ApartmentApplicationId) ApartmentApplicationId" +
                    " FROM ApartmentApplicationApplicants" +
                    " WHERE UserId = '149fcd30-8ddb-4c3d-9ffb-4c466861f25a';", db);
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
                command.Parameters.AddWithValue("@Email", DbType.String).Value = idAdmin;
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

        public static string GetUserIdNewAdminFromLandlords()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT UserId FROM" +
                    " Landlords WHERE Id = (SELECT MAX(Id) FROM Landlords);", db);
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

        public static string GetRoleIdNewAdminFromAspNetUserRoles()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT RoleId FROM AspNetUserRoles" +
                    " WHERE UserId IN" +
                    " (SELECT UserId FROM Landlords WHERE Id = (SELECT MAX(Id) FROM Landlords));", db);
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
                "(SELECT Id FROM AspNetUsers WHERE Email = 'twysb@putsbox.com')", db);
                command.Parameters.AddWithValue("@Email", DbType.String).Value = idMarketplace;
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

    #region Brokers

    public class DBBrokers
    {
        public static string GetUserIdNewBrokerFromBrokers()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT UserId FROM" +
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

        public static string GetRoleIdNewBrokerFromAspNetUserRoles()
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

        public static string GetMarketplaceIdFromBrokers()
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

        public static string GetIdBrokerFromBrokersT(string idBroker)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id FROM Brokers WHERE UserId IN " +
                "(SELECT Id FROM AspNetUsers WHERE Email = 'joingilbert901broker@gmail.com')", db);
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

        public static string GetLandlordIdByBrokerId(string idBroker)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT LandlordId FROM LandlordBrokers" +
                    " WHERE BrokerId IN" +
                    " (SELECT Id FROM Brokers WHERE UserId IN" +
                    " (SELECT Id FROM AspNetUsers WHERE Email = 'joingilbert901broker@gmail.com'));", db);
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

        public static string GetLandlordIdForNewBroker()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT LandlordId FROM LandlordBrokers" +
                    " WHERE BrokerId = (SELECT MAX(BrokerId) FROM LandlordBrokers);", db);
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

    #region Owners

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

    #endregion

    #region Tenants

    public class DBTenants
    {
        public static string GetIdForNewTenantTableTenants()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT MAX(Id) Id FROM Tenants;", db);
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

        public static string GetUserIdForNewTenantTableTenants()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT UserId" +
                    " FROM Tenants WHERE Id = (SELECT MAX(Id) FROM Tenants);", db);
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

        public static string GetIdForNewTenantTableAspNetUsers(string idTenantAspNetUsers)
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT Id" +
                    " FROM AspNetUsers WHERE UserName = 'indigo123fgh@putsbox.com'", db);
                command.Parameters.AddWithValue("@Contacts", DbType.String).Value = idTenantAspNetUsers;
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

        public static string GetRoleIdForNewTenantTableAspNetUserRoles()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT RoleId FROM AspNetUserRoles" +
                    " WHERE UserId IN" +
                    " (SELECT UserId FROM Tenants WHERE Id = (SELECT MAX(Id) FROM Tenants));", db);
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

        public static string GetTenantIdForNewTenantTableTenantBackgroundChecks()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT TOP(1) CheckStatus" +
                    " FROM TenantBackgroundChecks INNER JOIN Tenants" + 
                    " ON TenantId IN" +
                    " (SELECT UserId FROM Tenants WHERE Id = (SELECT MAX(Id) FROM Tenants)" +
                    " AND TenantBackgroundChecks.BackgroundCheckType = 'BackgroundCheck'); ", db);
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

        public static string GetTenantIdForNewTenantTableTenantCreditScreening()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                SqlCommand command = new("SELECT TOP(1) CheckStatus" +
                    " FROM TenantBackgroundChecks INNER JOIN Tenants" +
                    " ON TenantId IN" +
                    " (SELECT UserId FROM Tenants WHERE Id = (SELECT MAX(Id) FROM Tenants)" +
                    " AND TenantBackgroundChecks.BackgroundCheckType = 'CreditScreening'); ", db);
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

