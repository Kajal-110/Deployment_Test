using System.Data.SqlClient;

namespace CRUD.Models
{
    public class StudentDataAccessLayer
    {
        SqlConnection  connectionString = new SqlConnection("Data Source=KajalPatel-PC; Initial Catalog=Student;integrated security=true;MultipleActiveResultSets=True");
        public IEnumerable<Student> GetAllStudent()
        {
            List<Student> students = new List<Student>();
            SqlCommand cm = new SqlCommand("Select * from StudentInformation", connectionString);
            connectionString.Open();
            SqlDataReader sdr= cm.ExecuteReader();
            while (sdr.Read()) 
            { 
                Student student = new Student();
                student.Id= Convert.ToInt32(sdr["ID"]);
                student.Name= sdr["Name"].ToString();
                student.Address = sdr["Address"].ToString();
                student.Age = sdr["Age"].ToString();
                students.Add(student);
            }
            connectionString.Close();
            return students;
        }
        public void AddStudent(Student student)
        {
            var query = "insert into StudentInformation(Id, Name, Address, Age) values (@Id, @Name, @Address, @Age)";
            connectionString.Open();
            using (var command = new SqlCommand(query, connectionString))
            {
                command.Parameters.AddWithValue("@Id",student.Id);
                command.Parameters.AddWithValue("@Name", student.Name);
                command.Parameters.AddWithValue("@Address", student.Address);
                command.Parameters.AddWithValue("@Age", student.Age);
                command.ExecuteNonQuery();
            }
            
        }
    }
}
