using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;
using System.Runtime.Remoting.Messaging;

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
                cmd.CommandText = "SELECT COUNT(*) FROM Personnel WHERE Username = @uname AND Password = @password";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@uname", username);
                cmd.Parameters.AddWithValue("@password", password);
                con.Open();
                int number = Convert.ToInt32(cmd.ExecuteScalar());

                if (number > 0)
                {
                    cmd.CommandText = "SELECT * FROM Personnel  WHERE Username = @uname AND Password = @password";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@uname", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Personnel p = new Personnel();
                    while (reader.Read())
                    {
                        p.ID = reader.GetInt32(0);
                        p.Name = reader.GetString(1);
                        p.Username  = reader.GetString(2);
                        p.Password = reader.GetString(3);
                        p.Mission = reader.GetString(4);
                        p.PhoneNumber = reader.GetString(5);
                        p.EMail = reader.GetString(6);
                        p.Address = reader.GetString(7);
                        p.Image = reader.GetString(8);
                        p.StatuID = reader.GetInt32(9);
                        p.Statu = reader.GetBoolean(10);
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
                cmd.CommandText = "SELECT Id, Name, Username, PhoneNumber, EMail, Address, Img, Status FROM Personnel";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Personnel p = new Personnel();
                    p.ID = reader.GetInt32(0);
                    p.Name = reader.GetString(1);
                    p.Username = reader.GetString(2);
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

        public Personnel GetPersonnel(int id)
        {
            try
            {
                cmd.CommandText = "SELECT ID, Name, Username, Password, Mission, PhoneNumber, EMail, Address, Img FROM Personnel WHERE ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                Personnel p = new Personnel();
                while (reader.Read())
                {
                    p.ID = reader.GetInt32(0);
                    p.Name = reader.GetString(1);
                    p.Username = reader.GetString(2);
                    p.Password = reader.GetString(3);
                    p.Mission = reader.GetString(4);
                    p.PhoneNumber = reader.GetString(5);
                    p.EMail = reader.GetString(6);
                    p.Address = reader.GetString(7);
                    p.Image = reader.GetString(8);
                }
                return p;
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

        public bool PersonnelSetting(Personnel p)
        {
            try
            {
                cmd.CommandText = "UPDATE Personnel SET Name = @name, Username = @urname, Password = @password, Mission = @mission, PhoneNumber = @phone, EMail = @mail, Address = @address, Img = @img WHERE ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", p.ID);
                cmd.Parameters.AddWithValue("@name", p.Name);
                cmd.Parameters.AddWithValue("@urname", p.Username);
                cmd.Parameters.AddWithValue("@password", p.Password);
                cmd.Parameters.AddWithValue("@mission", p.Mission);
                cmd.Parameters.AddWithValue("@phone", p.PhoneNumber);
                cmd.Parameters.AddWithValue("@mail", p.EMail);
                cmd.Parameters.AddWithValue("@address", p.Address);
                cmd.Parameters.AddWithValue("@img", p.Image);

                con.Open();

                cmd.ExecuteNonQuery();
                return true;

            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool PersonnelCreate(Personnel p)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Personnel(Name, Username, Password, Mission, PhoneNumber, EMail, Address, Img, StatuID, Status) VALUES (@name, @urname, @password, @mission, @phone, @mail, @address, @img, @statuID, 1)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", p.Name);
                cmd.Parameters.AddWithValue("@surname", p.Username);
                cmd.Parameters.AddWithValue("@password", p.Password);
                cmd.Parameters.AddWithValue("@mission", p.Mission);
                cmd.Parameters.AddWithValue("@phone", p.PhoneNumber);
                cmd.Parameters.AddWithValue("@mail", p.EMail);
                cmd.Parameters.AddWithValue("@address", p.Address);
                cmd.Parameters.AddWithValue("@img", p.Image);
                cmd.Parameters.AddWithValue("@statuID", p.StatuID);
                cmd.Parameters.AddWithValue("@statu", p.Statu);
                con.Open();
                cmd.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool PersonnelDelete(int id)
        {
            try
            {
                cmd.CommandText = "DELETE Personnel WHERE ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch 
            {
                return false;
            }
            finally { con.Close(); }
        }

        #endregion

        #region Status
        public List<Status> StatuList()
        {
            List<Status> statu = new List<Status>();
            try
            {
                cmd.CommandText = "SELECT ID, Name FROM Status";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Status s = new Status();
                    s.ID = reader.GetInt32(0);
                    s.Name = reader.GetString(1);
                    statu.Add(s);
                }
                return statu;
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }
        #endregion

        #region Category
        public List<OurWorkCategory> CategoryList()
        {
            List<OurWorkCategory> category = new List<OurWorkCategory>();
            try
            {
                cmd.CommandText = "SELECT ID, Name FROM OurWorkCategory";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    OurWorkCategory c = new OurWorkCategory();
                    c.ID = reader.GetInt32(0);
                    c.Name = reader.GetString(1);
                    category.Add(c);
                }
                return category;
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }
        #endregion

        #region OutWork
        public bool WorkCreate(Personnel p)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Personnel(Name, Username, Password, Mission, PhoneNumber, EMail, Address, Img, StatuID, Status) VALUES (@name, @urname, @password, @mission, @phone, @mail, @address, @img, @statuID, 1)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", p.Name);
                cmd.Parameters.AddWithValue("@surname", p.Username);
                cmd.Parameters.AddWithValue("@password", p.Password);
                cmd.Parameters.AddWithValue("@mission", p.Mission);
                cmd.Parameters.AddWithValue("@phone", p.PhoneNumber);
                cmd.Parameters.AddWithValue("@mail", p.EMail);
                cmd.Parameters.AddWithValue("@address", p.Address);
                cmd.Parameters.AddWithValue("@img", p.Image);
                cmd.Parameters.AddWithValue("@statuID", p.StatuID);
                cmd.Parameters.AddWithValue("@statu", p.Statu);
                con.Open();
                cmd.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        #endregion
    }
}
