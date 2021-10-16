using System;

sealed public class Animal
{
    public void eat() { Console.WriteLine("eating..."); }
}
public class Dog : Animal //NOT ALLOWED
{
    public void bark() { Console.WriteLine("barking..."); }
}
public class TestSealed
{
    public static void Main()
    {
        Dog d = new Dog();
        d.eat(); //NOT ALLOWED
        d.bark();
    }
}