using System;

namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("num1 = 15.2 , mum2 = 3.2");

            //ตัวอย่างความสัมพันธ์ของ class แม่ จะ
            var  plusExam = new Plus(1,2);
            var plusExamShow = plusExam.Show();
            Console.WriteLine("Class Operation.Show : "+plusExamShow);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");

            var plus = new Plus(15.2, 3.2);
            var plusShow = plus.Show();
            var plusRes = plus.Execute();
            Console.WriteLine(plusShow);
            Console.WriteLine($"Result : {plusRes}");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");

            var minus = new Minus(15.2, 3.2);
            var minusShow = minus.Show();
            var minusRes = minus.Execute();
            Console.WriteLine(minusShow);
            Console.WriteLine($"Result : {minusRes}");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");

            var multiplied = new Multiplied(15.2, 3.2);
            var multipliedShow = multiplied.Show();
            var multipliedRes = multiplied.Execute();
            Console.WriteLine(multipliedShow);
            Console.WriteLine($"Result : {multipliedRes}");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");

            var divide = new Divide(15.2, 3.2);
            var divideShow = divide.Show();
            var divideRes = divide.Execute();
            Console.WriteLine(divideShow);
            Console.WriteLine($"Result : {divideRes}");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");
        }
    }
}
