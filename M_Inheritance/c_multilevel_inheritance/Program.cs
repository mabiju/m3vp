﻿namespace c_multilevel_inheritance;

class GrandFather
{
    public void grandDad()
    {
        Console.WriteLine("This is grand dad.");
    }
}

class Father : GrandFather
{
    public void dad()
    {
        Console.WriteLine("This is dad.");
    }
}

class Child : Father
{
    public void child()
    {
        Console.WriteLine("This is child.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Child c1 = new Child();
        c1.grandDad();
        c1.dad();
        c1.child();
    }
}
