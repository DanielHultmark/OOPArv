namespace OOPArv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat myCat = new Cat();
            myCat.Name = "Misse";
            myCat.Age = 3;
            myCat.Eat();
            myCat.Meow();

            Dog myDog = new Dog();
            myDog.Name = "Fido";
            myDog.Age = 5;
            myDog.Eat();

            
        }
    }
}
