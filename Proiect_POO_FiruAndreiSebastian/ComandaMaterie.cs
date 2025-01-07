namespace Proiect_POO_FiruAndreiSebastian
{
    public class ComandaMaterie
    {
        private static int _nextId = 1;
        public int Id { get; set; }
        public string Descriere { get; set; }
        public int CodUnic { get; set; }
        public StatusComandaMaterie Status { get; set; }

        public ComandaMaterie(string descriere, int codUnic)
        {
            Id = _nextId++;
            Descriere = descriere;
            CodUnic = codUnic;
            Status = StatusComandaMaterie.InAsteptare;
        }

        public override string ToString()
        {
            return $"Comanda materie {Id}: {Descriere}, Cod: {CodUnic}, Status: {Status}";
        }
    }
}