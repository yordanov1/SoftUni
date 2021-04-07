using System;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dog sharo = new Dog();
            sharo.Eat();
            sharo.Bark();

            Puppy lover = new Puppy();
            lover.Weep();
        }
    }
}
