
namespace Assignment0 
    {

public class TestClass 
    {

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