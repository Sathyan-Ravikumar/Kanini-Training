using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnect
{
    internal class DBDisconnect
    {
        SqlConnection conn;
        DataSet ds;
        SqlDataAdapter da;
   
        public void OpenConn()
        {
            conn = new SqlConnection("data source= SATHYAN\\SQLEXPRESS; " + "database=Student; " + "integrated security=SSPI");
            try
            {
                conn.Open();
                Console.WriteLine("Open");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Connection not established");
            }
        }
        public void ReadData()
        {
            da = new SqlDataAdapter("select * from stud_details", conn);
            ds = new DataSet();
            da.Fill(ds,"sd");
            //Console.WriteLine(ds.Tables["sd"].Columns[0].ColumnName);
            foreach (DataRow dr in ds.Tables["sd"].Rows)
            {
                Console.WriteLine(dr[0].ToString()+ " " + dr["name"].ToString());//we can give column name also in index place
            }
            conn.Close();
        }
        public void InsertRecord(int rno)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(da);

            ds.Tables["sd"].Columns["rno"].Unique = true;
            ds.Tables["sd"].Columns["name"].DefaultValue="zzz";// it is the default for name 

            DataRow dr = ds.Tables["sd"].NewRow();
            dr[0] = rno;
            //dr[1] = name;
            ds.Tables["sd"].Rows.Add(dr);
            da.Update(ds, "sd");
            Console.WriteLine("Inserted");
            conn.Close();

        }
       /* public void UpgradeRecord(int rno)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            foreach(DataRow dr in ds.Tables["sd"].Rows)
            {
                if (Int32.Parse(dr["rno"].ToString() == rno))
                {
                    dr["name"] = "sethu";
                }
                
            }
        }
        public void DeleteRecord()
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            foreach (DataRow dr in ds.Tables["sd"].Rows)
            {
                if (Int32.Parse(dr["rno"].ToString() == rno))
                {
                    dr.Delete();
                    break;
                }
            }
            //da.Update();
            Console.WriteLine("Deleted");
        }*/
    }
}
