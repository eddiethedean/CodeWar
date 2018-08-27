using System;

public class Kata
{
  public static bool IsSquare(int n)
  {
    //Step 1: A perfect square never ends in 2, 3, 7 or 8
    //convert n to string
    string s;
    s = n.ToString();
    string l;
    //check last digit
    l = s.Substring(s.Length-1);
    if (l=="2" || l=="3" || l=="7" || l=="8") {
        return false;
    }
    //calculate digital root
    //To find digital root of a number, add all its digits. 
    //loop through string and add up numbers
    int total = 0;
    foreach (char c in s) {
        //total += c.GetNumericValue();
        total += (int)Char.GetNumericValue(c);
    }
    //If this sum is more than 9, add the digits of this sum. 
    if (total>9) {
        int newTotal = 0;
        string st;
        st = total.ToString();
        foreach (char c in st){
            newTotal += (int)Char.GetNumericValue(c);
        }
        total = newTotal;
    }
    //The single digit obtained at the end is the digital root of the number.
    string rootNum = total.ToString().Substring(s.Length-1);
    // a perfect square will always have a digital root of 0, 1, 4 or 7.
    if (rootNum !="0" && rootNum!="1" && rootNum!="4" && rootNum!="7") {
        return false;
    }
    
    return true;
    
  }
}