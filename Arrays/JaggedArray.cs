using System;
using System.Collections.Generic;
int[][] a=new int[4][];
a[0]=new int[4];
a[1]=new int[5];
a[2]=new int[6];
a[3]=new int[4];
int k=1;

//Initializing the array
for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a[i].Length;j++)
    {
        a[i][j]=k;
        k+=1;
    }
}

//Printing the array
for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a[i].Length;j++)
    {
        System.Console.Write(a[i][j]+" ");
    }
    System.Console.WriteLine();
}