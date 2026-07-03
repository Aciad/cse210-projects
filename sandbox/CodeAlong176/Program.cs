namespace CodeAlong176;

class Program
{
    static void Main(string[] args)
    {
        List<Animal> myAnimals = new List<Animal> ();

        myAnimals.Add( new Animal("Liger"));
        myAnimals.Add( new Dog("Zorro"));
        myAnimals.Add( new Cat("Garfield"));
        myAnimals.Add( new Fox("Swiper"));
        foreach (Animal critter in myAnimals)
        {
            critter.MakeNoise();
        }
    }
}
