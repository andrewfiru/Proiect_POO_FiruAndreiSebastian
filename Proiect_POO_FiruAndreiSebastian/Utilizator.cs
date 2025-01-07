namespace Proiect_POO_FiruAndreiSebastian;

public class Utilizator
{
    public int Cod  { get; set; }
    public string NumeComplet  { get; set; }
    public string Email  { get; set; }
    public string Parola  { get; set; }

    public Utilizator(int cod, string numeComplet, string email, string parola)
    {
        Cod = cod;
        NumeComplet = numeComplet;
        Email = email;
        Parola = parola;
    }
}