public class Quartos {
    public string Nome { get; private set; }
    public string Email { get; private set; }

    public Quartos (string nome, string email) {
        Nome = nome;
        Email = email;
    }

    public override string ToString() {
        return Nome + ", " + Email;
    }
}