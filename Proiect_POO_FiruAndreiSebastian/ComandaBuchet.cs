namespace Proiect_POO_FiruAndreiSebastian
{
    public class ComandaBuchet
    {
        private static int _nextId = 1;
        public int Id { get; set; }
        public Client Client { get; set; }
        public string Descriere { get; set; }
        public string Telefon { get; set; }
        public StatusComandaBuchet Status { get; set; }
        public int? Review { get; set; }

        public ComandaBuchet(Client client, string descriere, string telefon)
        {
            Id = _nextId++;
            Client = client;
            Descriere = descriere;
            Telefon = telefon;
            Status = StatusComandaBuchet.InPreluare;
        }

        public override string ToString()
        {
            return $"Comanda buchet {Id}: {Descriere}, Telefon: {Telefon}, Status: {Status}";
        }
    }
}