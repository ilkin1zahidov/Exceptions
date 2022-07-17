using Exceptions.Exceptionss;
using System;
using System.Collections.Generic;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            //try
            //{
            //    int a = 5;
            //    int b = 0;
            //    var result = a / b;


            //    int[] arr = new int[3];
            //    arr[7] = 8;
            //}
            //catch (NullReferenceException ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally 
            //{
            //    Console.WriteLine("Duzelin");
            //}
            //Divide(18, 2);
            //List<string> list = new List<string>() { "Ilkin", "Orxan", "Seid", "Emil" };

            //string searchText = "Emil";

            //FindName(list, searchText);
            Login("Ilkin@gmail.com", "001101");

        }
        public static void Login(string email, string password)
        {
            try
            {
                if (password != "001101")
                {
                    throw new MemberAccessException("Wrong password");
                }
                Console.WriteLine(email, password);



            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
        //public static void Divide(int num1, int num2)
        //{
        //    try
        //    {
        //        if (num2 == 2)
        //        {
        //            throw new DivideByZeroException("num 2 cant equal 2");
        //        }
        //        Console.WriteLine(num1 / num2);
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.Message);
        //    }

        //}

        //public static void FindName(List<string> names, string name) 
        //{
        //    try
        //    {
        //        //if(!names.Contains(name)) 
        //        //{
        //throw new FindNameException("Not found"

        //        //Console.WriteLine("Tapildi");
        //        var data = names.Find(m => m == name);
        //        if(data is null) throw new FindNameException("Not found");

        //        Console.WriteLine("Tapildi");
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.Message);
        //    }
        //}

    }





}

