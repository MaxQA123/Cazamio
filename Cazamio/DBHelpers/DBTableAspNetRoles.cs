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
    public class DBTableAspNetRoles
    {
        public static string GetRoleNameByEmail(string roleName)
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
    }
}
