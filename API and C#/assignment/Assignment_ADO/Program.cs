using Assignment_ADO;

class Program
{
    public static void Main(string[] args)
    {
        Connect DB = new Connect();
        DB.OpenConn();
         //DB.CreateTable();
         //DB.InsertValues();
        //DB.Question1();
       // DB.Question2(); 
        //DB.Question3();
        //DB.Question4();
        DB.Question5();
       DB.CloseConnection();
    }
}