using Stories.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Stories.RepositaryLayer
{
    public class StudentRepositoryLayer
    {
        public List<StudentModel> GetStudentData()
        {
            List<StudentModel> studentModels = new List<StudentModel>();
            StudentModel studentModel = new StudentModel();
            SqlConnection con = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con = new SqlConnection(connectionString);
                con.Open();
                string query = "select * from Tbl_Student";
                SqlCommand cm = new SqlCommand(query, con);
                SqlDataReader sdr = cm.ExecuteReader();

                /* con = new SqlConnection("data source=.; database=Stories;integrated security=SSPI");
                 con = new SqlConnection();
                 con.Open();
                 string query = "select * from Tbl_Student";
                 SqlCommand cm = new SqlCommand(query, con);
                 SqlDataReader sdr = cm.ExecuteReader();*/
                while (sdr.Read())
                {
                    studentModel = new StudentModel();
                    studentModel.Id = Convert.ToInt32(sdr["Id"]);
                    studentModel.FirstName = Convert.ToString(sdr["FirstName"]);
                    studentModel.LastName = Convert.ToString(sdr["LastName"]);
                    studentModel.EmailId = Convert.ToString(sdr["EmailId"]);
                    studentModel.Branch = Convert.ToString(sdr["Branch"]);
                    studentModel.Phoneno = Convert.ToInt64(sdr["Phoneno"]);
                    studentModel.S_Address = Convert.ToString(sdr["S_Address"]);
                    studentModel.Dob = Convert.ToString(sdr["Dob"]);
                    studentModels.Add(studentModel);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            };
            return studentModels;
        }
        public string SaveStudentData(StudentModel student)
        {

            try
            {
                SqlConnection con = new SqlConnection("data source=.; database=Stories;integrated security=SSPI");
                con.Open();
                SqlCommand cm = new SqlCommand("insert into Tbl_Student values(" + student.Id + ", '" + student.FirstName + "'," +
                    "'" + student.EmailId + "','" + student.Branch + "', '" + student.Phoneno + "','" + student.S_Address + "','" + student.Dob + "');", con);
                SqlDataReader dr = cm.ExecuteReader();
            }
            catch (Exception ex)
            {

            }
            return " insert data sucessfully";
        }

        public string UpdateStudentData(StudentModel student)
        {
            try
            {
                SqlConnection con = new SqlConnection("data source=.;database=Stories;integrated security=SSPI");
                con.Open();
                SqlCommand cm = new SqlCommand("update Tbl_Student set  FirstName='" + student.FirstName + "',LastName='" + student.LastName + "',EmailId='" + student.EmailId + "', Branch='" + student.Branch + "',Phoneno=" + student.Phoneno + ",S_Address='" + student.S_Address + "',DOB='" + student.Dob + "' where Id=" + student.Id + "", con);
                cm.ExecuteNonQuery();

            }

            catch (Exception ex)
            {
                Console.WriteLine("ex.error");
            }

            return "updated";
        }
        
         public string DeleteStudentData(int Id)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source =.;database=Stories;integrated security=SSPI");
                con.Open();
                string query = "delete from Tbl_Student where Id =  " + Id + "";
                SqlCommand cm = new SqlCommand(query, con);
                SqlDataReader dr = cm.ExecuteReader();
            }

            catch (Exception ex)
            {
                Console.WriteLine("ex.error");
            }
            return "deleted";

        }





    }
}