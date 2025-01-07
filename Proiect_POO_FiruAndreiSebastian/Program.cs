namespace Proiect_POO_FiruAndreiSebastian
{
    class Program
    {
        static List<Utilizator> utilizatori = new List<Utilizator>();
        static Utilizator utilizatorAutentificat = null;

        static void Main(string[] args)
        {
            utilizatori.Add(new Angajat(1, "Andrei Firu", "andreifiru1@gmail.com", "244466666"));
            utilizatori.Add(new Client(2, "Maria Ionescu", "mariaionescu@outlook.com", "parola321"));
            utilizatori.Add(new Client(3, "George Vasilescu", "georgevasilescu@gmail.ro", "parola123"));

            Console.WriteLine("Bun venit la Floraria lui Andrei!");

            while (true)
            {
                if (utilizatorAutentificat == null)
                {
                    Console.WriteLine("1. Logare");
                    Console.WriteLine("2. Iesire");
                    int optiune = int.Parse(Console.ReadLine());

                    if (optiune == 1)
                    {
                        Logare();
                    }
                    else if (optiune == 2)
                    {
                        break;
                    }
                }
                else
                {
                    // Meniu in functie de rolul utilizatorului
                    if (utilizatorAutentificat is Angajat)
                    {
                        MeniuAngajat();
                    }
                    else if (utilizatorAutentificat is Client)
                    {
                        MeniuClient();
                    }
                }
            }
        }

        static void Logare()
        {
            Console.WriteLine("Introduceti email-ul:");
            string email = Console.ReadLine();
            Console.WriteLine("Introduceti parola:");
            string parola = Console.ReadLine();

            utilizatorAutentificat = utilizatori.Find(u => u.Email == email && u.Parola == parola);

            if (utilizatorAutentificat != null)
            {
                Console.WriteLine($"Bine ati venit, {utilizatorAutentificat.NumeComplet}!");
            }
            else
            {
                Console.WriteLine("Email sau parola invalide!");
            }
        }

        static void MeniuAngajat()
        {
            Console.WriteLine("1. Vizualizare comenzi clienti");
            Console.WriteLine("2. Comanda materie");
            Console.WriteLine("3. Preluare materie");
            int optiune = int.Parse(Console.ReadLine());

            switch (optiune)
            {
                case 1:
                    ((Angajat)utilizatorAutentificat).VizualizareComenziClienti();
                    break;
                case 2:
                    Console.WriteLine("Introduceti descrierea materiei:");
                    string descriere = Console.ReadLine();
                    Console.WriteLine("Introduceti codul unic al materiei:");
                    int codUnic = int.Parse(Console.ReadLine());
                    ((Angajat)utilizatorAutentificat).ComandaMaterie(descriere, codUnic);
                    break;
                case 3:
                    Console.WriteLine("Introduceti ID-ul comenzii de materie:");
                    int idMaterie = int.Parse(Console.ReadLine());
                    ((Angajat)utilizatorAutentificat).PreluareMaterie(idMaterie);
                    break;
            }
        }

        static void MeniuClient()
        {
            Console.WriteLine("1. Plasare comanda buchet");
            Console.WriteLine("2. Vizualizare istoric comenzi");
            Console.WriteLine("3. Vizualizare detalii comanda");
            Console.WriteLine("4. Ridicare comanda");
            Console.WriteLine("5. Review comanda");
            int optiune = int.Parse(Console.ReadLine());

            switch (optiune)
            {
                case 1:
                    Console.WriteLine("Introduceti descrierea buchetului:");
                    string descriereBuchet = Console.ReadLine();
                    Console.WriteLine("Introduceti numarul de telefon:");
                    string telefon = Console.ReadLine();
                    ((Client)utilizatorAutentificat).ComandaBuchet(descriereBuchet, telefon);
                    break;
                case 2:
                    ((Client)utilizatorAutentificat).VizualizareIstoricComenzi();
                    break;
                case 3:
                    Console.WriteLine("Introduceti ID-ul comenzii:");
                    int idComanda = int.Parse(Console.ReadLine());
                    ((Client)utilizatorAutentificat).VizualizareDetaliiComanda(idComanda);
                    break;
                case 4:
                    Console.WriteLine("Introduceti ID-ul comenzii:");
                    int idRidicare = int.Parse(Console.ReadLine());
                    ((Client)utilizatorAutentificat).RidicareComanda(idRidicare);
                    break;
                case 5:
                    Console.WriteLine("Introduceti ID-ul comenzii:");
                    int idReview = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduceti numarul de stele (1-5):");
                    int stele = int.Parse(Console.ReadLine());
                    ((Client)utilizatorAutentificat).ReviewComanda(idReview, stele);
                    break;
            }
        }
    }
}

