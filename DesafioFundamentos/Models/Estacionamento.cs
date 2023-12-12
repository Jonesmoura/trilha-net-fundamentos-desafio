namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.Write("Digite a placa do veículo para estacionar: ");
            string placa = Console.ReadLine();
            while(!ValidacaoDeDados.ValidacaoDePlaca(placa))
            {
                Console.Write("Formato de placa inválido, favor inserir a placa no Formato AAA-0000: ");
                placa = Console.ReadLine();
            }
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.Write("Digite a placa do veículo para remover: ");

            string placa = "";
            placa = Console.ReadLine();
            while(!ValidacaoDeDados.ValidacaoDePlaca(placa)){
                Console.Write("Formato de placa inválido, favor inserir a placa no Formato AAA-0000: ");
                placa = Console.ReadLine();
            }

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {

                Console.Write("Digite a quantidade de horas que o veículo ficou estacionado: ");
                bool horasValidas = int.TryParse(Console.ReadLine(), out int horas);
                while (!horasValidas || horas < 0)
                {
                    Console.WriteLine("Valor inválido, favor informar um número inteiro maior que 0: ");
                    horasValidas = int.TryParse(Console.ReadLine(), out horas);
                }
                decimal valorTotal = precoInicial + precoPorHora * horas;
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                veiculos.Remove(placa);
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }
        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
