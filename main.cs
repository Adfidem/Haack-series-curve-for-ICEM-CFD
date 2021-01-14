/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
//C 0.42
//iteracja 0.05
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("R?");
    double R = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("L?");
    double L = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("C?");
    double C = Convert.ToDouble(Console.ReadLine());
    int i = 0;
    for(double x = 0 ; x <= L ; x = x + L/200 , i++){
        double teta = Math.Acos(1-(2*x)/L);
        double y = R/Math.Sqrt(Math.PI)*Math.Sqrt(teta-Math.Sin(2*teta)/2+2*C*Math.Sin(teta)*Math.Sin(teta)*Math.Sin(teta));
        Console.Write("{");
        Console.Write( x );
        Console.Write( " " );
        Console.Write( y );
        Console.Write( " " );
        Console.Write( 0 );
        Console.Write( "} " );
        //Console.Write("{" , x , " " , y , "} ");
        //Console.WriteLine(x + " " + y);
    }
    Console.Write("{");
    Console.Write( L );
    Console.Write( " " );
    Console.Write( R );
    Console.Write( " " );
    Console.Write( 0 );
    Console.Write( "} " );
  }
}
