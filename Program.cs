

using System.Threading.Channels;
using Extensions;


int[] ar=new []{4,5,6,8,9,6,9};
// Console.Write("Qaysi indexga o'chirasiz:  ");
// int t=int.Parse(Console.ReadLine()); 
// var res=ar.Remove(t);
// foreach (var i in res)
// {
//    // Console.Write(i+"   ");
// }

Console.Write("Qaysi element qo'shasiz:  ");
int t = int.Parse(Console.ReadLine());

Console.Write("Qaysi indexga qo'shasiz:   ");
int a = int.Parse(Console.ReadLine());

var res=ar.Add(a, t);

foreach (var i in res)
{
    Console.Write(i+" ");
}



