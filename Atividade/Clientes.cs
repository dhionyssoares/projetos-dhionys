namespace Atividade
{
    class Clientes
    {
        public string Nome {get; set;}        
        public string Endereço {get; set;}        
        public float ValorPago {get; protected set;}                
        public float Imposto {get; protected set;}        
        public float Total {get; protected set;}
        
        public virtual void PagarImposto(float valor){
            this.ValorPago = valor;
            this.Imposto = valor * 10/100;
            Total = ValorPago + Imposto;
        }
    }
}