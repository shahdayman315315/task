using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
namespace task
{
    // Generics is Type-safe and more Effecient with better performance than non generic(which requires boxing and unboxing its objects)
    public interface Ihuman<T>   //generic interface
    {
        void job(T name);
    }

    public class Employee <T>: Ihuman <T> where T:struct  //must be a value type only if we want a reference type use keyword (class) instead
       // public class Employee <T> :Ihuman where T:class, Ihuman<T>   >>must be a reference type and implement the interface Ihuman also
    {
        public void job(T name)
        {
            Console.WriteLine(name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3] { 1, 2, 3 };  // fixed size
            // Array list >> nongeneric collection >> can't use <T>
            ArrayList arr2=new ArrayList();  //dynamic , stored unlimited num of objects of different typs
            arr2.Add(1);    //converts the integer into reference type (boxing) and store it in the array
            arr2.Add(2);
            arr2.Add("shahd");
            arr2.Insert(0, 0);  //insert at index 0 value 0
            arr2.AddRange(arr); // will add the array into the array list
            arr2.Remove(0);
            arr2.RemoveAt(2); // will remove object at index 2
            Console.WriteLine(arr2[0]);   // when accesing the element it will be converted back into value type(unboxing)


            // List >> generic collection >>can use <T>
            List<int> l1=new List<int>(); //stores a collection of specific type
            l1.Add(1);
            l1.Insert(0, 2);
            l1.AddRange(arr);
            l1.Remove(1);
            l1.Sort();
            foreach(var item in l1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(l1.Contains(33));
            List<string> l2=new List<string>();
            l2.Add("shahd");
            l2.RemoveAt(0);
            Console.WriteLine(l1[1]);
            List<Employee<int>> l3=new List<Employee<int>>(); //we can create list of objects of type Employee

            l3.Add(new Employee<int>());

            // Dictionary >> generic collection >>can use <T>
            Dictionary<int, string> d = new Dictionary<int, string>(); //consists of pairs of keys and values (key must be unique)
            d.Add(1, "shahd");
            d.Add(2, "mohamed");
            string name = d[1];
            Console.WriteLine(name);

            foreach(var item in d)
            {
                Console.WriteLine(item.Key+" ,  "+item.Value);
            }

            // Sorted list >>the same as dictionary nut sorted by the key
            SortedList<int, string> sl = new SortedList<int, string>(); //consists of pairs of keys and values (key must be unique)
            
            sl.Add(2, "mohamed");
            sl.Add(1, "shahd");
            string name2 = sl[1];
            Console.WriteLine(name);
            // its implicitly sorted using BST (binary search tree)
            foreach (var item in d)
            {
                Console.WriteLine(item.Key + " ,  " + item.Value);
            }

            //Hashtable >> nongeneric
            Hashtable h=new Hashtable(); //stores pairs of objects
            h.Add("nour", 1);
            h.Add(1, "ali"); //so it is not effecient
            foreach (var item in h)
            {
                Console.WriteLine(item.ToString());  // pairs of key,value
            }
            string res = (string)h[1];  //must cast object to string 
            Console.WriteLine(res);

            //Stack >> (lifo) (generic and nonGeneric)
            Stack<int> s=new Stack<int>();
            s.Push(1);
            s.Push(2);
            string[] arr3=new string[2] { "shahd", "noor" };
            Stack<string> s2=new Stack<string>(arr3);
            s2.Push("reem");
            Console.WriteLine(s.Peek());
            Console.WriteLine(s2.Peek());

            while (s2.Count > 0)
            {
                Console.WriteLine(s2.Pop());
            }

            //Queue >>(FiFo) (similar to the stack(generic and nongeneric)
            Queue<int> q=new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            Console.WriteLine(q.Peek());
            foreach(var item in q)
            {
                Console.WriteLine(item);
            }
            q.Dequeue();
            Console.WriteLine(q.Count);

        }
    }
}
