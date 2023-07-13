namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome, endereço, tipo = "", cpf, rg, cnpj, ie;
            float valor;

            while (tipo != "f" && tipo != "F" && tipo != "j" && tipo != "J")
            {
                Console.WriteLine("você é pessoa física ou jurídica? Digite f para pessoa física ou j para pessoa jurídica.");
                tipo = Console.ReadLine();
            };
            if (tipo == "f" || tipo == "F")
            {
                Console.WriteLine("nome:");
                nome = Console.ReadLine();
                Console.WriteLine("endereço:");
                endereço = Console.ReadLine();
                Console.WriteLine("CPF:");
                cpf = Console.ReadLine();
                Console.WriteLine("RG:");
                rg = Console.ReadLine();
                Console.WriteLine("valor pago:");
                valor = float.Parse(Console.ReadLine());

                PessoaFísica pf = new PessoaFísica();
                pf.Nome = nome;
                pf.Endereço = endereço;
                pf.CPF = cpf;
                pf.RG = rg;
                pf.PagarImposto(valor);

                Console.WriteLine(pf.ToString());
            }

            else if (tipo == "j" || tipo == "J")
            {
                Console.WriteLine("nome da empresa:");
                nome = Console.ReadLine();
                Console.WriteLine("endereço:");
                endereço = Console.ReadLine(); Console.WriteLine("CNPJ:");
                cnpj = Console.ReadLine();
                Console.WriteLine("IE:");
                ie = Console.ReadLine();
                Console.WriteLine("valor pago:");
                valor = float.Parse(Console.ReadLine());

                PessoaJurídica pj = new PessoaJurídica();
                pj.Nome = nome;
                pj.Endereço = endereço;
                pj.CNPJ = cnpj;
                pj.IE = ie;
                pj.PagarImposto(valor);

                Console.WriteLine(pj.ToString());
            }
        }
    }
}