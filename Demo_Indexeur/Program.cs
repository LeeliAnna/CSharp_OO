using Demo_Indexeur.Models;

namespace Demo_Indexeur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - Créé un personnage
            Personnage MatouCar = new Personnage()
            {
                Nom = "MatouCar",
                Taille = 12,
            };

            //// 2 - Equipements
            ////if(MatouCar.Equipements is null) MatouCar.Equipements = new List<Equipement>(); 
            //Equipement DistributeurCroquette = new Equipement() { Nom = "Krokettor", Couleur = "Brun", Puissance = 1 };
            //Equipement Santiac = new Equipement() { Nom = "Bottes enchantées", Couleur = "Violet", Puissance = 6 };
            //Equipement Fleuret = new Equipement() { Nom = "ExCatlibur", Couleur = "Argent", Puissance = 12 };

            //// 3 - Associer l'équipemùent à notre personnage
            //// Version classique
            //MatouCar.Equipements.Add(DistributeurCroquette);
            //MatouCar.Equipements.Add(Santiac);
            //MatouCar.Equipements.Add(Fleuret);

            ////Afficher tous les equipements
            //Console.WriteLine($"Mon personage {MatouCar} possède :");
            //foreach (Equipement item in MatouCar.Equipements)
            //{
            //    Console.WriteLine($"Equipement : { item.Nom} - Couleur : {item.Couleur} - Puissance : {item.Puissance}");
            //}

            ////Rechercher les bottes?
            //MatouCar.Equipements[1].Couleur = "Magenta";

            //Version intermédiaire pour faciliter la vie

            //MatouCar.Equipements["DistributeurCroquette"] = DistributeurCroquette;

            // Version Indexeur

            Equipement DistributeurCroquette = new Equipement() { Nom = "Krokettor", Couleur = "Brun", Puissance = 1 };
            Equipement Santiac = new Equipement() { Nom = "Bottes enchantées", Couleur = "Violet", Puissance = 6 };
            Equipement Fleuret = new Equipement() { Nom = "ExCatlibur", Couleur = "Argent", Puissance = 12 };

            MatouCar["Nouriture"] = DistributeurCroquette;
            MatouCar["Pied"] = Santiac;
            MatouCar["Main"] = Fleuret;


            // Rechercher les bottes
            MatouCar["Pied"].Couleur = "Pourpre";

            int PuissanceTotale = DistributeurCroquette + Santiac + Fleuret;


        }
    }
}
