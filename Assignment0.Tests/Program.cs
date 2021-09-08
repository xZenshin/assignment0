using System;
using System.Collections.Generic;

namespace Assignment0 
    {

public class TestClass 
    {
    
    static void Main(string[] args) 
        {
            var testClass = new TestClass();
            Console.WriteLine("Enter Year:");

            string input = Console.ReadLine();
            int yearToConvert = Convert.ToInt32(input);

            if (testClass.IsLeapYear(yearToConvert)) {
                Console.WriteLine("yeay");
            }
            else {
                Console.WriteLine("Nay");
            }
        }

    public bool IsLeapYear(int year) 
        {
            if (year % 100 == 0) {
                if (year % 400 == 0) {
                    return true;
                }
                return false;
            }
            if (year % 4 == 0) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}