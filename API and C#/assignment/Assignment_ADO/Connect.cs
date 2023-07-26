using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_ADO
{
    internal class Connect




    {
        SqlConnection connection;
        public void OpenConn()
        {
            connection = new SqlConnection("data source= SATHYAN\\SQLEXPRESS; " + "database=AssignmentADO_DataBank; " + "integrated security=SSPI");
            try
            {
                connection.Open();
                Console.WriteLine("Open");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Server Not Connected");
            }
        }
        public void CreateTable()
        { 

            SqlCommand Regions = new SqlCommand("create table Regions(Region_id int primary key not null,Region nvarchar(40) not null);", connection);
            SqlCommand CustomerNodes = new SqlCommand("create table CustomerNodes(Customer_id int primary key not null,Region_id int Foreign key REFERENCES Regions not null ,Nodes nvarchar(40),Balance money);", connection);
            SqlCommand CustomerTransaction = new SqlCommand("create table CustomerTransaction(Transaction_id int primary key,Customer_id int Foreign key REFERENCES CustomerNodes not null,Type nvarchar(20) not null,Amount money,Transaction_Date date not null,Balance money);", connection);
            if (connection != null)
            {
                Regions.ExecuteNonQuery();
                CustomerNodes.ExecuteNonQuery();
                CustomerTransaction.ExecuteNonQuery();
                Console.WriteLine("Tables Created");
            }

        }
        public void InsertValues()
        {
            SqlCommand Regionvalues;
            SqlCommand CustomerNodeValues;
            SqlCommand CustomerTransValues;

           Regionvalues= new SqlCommand("Insert into Regions values(101,'Chennai'),(102,'Coimbatore'),(103,'Krishnagiri'),(104,'Madurai')",connection);

            CustomerNodeValues = new SqlCommand("Insert into CustomerNodes values(10001,101,'Solinganallur',12000),(10002,102,'neelambur',1000),(10003,101,'T nagar',15350)," +
                                     "(10004,103,'Thiruvalluvar Nagar',9500),(10005,104,'Vadipatti',13400),(10006,103,'Periyar Nagar',5000)," +
                                     "(10007,102,'Gandhi puram',8000),(10008,102,'Selva puram',6000),(10009,101,'Anna Nagar',30000),(10010,103,'Santhi Nagar',25000)", connection);

            CustomerTransValues = new SqlCommand("Insert into CustomerTransaction values(1,10001,'Deposite',1000,'2023/03/08',12000),(2,10002,'Withdraw',5000,'2023/03/07',1000),(3,10001,'Withdraw',3000,'2023/04/09',12000),(4,10010,'Deposite',5000,'2023/03/15',25000)," +
                                     "(5,10003,'Deposite',500,'2023/03/06',15350),(6,10005,'Withdraw',4000,'2023/04/09',13400),(7,10002,'Deposite',6000,'2023/04/05',1000)," +
                                     "(8,10007,'Deposite',7000,'2023/03/02',8000),(9,10008,'Deposite',2000,'2023/04/08',6000),(10,10003,'Withdraw',4000,'2023/04/24',15350),(11,10007,'Deposite',500,'2023/04/20',8000),(12,10008,'Deposite',9000,'2023/03/18',6000)" +
                                     ",(13,10008,'Withdraw',3000,'2023/04/08',6000),(14,10006,'Deposite',5000,'2023/03/16',5000),(15,10004,'Deposite',1000,'2023/04/01',9500)",connection);

            if (connection != null)
            {
                Regionvalues.ExecuteNonQuery();
               CustomerNodeValues.ExecuteNonQuery();
                CustomerTransValues.ExecuteNonQuery();
                Console.WriteLine("Values inserted Successfully");
            }
        }
        public void Question1()
        {
            SqlCommand cmd = new SqlCommand("select R.region, count(Distinct CustomerNodes.Nodes)as counts from Regions R inner join CustomerNodes on R.region_id = CustomerNodes.region_id group by R.Region", connection);
            Console.WriteLine("Display the number of nodes per region");
            SqlDataReader sdr;
            if (connection != null)
            {
                sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        Console.WriteLine(sdr[0] + " - " + sdr[1]);
                    }
                }
                else
                {
                    Console.WriteLine("Data set is empty");
                }
                sdr.Close();
            }
            
        }
        public void Question2()
        {
            SqlCommand cmd = new SqlCommand(" select r.Region, count(distinct c.Customer_id) customer_counts from CustomerNodes c inner join Regions r on c.Region_id=r.Region_id group by r.region", connection);
            Console.WriteLine("Display the number of customers allocated to each region");
            SqlDataReader sdr;
            if (connection != null)
            {
                sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        Console.WriteLine(sdr[0] + " - " + sdr[1]);
                    }
                }
                else
                {
                    Console.WriteLine("Data set is empty");
                }
                sdr.Close();
            }
        }
        public void Question3()
        {
            SqlCommand cmd = new SqlCommand("select cn.Customer_id,Count(*) total,AVG(Amount) Average  from CustomerNodes cn join CustomerTransaction ct on cn.Customer_id=ct.Customer_id  where \"Type\"='deposite' group by cn.Customer_id;", connection);
            Console.WriteLine("Display the total count and average amount of deposits for all the customers");
            SqlDataReader sdr;
            Console.WriteLine();
           
            if (connection != null)
            {
                sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        Console.WriteLine(sdr[0] + "  " + sdr[1]+ "  "+sdr[2]);
                    }
                }
                else
                {
                    Console.WriteLine("Data set is empty");
                }
                sdr.Close();
            }
        }
        public void Question4()
        {
            SqlCommand cmd = new SqlCommand("select Customer_id, Amount+Balance AS TOTAL_BALANCE from CustomerTransaction where \"Type\"='deposite';", connection);
            Console.WriteLine("Display the closing balance for each customer at the end of the month");
            Console.WriteLine();
            SqlDataReader sdr;
            if (connection != null)
            {
                sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        Console.WriteLine(sdr[0] + "  " + sdr[1]);
                    }
                }
                else
                {
                    Console.WriteLine("Data set is empty");
                }
                sdr.Close();
            }
        }
        public void Question5()
        {
            SqlCommand cmd = new SqlCommand("select COUNT(Customer_id)\r\n from CustomerTransaction  where Amount > 0 and Type='deposite' and DAY(Transaction_Date)>10;", connection);
            Console.WriteLine("Display the number of customers who have increased their closing balance compared to the\r\nprevious month.");
            SqlDataReader sdr;
            if (connection != null)
            {
                sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        Console.WriteLine(sdr[0]);
                    }
                }
                else
                {
                    Console.WriteLine("Data set is empty");
                }
                sdr.Close();
            }
        }
        public void CloseConnection()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }
    }
}
