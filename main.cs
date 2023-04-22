/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.


Alex Olhovskiy
*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      //#64
      MakeRow(ArrQuery());
      MyClear();
      
      //#66
      MakeRowSum(ArrQuery());
      MyClear();
      
      //#68
      Console.WriteLine("Enter number 1");
      int m=int.Parse(Console.ReadLine());
      Console.WriteLine("Enter number 2");
      int n=int.Parse(Console.ReadLine());
      Console.WriteLine("Result is "+AkkermanFunc(m,n));
      MyClear();
  }
  
  public static void MyClear()
  {
      Console.WriteLine();
      Console.WriteLine("Press Enter key");
      Console.ReadLine();
      Console.Clear();
  }
  
  public static int AkkermanFunc(int m,int n)
  {
      if(m==0)
      {
          return n+1;
      }
      else
      {
          if((m!=0)&&(n==0))
          {
              return AkkermanFunc(m-1,1);
          }
          else
          {
              return AkkermanFunc(m-1,AkkermanFunc(m,n-1));
          }
      }
  }
  
  public static void Recursion(int m,int n)
  {
      if(m>n)
      {
          Console.Write(m+" ");
          m--;
          Recursion(m,n);
      }
  }
  
  public static void MakeRow(int[]arr)
  {
      int min_num=0;
      int max_num=0;
      if(arr[0]>arr[1])
      {
          max_num=arr[0];
          min_num=arr[1];
      }
      else
      {
          max_num=arr[1];
          min_num=arr[0];
      }
      Recursion(max_num,min_num);
  }
  
  
  public static void Sum(int m,int n,int sum)
  {
      if(n<=m)
      {
          sum+=n;
          Console.Write(sum+" ");
          n++;
          Sum(m,n,sum);
      }
  }
  
  public static void MakeRowSum(int[]arr)
  {
      int min_num=0;
      int max_num=0;
      if(arr[0]>arr[1])
      {
          max_num=arr[0];
          min_num=arr[1];
      }
      else
      {
          max_num=arr[1];
          min_num=arr[0];
      }
      int sum=0;
      Console.Write(sum+" ");
      Sum(max_num,min_num,sum);
  }
  
  public static int[]ArrQuery()
  {
      int[]arr=new int[2];
      Console.WriteLine("Enter number 1");
      arr[0]=int.Parse(Console.ReadLine());
      Console.WriteLine("Enter number 2");
      arr[1]=int.Parse(Console.ReadLine());
      return arr;
  }
}
