namespace Proiect_POO_FiruAndreiSebastian
{
    public class Angajat : Utilizator
    {
        public List<ComandaMaterie> ComenziMaterie { get; set; } = new List<ComandaMaterie>();
        public List<ComandaBuchet> ComenziBuchete { get; set; } = new List<ComandaBuchet>();

        public Angajat(int cod, string nume, string email, string parola) : base(cod, nume, email, parola) { }

        public void VizualizareComenziClienti()
        {
            foreach (var comanda in ComenziBuchete)
            {
                Console.WriteLine(comanda);
            }
        }

        public void ComandaMaterie(string descriere, int codUnic)
        {
            var comandaMaterie = new ComandaMaterie(descriere, codUnic);
            ComenziMaterie.Add(comandaMaterie);
            Console.WriteLine("Comanda de materie a fost plasata.");
        }

        public void PreluareMaterie(int comandaMaterieId)
        {
            var comanda = ComenziMaterie.Find(c => c.Id == comandaMaterieId && c.Status == StatusComandaMaterie.Finalizat);
            if (comanda != null)
            {
                Console.WriteLine("Materie preluata pentru comanda.");
            }
            else
            {
                Console.WriteLine("Comanda de materie nu este finalizata.");
            }
        }
    }
}
