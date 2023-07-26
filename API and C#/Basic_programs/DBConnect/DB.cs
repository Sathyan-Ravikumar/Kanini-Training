using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnect
{
    internal class DB
    {


        SqlConnection conn;
        public void OpenConn(string constr)
        {
            //Console.WriteLine(ConfigurationManager.AppSettings["num1"]);

            //conn = new SqlConnection("data source= SATHYAN\\SQLEXPRESS; " + "database=Student; " + "integrated security=SSPI");
            conn = new SqlConnection(constr);

            try
            {
                conn.Open();
                Console.WriteLine("Open");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Server Not Connected");
            }
        }
        
        public void CreateTable()
        {
            
            SqlCommand cmd = new SqlCommand("create table stud_details(rno int,name nvarchar(20));", conn);
            if (conn != null)
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Created");
            }
          
        }
        public void InsertTable()
        {
            SqlCommand cmd = new SqlCommand("Insert into stud_details values(1008,'vignesh')", conn);
            if (conn != null)
            {
               int cou= cmd.ExecuteNonQuery();
                Console.WriteLine(cou + " row inserted");//can print how many rows inserted
            }
        }
        public void update()
        {
            SqlCommand cmd = new SqlCommand("update stud_details set rno=101 where name='sathya'", conn);
            if (conn != null)
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Updated");
            }
        }
        public void detele()
        {
            SqlCommand cmd = new SqlCommand("delete stud_details where name='sathya'", conn);
            if (conn != null)
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("deleted");
            }
        }
        public void ReadTable()
        {
            SqlCommand cmd = new SqlCommand("select * from stud_details", conn);
            SqlDataReader sdr;
            if (conn != null)
            {
                sdr = cmd.ExecuteReader();
                Console.WriteLine(sdr.HasRows);
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        Console.WriteLine(sdr["rno"] + " " + sdr["name"]);
                    }
                }
                else
                {
                    Console.WriteLine("Data set is empty");
                }
            }
        }
        public void CountofStud()
        {
            SqlCommand cmd = new SqlCommand("select count(*) from stud_details");
            object res =  cmd.ExecuteScalar();
            if (res != null)
            {

                Console.WriteLine(res.ToString());
            }
        }
        public void FetchStudentDetails()
        {
            SqlCommand cmd = new SqlCommand("dbo.usp_readstudet", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            // cmd.Parameters.Add(new SqlParameter());
            SqlParameter parameter;
            parameter = cmd.Parameters.Add("@rollno", System.Data.SqlDbType.Int);
            parameter.Value = 105;
            parameter.Direction = ParameterDirection.Input;

            parameter = cmd.Parameters.Add("@cou", SqlDbType.Int);
            parameter.Direction = ParameterDirection.Output;
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Console.WriteLine(sdr["name"] + " " + sdr["rno"]);
            }
        }
        public void CloseConn()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
