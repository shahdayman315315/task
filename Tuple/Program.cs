
namespace Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tuple class(reference type) stores up-to 8 different objects and the last item called "Rest"
            Tuple<int, int, string> t1 = new Tuple<int, int, string>(1,2,"shahd");
            // var t2 = Tuple.Create(1.5, 2, 's');
            Console.WriteLine(t1.Item1);  // 1
            // Console.WriteLine(t1.Rest.Item1);
            info("shahd",19);

            //Value Tuple >> struct(value type) , more flexible and better performance than Tuple >>stores more than 8 objects
            //different ways for declaring ValueTuple
            ValueTuple<int, int> v = new ValueTuple<int, int>(1, 2);
            ValueTuple<int , string > v2 = (3, "noor");
            (string , double) v3 = ("Mahmoud", 2.0);
            (int n1,int n2,int n3, int n4, int n5, int n6, int n7) v4=(1,2,3,4,5,6,7);
            Console.WriteLine(v4.n1  + v4.n2);

            string name=info2().s;
            int age=info2().a;
            // the same as
            /*
             *string name=info2().Item1;
            int age=info2().Item2;
             */
            Console.WriteLine(name + " " +age);

        }
         // using Tuple to return more than value
         static Tuple<string,int> info (string s,int i)
        {
            s += "is the name for person";
            if (!(i > 18 && i < 60)) i = 18;
            return new Tuple<string,int>(s,i);
        }

        // using ValueTuple to return more than value
        static (string s ,int a )  info2()
        {
            string name = "mohamed";
           int  age= 30;
            return (name, age);
        }
    }
}
