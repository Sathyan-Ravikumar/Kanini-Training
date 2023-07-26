using System.Configuration;
using System.Data.SqlClient;
using DBConnect;

class Program : ConfigurationSection
{
    public static void Main(string[] args)
    {
        /* DBDisconnect dbd=new DBDisconnect();
         dbd.OpenConn();
         dbd.ReadData();
         dbd.InsertRecord(1006);*/  
        //Console.WriteLine(ConfigurationManager.AppSettings["num1"]);
        //Console.WriteLine(ConfigurationManager.AppSettings["num2"]);
        string constr;
        constr = ConfigurationManager.ConnectionStrings["SQLStudentDB"].ConnectionString;
        DB db = new DB();
        db.OpenConn(constr);
        // db.InsertTable();
        //db.detele();
        db.ReadTable();
        //db.CountofStud();
        //db.CloseConn();

        // sql server  name : SATHYAN\SQLEXPRESS


    }
}