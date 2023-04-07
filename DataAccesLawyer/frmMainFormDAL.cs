using HandlingGrid.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccesLawyer
{
    public class frmMainFormDAL
    {        
        private SqlConnection sqlConn = new SqlConnection("Persist Security Info=False;User ID=sa;Password=th16g0;Initial Catalog=Practices;Data Source=DESKTOP-7B0E6KM");
        public List<Person> GetPeople(string searchText = null){

            List<Person> listperson = new List<Person>();
            string query = "SELECT Id,FirstName,LastName,SocialId,Born,Religion,Nationality,City FROM People";
            
            try{
                sqlConn.Open();
                SqlCommand command = sqlConn.CreateCommand();

                if (!string.IsNullOrEmpty(searchText)){

                    command.Parameters.Add(new SqlParameter("@searchText", $"%{searchText}%"));

                    query += @" WHERE FirstName LIKE @searchText OR 
                                LastName LIKE @searchText OR SocialId LIKE @searchText OR Born LIKE @searchText OR
                                 Religion LIKE @searchText OR Nationality LIKE @searchText OR
                                 City LIKE @searchText";
                }

                command.CommandText = query; command.Connection = sqlConn;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listperson.Add(new Person{
                        Id = int.Parse(reader["Id"].ToString()),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        SocialId = int.Parse(reader["SocialId"].ToString()),
                        Born = reader["Born"].ToString(),
                        Religion = reader["Religion"].ToString(),
                        Nationality = reader["Nationality"].ToString(),
                        City = reader["City"].ToString()
                    });
                }
            }
            catch(Exception error){
                MessageBox.Show(error.ToString(),"Error 3312");
            }
            finally {
                sqlConn.Close();
            }
            return listperson;
        }
    }
}
