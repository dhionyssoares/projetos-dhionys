namespace Atividade
{
    class PessoaFísica : Clientes {             
       
        public string CPF{ get; set;}
        public string RG{ get; set;}

       

        public override string ToString()
        {
            return "\n-----Pessoa Física-----\n\n"
            + "Nome:----- " + Nome+"\n"
            + "Endereço:----- " + Endereço+"\n"
            + "CPF:----- " + CPF+"\n"
            + "RG:----- " + RG+"\n"
            + "Valor Pago:----- " + ValorPago.ToString("C")+"\n"
            + "Valor Imposto:----- " + Imposto.ToString("C")+"\n"
            + "Total a pagar:----- " + Total.ToString("C");
        }

    }
}