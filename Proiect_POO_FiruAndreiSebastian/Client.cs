namespace Proiect_POO_FiruAndreiSebastian
{
    public class Client : Utilizator
    {
        public List<ComandaBuchet> Comenzi { get; set; } = new List<ComandaBuchet>();

        public Client(int cod, string nume, string email, string parola) : base(cod, nume, email, parola) { }

        public void ComandaBuchet(string descriere, string telefon)
        {
            if (telefon.Length != 10 || !long.TryParse(telefon, out _))
            {
                Console.WriteLine("Numar de telefon invalid!");
                return;
            }

            var comanda = new ComandaBuchet(this, descriere, telefon);
            Comenzi.Add(comanda);
            Console.WriteLine("Comanda pentru buchet a fost plasata.");
        }

        public void VizualizareIstoricComenzi()
        {
            foreach (var comanda in Comenzi)
            {
                Console.WriteLine(comanda);
            }
        }

        public void VizualizareDetaliiComanda(int comandaId)
        {
            var comanda = Comenzi.Find(c => c.Id == comandaId);
            if (comanda != null)
            {
                Console.WriteLine(comanda);
            }
            else
            {
                Console.WriteLine("Comanda nu a fost gasita.");
            }
        }

        public void RidicareComanda(int comandaId)
        {
            var comanda = Comenzi.Find(c => c.Id == comandaId && c.Status == StatusComandaBuchet.Finalizat);
            if (comanda != null)
            {
                comanda.Status = StatusComandaBuchet.Revendicat;
                Console.WriteLine("Comanda a fost ridicata.");
            }
            else
            {
                Console.WriteLine("Comanda nu poate fi ridicata.");
            }
        }

        public void ReviewComanda(int comandaId, int stele)
        {
            var comanda = Comenzi.Find(c => c.Id == comandaId && c.Status == StatusComandaBuchet.Revendicat);
            if (comanda != null)
            {
                comanda.Review = stele;
                Console.WriteLine($"Review adaugat pentru comanda {comandaId} cu {stele} stele.");
            }
            else
            {
                Console.WriteLine("Comanda nu poate primi review.");
            }
        }
    }
}
   