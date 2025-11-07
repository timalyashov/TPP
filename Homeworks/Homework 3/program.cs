using System;

class Polynomial
{
    private int degree;
    private double[] coefs;

    public Polynomial()
    {
        degree = 0;
        coefs = new double[1] { 0.0 };
    }

    public Polynomial(double[] new_coefs)
    {
        degree = new_coefs.Length - 1;
        coefs = (double[])new_coefs.Clone();
    }

    public int Degree
    {
        get { return degree; }
    }

    public double[] Coeffs
    {
        get { return (double[])coefs.Clone(); }
    }

    public override string ToString()
    {
        if (this.coefs.Length == 0){return "0";}
        string res = "";
        for (int i = 0; i < this.coefs.Length; i++)
        {
            if (this.coefs[i] == 0){continue;}
            if (i == 0){res += this.coefs[i];}
            else if (i == 1)
            {
                res += this.coefs[i] < 0 ? "-":"+";
                res += Math.Abs(this.coefs[i]).ToString() + "x";
            }
            else 
            {
                res += this.coefs[i] < 0 ? "-":"+";
                res += Math.Abs(this.coefs[i]).ToString() + "x^" + i;
            }
        }
        return res;
    }
}

class Programm
{
    static void Main(string[] args)
    {
        double[] coeffs = { 1.0, 0.0, 2.0 };
        Polynomial p = new Polynomial(coeffs); // 1 + 2x^2

        Console.WriteLine(p);
    }
}
