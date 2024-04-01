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
            int capacidadeMaxima = 100; 

    
            if (hospedes.Count <= capacidadeMaxima)
            {
                Hospedes = hospedes;
            }
            else
            {
        
                throw new Exception("Capacidade máxima de hóspedes excedida.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valorDiaria = Suite.ValorDiaria;

    
            int diasReservados = DiasReservados;

         decimal valor = diasReservados * valorDiaria;

    
            if (diasReservados >= 10)
            {
                 decimal desconto = valor * 0.1m; 
                 valor -= desconto;
            }

            return valor;
        }
    }
}