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
                        p.Username = reader.GetString(2);
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


        #region Data
        public List<OurWorkCategory> DataList()
        {
            List<OurWorkCategory> category = new List<OurWorkCategory>();
            try
            {
                cmd.CommandText = "SELECT ID, Name FROM OurWorkData";
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
        public bool WorkCreate(OurWork o)
        {
            try
            {
                cmd.CommandText = "INSERT INTO OurWork(Name, CategoryID, DataID, IMG1, IMG2, IMG3, IMG4, IMG5) VALUES (@name, @catid, @did, @i1, @i2, @i3, @i4, @i5)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", o.Name);
                cmd.Parameters.AddWithValue("@catid", o.DataID);
                cmd.Parameters.AddWithValue("@did", o.CategoryID);
                cmd.Parameters.AddWithValue("@i1", o.Img1 ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@i2", o.Img2 ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@i3", o.Img3 ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@i4", o.Img4 ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@i5", o.Img5 ?? (object)DBNull.Value);

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


        public List<OurWork> WorkList()
        {
            try
            {
                List<OurWork> works = new List<OurWork>();
                cmd.CommandText = "SELECT o.ID, o.Name, c.Name, o.IMG1, d.Name  \r\nFROM OurWork AS o \r\nJOIN OurWorkCategory AS c ON o.CategoryID = c.ID\r\nJOIN OurWorkData AS d ON o.DataID = d.ID";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    OurWork o = new OurWork();
                    o.ID = reader.GetInt32(0);
                    o.Name = reader.GetString(1);
                    o.Category = reader.GetString(2);
                    o.Img1 = reader.GetString(3);
                    o.Data = reader.GetString(4);
                    works.Add(o);
                }
                return works;
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


        public OurWork GetWork(int id)
        {
            try
            {
                cmd.CommandText = "SELECT o.ID, o.Name, c.Name, o.IMG1, o.IMG2, o.IMG3, o.IMG4, o.IMG5, d.Name \r\nFROM OurWork AS o \r\nJOIN OurWorkCategory AS c ON c.ID = o.CategoryID \r\nJOIN OutWorkData As d ON d.ID = o.DataID\r\nWHERE o.ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                OurWork o = new OurWork();
                while (reader.Read())
                {
                    o.ID = reader.GetInt32(0);
                    o.Name = reader.GetString(1);
                    o.Category = reader.GetString(2);
                    o.Data = reader.GetString(3);
                    o.Img1 = reader.GetString(4);
                    o.Img2 = reader.GetString(5);
                    o.Img3 = reader.GetString(6);
                    o.Img4 = reader.GetString(7);
                    o.Img5 = reader.GetString(8);
                    o.Data = reader.GetString(9);
                }
                return o;
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
