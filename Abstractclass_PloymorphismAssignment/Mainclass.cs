using System;
abstract class Phone
{ 
    public abstract void Show();
}
class Iphone : Phone
{
    public override void Show()
    {
        Console.WriteLine("Good !");
    }
}
class Vivo : Phone
{
    public override void Show()
    {
        Console.WriteLine("Only for Speak!");
    }
}
class Oneplus : Phone
{
    public override void Show()
    {
        Console.WriteLine("Camera Quality!");
    }
}
class MainClass
{
    static void Main()
    {
        Phone[] s = new Phone[3];
        s[0] = new Iphone();
        s[1] = new Vivo();
        s[2] = new Oneplus();
        foreach (Phone data in s)
        {
            data.Show();
        }
    }
}