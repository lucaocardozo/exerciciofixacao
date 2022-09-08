

namespace Vetores_Exercicio_Pensionato {
    class Quarto {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Quarto(string nome, string email) {
            Nome = nome;
            Email = email;
        }
        public override string ToString() {
            return "Nome: " + Nome + " Email: " + Email;
        }
    }
}
