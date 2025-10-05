namespace OOPArv
{
    internal class Program
    {
        static void Main(string[] args)
        //Här skapar vi de nya djuren och anropar deras metod MakeSound
        {
            Cat myCat = new Cat(name: "Whiskers", sound: "Meow", age: 4);
            myCat.MakeSound();

            Dog myDog = new Dog(name: "Fido", sound: "woof", age: 5);             
            myDog.MakeSound();

            Horse myHorse = new Horse(name: "Pelle", sound: "Gneeg", age: 8);
            myHorse.MakeSound();

            CaneCorso myCaneCorso = new CaneCorso(name: "Brutus", sound: "woof", age: 3);            
            myCaneCorso.MakeSound();

            Tax myTax = new Tax(name: "Rex", sound: "woof", age: 1);            
            myTax.MakeSound();
        }
    }
}
