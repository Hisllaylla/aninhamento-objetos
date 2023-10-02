namespace AninhamentoObjetos
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Idade { get; set; }
        public string Profissao { get; set; }
        public string EstadoCivil { get; set; }
        public string Documento { get; set; }
        public List<Endereco> ListaEndereco { get; set; }

        /* 

            get: É usado para obter (ou ler) o valor de uma propriedade. É um método que retorna o valor da propriedade quando acessada.
            set: É usado para definir (ou escrever) o valor de uma propriedade. É um método que permite atribuir um valor à propriedade quando a modifica.
        
            Neste exemplo, a classe Pessoa tem uma propriedade chamada Nome. O método get retorna o valor atual da propriedade, e o método set permite que um novo valor 
        seja atribuido à propriedade.

        */
    }
}