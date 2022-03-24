namespace InfraComanda.Domain{
    public class Cliente: EntityBase
    {
        

        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? Cep  { get; set; }
        public string? Estado { get; set; }
        public string? Cidade  { get; set; }

        
    }
}