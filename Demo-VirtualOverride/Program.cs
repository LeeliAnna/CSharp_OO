using Demo_VirtualOverride.Models;

namespace Demo_VirtualOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal opossum = new WalkingAnimal("Ellie");
            //Console.WriteLine(opossum.ToString());
            //opossum.SeDeplacer();

            //Console.WriteLine();

            //Animal clown = new SwimmingAnimal("Némo");
            //Console.WriteLine(clown);
            //clown.SeDeplacer();

            //Console.WriteLine();

            //Animal serpent = new Animal("Kaha");
            //Console.WriteLine(serpent);
            //serpent.SeDeplacer();

            List<Animal> zoo = new List<Animal>()
            {
                new WalkingAnimal("Ellie"),
                new SwimmingAnimal("Némo"),
                new Animal("Kaha")
            };

            foreach (Animal a in zoo) 
            {
                Console.WriteLine(a);
                a.SeDeplacer();
                Console.WriteLine();
            }

        }
    }
}
