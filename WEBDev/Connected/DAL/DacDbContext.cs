using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connected.Model;
using Microsoft.Data.SqlClient;

namespace Connected.DAL
{
    internal class DacDbContext
    {
        string ConStr = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Anurag;Integrated Security=True;Encrypt=False";
        List<Student> students = new List<Student>();

        public List<Student> SelectRecord()
        {
            SqlConnection con = new SqlConnection(ConStr);
            string sel = "select * from Student";
            SqlCommand cmd = new SqlCommand(sel, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                students.Add(new Student()
                {
                    Id = Convert.ToInt32(rdr["Id"]),
                    Name = rdr["Name"].ToString(),
                    City = rdr["City"].ToString()
                });
            }
            con.Close();
            return students;
        }

        internal int Insert(Student student)
        {
            SqlConnection con = new SqlConnection(ConStr);
            string insert = $"insert into student values('{student.Name}','{student.City}')";
            SqlCommand cmd = new SqlCommand(insert, con);
            con.Open();
            int no_of_affected = cmd.ExecuteNonQuery();
            con.Close();
            return no_of_affected;
        }

        internal int Update(Student upstudent)
        {
            SqlConnection con = new SqlConnection(ConStr);
            string update = $"update Student set Name='{upstudent.Name}', City='{upstudent.City}' where id = {upstudent.Id}";
            SqlCommand cmd = new SqlCommand(update, con);
            con.Open();
            int no_of_affected = cmd.ExecuteNonQuery();
            con.Close();
            return no_of_affected;
        }
    }
}
