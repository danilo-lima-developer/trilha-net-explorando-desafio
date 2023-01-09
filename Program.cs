using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Danilo", sobrenome: "Lima", funcao: "Desenvolvedor C#");
Pessoa p2 = new Pessoa(nome: "Augusto", sobrenome: "Melo", funcao: "Analista de Dados BI");
Pessoa p3 = new Pessoa(nome: "Manoel", sobrenome: "Juvenal", funcao: "Desenvolvedor C#");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 5, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 15);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
foreach(Pessoa item in hospedes){
    Console.WriteLine($"Nome: {item.NomeCompleto}" + $", Função: {item.Funcao}");
}
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria():C}");