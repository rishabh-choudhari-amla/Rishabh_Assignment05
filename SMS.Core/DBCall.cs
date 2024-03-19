using System.Configuration;
using System.Data.SqlClient;
using SMS.Model;
namespace SMS.Core
{
    public class DBCall
    {
       public int Insert(StudentDetails studentDetails)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            conn.Open();
            string dob = studentDetails.DateOfBirth.ToString("yyyy-MM-dd");
            string query = "INSERT INTO Student (Id, FirstName, LastName, Standard, DateOfBirth, Gender, Caste, Address, Email, City, Section) VALUES ('" + studentDetails.Id + "','" + studentDetails.FirstName + "','" + studentDetails.LastName + "','" + studentDetails.Standard + "','" + dob + "','" + studentDetails.Gender + "','" + studentDetails.Address + "','" + studentDetails.Email + "','" + studentDetails      .City + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
    }
}
