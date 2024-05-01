using ProjetoHospedagemHotel.Models;

List <Pessoa> hospedes = new List<Pessoa>();

Console.WriteLine("A reserva será para quantos hospedes? ");
int quantidadeHospedes = Convert.ToInt32(Console.ReadLine());

for (int x = 1; x <= quantidadeHospedes; x++)
{
    Console.WriteLine($"Nome do {x}° hospede: ");
    Pessoa pessoa = new Pessoa(Console.ReadLine());
    hospedes.Add(pessoa);

}

Suite suite = new Suite();
Console.WriteLine();
Console.WriteLine("Tipo da suite: ");
suite.TipoSuite = Console.ReadLine();
Console.WriteLine("Capacidade: ");
suite.Capacidade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Valor da diaria: ");
suite.ValorDiaria  = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Será reserva para quantos dias: ");
Reserva reserva = new Reserva(Convert.ToInt32(Console.ReadLine()));

reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hospedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor da diária: {reserva.CalcularValorDiaria()}");