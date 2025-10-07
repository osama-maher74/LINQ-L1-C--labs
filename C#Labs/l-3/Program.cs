namespace Lab3
{
    internal class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
		}
		delegate int myDelegate(int a, int b);
		static void Main(string[] args)
        {

            //MyList<int> myList = new MyList<int>();
            //myList.Add(1);
            //myList.Add(2);
            //myList.Add(3);
            //myList.Add(4);
            //myList.Add(4);
            //myList.Add(4);
            //myList[0] = 100;
            //Console.WriteLine(myList[0]);
            //Console.WriteLine(myList);
            //Console.WriteLine(myList.Get(2));
            
            //List<int> list = new List<int>() ;
            //list.Add(1);

            InhiritList<string> list = new InhiritList<string>();
            list.add("Hello");
            list.add("World");
            Console.WriteLine(list.get(0));
			//myDelegate del = new myDelegate(Add);
			//Console.WriteLine(del.Invoke(10, 20));


		}
    }
}
