namespace Atividade
{
    class PessoaJurídica : Clientes
    {
        public string CNPJ {get; set;}
        public string IE {get; set;}

        public override void PagarImposto(float valor){
            this.ValorPago = valor;
            this.Imposto = valor * 20/100;
            Total = ValorPago + Imposto;
        }

        public override string ToString()
        {
            return "\n-----Pessoa Jurídica-----\n\n"
            + "Nome:----- " + Nome+"\n"
            + "Endereço:----- " + Endereço+"\n"
            + "CNPJ:----- " + CNPJ+"\n"
            + "IE:----- " + IE+"\n"
            + "Valor Pago:----- " + ValorPago.ToString("C")+"\n"
            + "Valor Imposto:----- " + Imposto.ToString("C")+"\n"
            + "Total a pagar:----- " + Total.ToString("C");
        }
    }
}