using System;

public class Accumul 
{
	public static String Accum(string s) 
  {
     string sOut = "";
     string sTemp;
     string sC;
     char tC;
     //keep track of count
     int count = 0;
     //loop through s
     foreach (char c in s){
         sC = c.ToString();
         count += 1;
         //make first cap
         if (count == 1){
             sTemp = sC.ToUpper();
         }
         else{
             tC = System.Convert.ToChar(sC.ToLower());
             string mS = new string (tC, count-1);
             sTemp = sC.ToUpper() + mS;
         }
         if (count==1){
             sOut = sTemp;
         }
         else {
             sOut = sOut + "-" + sTemp;
         }
     }
     return sOut;
  }
}

