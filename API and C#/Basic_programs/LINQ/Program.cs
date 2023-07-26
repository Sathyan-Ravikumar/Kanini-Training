using LINQ;

delegate bool EligibleCheck(People person);
class Program
{
    public static void Main(string[] args)
    {

        People[] people =
        {
             new People(){ Name = "kanna" , Age = 19 },
             new People(){ Name = "sundhar" , Age = 21 },
             new People(){ Name = "kani" , Age = 17 },
             new People(){ Name = "Rahul" , Age = 23 },
             new People(){ Name = "vasanth" , Age = 15 },
             new People(){ Name = "rajeesh" , Age = 18 },
        };
        /*
        People[] Voters = new People[people.Length];

        int i = 0;
         
        foreach(People person in people) { 
            if(person.Age >= 18)
            {
                Voters[i++] = person;
                Console.WriteLine(person.Name + " " +person.Age);
            }
        }

        //using Delegate
        List<People> voters =VoterCheck.where(people,delegate(People person)
        {
            return person.Age >= 18;
        });
        foreach(People voter in voters)
        {
            Console.WriteLine(voter.Name);
        }
        

        //lamda expression
        People[] voters = people.Where(person => person.Age >= 18).ToArray();
        foreach(People voter in voters)
        {
            Console.WriteLine(voter.Name);
        }

        //query
        var vote =from person in people where person.Age>=18 select person;
       // Console.WriteLine(vote);
        foreach (People votechecking in vote)
        {
            Console.WriteLine("Using Query : "+votechecking.Name);
        }
        */



        Classifications classifications = new Classifications();
        //classifications.example2();
        //classifications.FilteringOfType();
        //classifications.SortingOrderBy();
        classifications.Groupby();
    }
}