using System;
using System.Text;
DateTime date1 = new DateTime(2009, 7, 1);
TimeSpan hiTime = new TimeSpan(14, 17, 32);
decimal hiTemp = 62.1m; 
TimeSpan loTime = new TimeSpan(3, 16, 10);
decimal loTemp = 54.8m; 

object[] values = {date1, hiTime, hiTemp, loTime, loTemp};
string result2 = String.Format("Temperature on {0:d}:\n{1,11}: {2} degrees (hi)\n{3,11}: {4} degrees (lo)",  values);
System.Console.WriteLine(result2);

int a=10;
int b=-a;
System.Console.WriteLine(~b);