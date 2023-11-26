Frazione f1 = new Frazione(6,7);
Frazione f2 = new Frazione(3,9);
Frazione f3 = new Frazione(6,9);
Frazione f4 = new Frazione(1,2);


Console.WriteLine(f1+f2);
Console.WriteLine(f1-f2);
Console.WriteLine(f1*f2);
Console.WriteLine(f1/f2);

if((f3.CompareTo(f4))==0){
    Console.WriteLine("f3 = f4");
}
else if((f3.CompareTo(f4))==1){
    Console.WriteLine("f3 > f4");
}
else{
    Console.WriteLine("f3 < f4");
}
