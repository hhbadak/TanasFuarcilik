using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;

namespace DataAccessLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;
        public DataModel()
        {
            con = new SqlConnection(ConnectionStrings.ConStr);
            cmd = con.CreateCommand();
        }
        #region User
        public Personnel PersonnelLogin(string username, string password)
        {
            try
            {
                cmd.CommandText = "SELECT COUNT(*) FROM Personnel WHERE Surname = @uname AND Password = @password";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@uname", username);
                cmd.Parameters.AddWithValue("@password", password);
                con.Open();
                int number = Convert.ToInt32(cmd.ExecuteScalar());

                if (number > 0)
                {
                    cmd.CommandText = "SELECT * FROM Personnel  WHERE Surname = @uname AND Password = @password";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@uname", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Personnel p = new Personnel();
                    while (reader.Read())
                    {
                        p.ID = reader.GetInt32(0);
                        p.Name = reader.GetString(1);
                        p.Surname = reader.GetString(2);
                        p.Password = reader.GetString(3);
                        p.PhoneNumber = reader.GetString(4);
                        p.EMail = reader.GetString(5);
                        p.Address = reader.GetString(6);
                        p.Image = reader.GetString(7);
                        p.StatuID = reader.GetInt32(8);
                        p.Statu = reader.GetBoolean(9);
                    }
                    return p;
                }
                else
                {
                    return null;
                }

            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }

        public List<Personnel> PersonnelList()
        {
            try
            {
                List<Personnel> personnels = new List<Personnel>();
                cmd.CommandText = "SELECT Id, Name, Surname, PhoneNumber, EMail, Address, Img, Status FROM Personnel";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Personnel p = new Personnel();
                    p.ID = reader.GetInt32(0);
                    p.Name = reader.GetString(1);
                    p.Surname = reader.GetString(2);
                    p.PhoneNumber = reader.GetString(3);
                    p.EMail = reader.GetString(4);
                    p.Address = reader.GetString(5);
                    p.Image = reader.GetString(6);
                    p.Statu = reader.GetBoolean(7);
                    p.StatuStr = p.Statu ? "<label class='badge bg-success'>Aktif</label>" : "<label class='badge bg-warning'>Pasif</label>";
                    personnels.Add(p);
                }
                return personnels;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
    }
}
