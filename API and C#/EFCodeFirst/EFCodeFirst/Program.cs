using EFCodeFirst;

class Program{
    public static void Main(string[] args)
    {
        CRUDoperattioncs crud = new CRUDoperattioncs();
        // crud.InsertRecordsInStudentEntity();
        // crud.InsertRecordsInCourseEntity();
        //crud.UpdateRecordInStudentEntity();
        // crud.DeleteRecordInStudentEntity();
        crud.ReadDataFromStudentEntity("Abi");
        
    }
}