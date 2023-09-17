var cliente = new Cliente
{
    Nome = "Jonathan",
    Idade = "30",
    Profissao = "Software Engineer",
    EstadoCivil = "casado",
    Documento = "12345678901"
};

cliente.ListaEndereco = new List<Endereco>();

var endereco1 = new Endereco
{
    Logradouro = "rua A",
    Numero = "224",
    Bairro = "paulicéia",
    Cidade = "cidade A",
    Estado = "sp"
};

cliente.ListaEndereco.Add(endereco1);

var endereco2 = new Endereco
{
    Logradouro = "rua B",
    Numero = "809",
    Bairro = "balneário",
    Cidade = "cidade b",
    Estado = "sc"
};

cliente.ListaEndereco.Add(endereco2);

var endereco3 = new Endereco
{
    Logradouro = "Rua C",
    Numero = "100",
    Bairro = "tupy",
    Cidade = "cidade c",
    Estado = "am"
};

cliente.ListaEndereco.Add(endereco3);

Console.WriteLine($"Oi, meu nome é {cliente.Nome}, tenho {cliente.Idade} anos e sou {cliente.Profissao}. Atualmente estou {cliente.EstadoCivil} e tenho {cliente.ListaEndereco.Count} endereços cadastrados.");
