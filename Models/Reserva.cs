namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
          
            if ( Suite == null)
            {   
                throw new Exception("Cadastre uma suite ");
            }
            if ( Suite.Capacidade >= hospedes.Count ){
                Hospedes = hospedes;
                Console.WriteLine("Hospede cadastrado!!");
            }
            else
            {
               throw new Exception($"Capacidade Maxima excedida. O local so suporta {Suite.Capacidade} hospedes, mas voce digitou {hospedes.Count}");
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
              
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
         
        
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiario
            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
           
            if (Suite == null)
            {
                throw new Exception ("Cadestre uma suite para calcularmos o valor da diaria");
             
            }
            decimal valor = DiasReservados * Suite.ValorDiaria;
            if(DiasReservados >= 10){
                decimal desconto = valor * 0.10M;
                valor -= desconto;
                Console.WriteLine("Desconto deu certto");
            }


            return valor;
        }
    }
}