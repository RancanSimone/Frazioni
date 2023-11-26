
using System.Reflection.Metadata.Ecma335;

class Frazione : IComparable<Frazione>, IEquatable<Frazione>
{
    double N;
    double D;
    public double Val;

    public Frazione(double N, double div){
        this.N = N;
        this.D = div;
        this.Val = N/D;
    }

    public Frazione(){
        N=0;
        D=0;
        Val=6;
    }

    public override string ToString()
    {
        return N + "/" + D;
    }

    public int CompareTo(Frazione? other)
    {
        if(this.Val==other.Val){
            return 0;
        }
        else if(this.Val>=other.Val){
            return 1;
        }
        else{
            return -1;
        }
    }

    public bool Equals(Frazione? other)
    {
        if(this.Val == other.Val){
            return true;
        }
        else{
            return false;
        }

        
    }

    public static Frazione operator +(Frazione a) => a;
    public static Frazione operator -(Frazione a) => new Frazione(-a.N, a.N);

    public static Frazione operator +(Frazione a, Frazione b)=> new Frazione(a.N * b.D + b.N * a.D, a.D * b.D);

    public static Frazione operator -(Frazione a, Frazione b)
        => a + (-b);

    public static Frazione operator *(Frazione a, Frazione b)
        => new Frazione(a.N * b.N, a.D * b.D);

    public static Frazione operator /(Frazione a, Frazione b)
    {
        if (b.N == 0)
        {
            throw new DivideByZeroException();
        }
        return new Frazione(a.N * b.D, a.D * b.N);
    }

}