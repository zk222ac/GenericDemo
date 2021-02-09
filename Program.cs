using System;
using System.Collections.Generic;

namespace GenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine("Hello World!");
            var result = Addition(1, 3);
            Console.WriteLine(result);
            var resultString = Addition("string1", "string2");
            Console.WriteLine(resultString);

            Console.WriteLine("................................");
            // Class is int specific type
            //var resultInt = new AdditionInt { a = 1, b = 2, Data = 1 };
            //var outputInt = resultInt.a + resultInt.b;
            //Console.WriteLine(outputInt);

            //// Class is string specific type
            //var resultString1 = new AdditionString() { a = "string1", b = "string2", Data = "data" };
            //var outputString = resultString1.a + resultString1.b;
            //Console.WriteLine(outputString);

            //// class speciofic for object type 
            //var resultObject = new AdditionObject() { emp = new Employee() { Id = 1, Name = "employee" } };
            //Console.WriteLine(resultObject.emp);

            // Here I am calling Generic method Type 

            // calling int in a generic class
            //var resultGeneric = new Addition<int>() { a = 1, b = 2, Data = 1234 };
            // here I am calling string in a generic type 
            // var resultGeneric = new Addition<string>() { a = 1, b = "sting2", Data = "data" };
            // Here I am calling object in ageneric type
            var resultGeneric = new Addition<Employee,Employee>() { a = 1, b = new Employee() { Id = 123, Name = "Employee" }, Data = new Employee() { Id = 567, Name = "Data employee" } };

           
           
            Console.WriteLine(resultGeneric.Data);

            Console.ReadKey();   
            

        }

        // this method takes two parameters a and b
        // this method returns int 
        // this this method has int input as well as int retuen type
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        // This time you need to create new method for string data type

        public static string Addition(string a, string b)
        {
            return a + "-" + b;
        }

        public static Employee Addition(Employee a , Employee b)
        {
            var emp1 = new Employee() { Name = "Name1" };

            return emp1;
        }

        List<int> listInt = new List<int>() { 1, 2, 3, 3, 4 };
        List<string> listString = new List<string>() { "string1", "string2", "string3" };
        List<Employee> listEmployee = new List<Employee>()
        {
            new Employee(){Id=1, Name="Employee1"},
            new Employee(){Id=2, Name="Employee2"},

        };

    }

    // Hpw you make your class generic
    // you have to mentioned the generic type in the Class
    // How you can define generic type in the Class , is simply using the Keyword T after class name
    // ankle bracket --> <T>
    // T --> type spepcif ( generic type)

    // generic means not specific to a particular data type
    // One you define <T> after the class name , so you dont to repeat agin the same thing in all methods and properties
    // because it is authomatically assumed the all data members would be generic

    // T , L --> whatever type to define or choose
    public class Addition<T , L>
    {
        // you have force to a property should be int data type
        // it does not matter you class is generic type because you force to do that what you advice
        public int a { get; set; }
        public T b { get; set; }
        public T Data { get; set; }

        public L ExtraParatmeter { get; set; }

    }
    // NOn generic class vs Generic 
    // Int specific type Class
    public class AdditionInt
    {
        public int a { get; set; }
        public int b { get; set; }
        public int Data { get; set; }

        // Non genric method

        //public int Add(int a , int b)
        //{
        //    return a + b;
        //}
        // want to convert this method to be a generic
        public void Method<T>(T a)
        {
            // this method become a genric method inside the Non generic class
        }
        public void Add<T>(T a ,T b)
        {
           // return a > b ? a : b;
        }
    }
    //// string specific type Class
    //public class AdditionString
    //{
    //    public string a { get; set; }
    //    public string b { get; set; }
    //    public string Data { get; set; }
    //}

    //// Object specific type class
    //public class AdditionObject
    //{
    //    public Employee emp { get; set; }
    //}
}
