using ExemplosFinais.Models;
using Newtonsoft.Json;

// TIPOS ESPECIAIS , PODE USAR NULL EM TIPOS DE ENTRADAS
decimal? desconto = null;
VendaDois v1 = new VendaDois(1,"teste",22.10M,desconto);

string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);

File.WriteAllText("Arquivos/venda.json",serializado);

bool? confirmaEmail = null;

if (confirmaEmail.HasValue && confirmaEmail.Value) { 
    Console.WriteLine("oPTOU POR RECEBER O EMAIL");
}else { 
    Console.WriteLine("oPTOU POR NÃO RECEBER O EMAIL OU NÃO RESPONDEU AINDA");
}

// VALORES DE TIPOS ANONIMOS


var tipoAnonimo = new { Nome = "Jaylan", Sobrenome = "Esquivel", Briday = 27};

Console.WriteLine($"Nome: {tipoAnonimo.Nome} Sobrenome: {tipoAnonimo.Sobrenome} Niver: {tipoAnonimo.Briday}");


// TIPO DINAMICO

Console.WriteLine("______________________________________________________");

dynamic valorDinamico = 1.22M;

Console.WriteLine($"Tipo: {valorDinamico.GetType()}, valor: {valorDinamico}");

// CLASSES GENERICAS
Console.WriteLine("______________________________________________________");

MeuArray<int> arrayInteiros = new MeuArray<int>();
arrayInteiros.AdicionarElementoArray(30);
Console.WriteLine(arrayInteiros[0]);

MeuArray<string> arrayString = new MeuArray<string>();
arrayString.AdicionarElementoArray("TESTES");
Console.WriteLine(arrayString[0]);

// METODOS DE EXTENSOES
Console.WriteLine("______________________________________________________");

    int num = 1;
    bool ehpar = false;
    ehpar = num.EhPah();
    Console.WriteLine($"o numero {num} é "+ (ehpar ? "par" : "Impar"));