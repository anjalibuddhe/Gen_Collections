using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenCollections
{
    internal class Product
    {
        static void Main(string[] args)
        {
            //List of Integer
            List<int> num = new List<int>();
            num.Add(1);
            num.Add(2);
            num.Add(3);
            num.Add(4);
            num.Add(5);

            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("__________OUTPUT____________");

            num.Sort();

            num.Remove(1);
            num.RemoveAt(1);
            num.Insert(2, 7);
            num.RemoveRange(3, 1);
            num.IndexOf(3);

            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            


            //List of String

            List<string> name = new List<string>();
            name.Add("Hari");
            name.Add("Sara");
            name.Add("Gita");
            name.Add("Sita");
            name.Add("John");
            foreach (string a in name)
                Console.WriteLine(a);

            //name.Insert(2, "Anjali");
            //Console.WriteLine(name);
            //name.RemoveAt(1);
            //name.Remove("sara");

            //name.Clear();
            Console.WriteLine("__________OUTPUT____________");

            name.Sort();

            foreach (string item in name)
            {
                Console.WriteLine(item);
            }


            //product list

            List<Product1>  p1=new List<Product1>();
            p1.Add(new Product1 {id=101,name="pen",price=100});
            p1.Add(new Product1 {id=102,name="mouse",price=1000});
            p1.Add(new Product1 { id=103,name="book",price=200}); 
            
            foreach(Product1 p in p1)
            {
                Console.WriteLine($"{p.id} - {p.name} - {p.price}");
            }

            //p1.RemoveRange(2, 1);
           // p1.Add(new Product1 {id=104, name = "bottle",price=100 });
            
            p1.Insert(2, new Product1 { id=105,name = "book2" ,price=300});

            foreach (Product1 item in p1)
            {
                Console.WriteLine($"{item.name}");
            }


            Stack<int> s1 = new Stack<int>();

            s1.Push(1);
            s1.Push(2);
            s1.Push(3);
            s1.Push(4);
            s1.Push(5);

            // Console.WriteLine(s1.Count);
            s1.Pop();
            s1.Peek();

            foreach (int item in s1)
            {

            Console.WriteLine(item);
            }
            Console.WriteLine("___________ENQUEUE____________");

            Queue<int> que = new Queue<int>();
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);

            que.Dequeue();

            Console.WriteLine(que.Contains(4));
           

            foreach (var item in que)
            {
                Console.WriteLine(item);
            }


            Queue<string> que1= new Queue<string>();
            que1.Enqueue("Book");
            que1.Enqueue("Pen");
            que1.Enqueue("Keyboard");
            que1.Enqueue("Mouse");

            foreach (var item in que1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------");
            que1.Dequeue();

            foreach (var item in que1)
            {
                Console.WriteLine(item);
            }
           




        }
    }
}
