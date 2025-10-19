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

            Console.WriteLine("Digite a placa do veículo para estacionar:");
            // IMPLEMENTADO!!
            string placa = Console.ReadLine() ?? ""; // Utilizei string placa = Console.ReadLine() ?? "", pois apartir das versões .NET8+ tem análise de nulidade mais estrita
            if (string.IsNullOrWhiteSpace(placa))
            {
                Console.WriteLine("Placa não pode ser Nula!");  // Em conjunto, empreguei uma condicional onde recuse valores nulos
                return;
            }
            
            veiculos.Add(placa);
            Console.WriteLine($"Veiculo {placa} registrado com sucesso");
            
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            // IMPLEMENTADO!!
            string placa = Console.ReadLine() ?? ""; // mesma logica utilizada na função 'AdicionarVeiculo'
            if(string.IsNullOrWhiteSpace(placa))
            {
                Console.WriteLine("Placa não pode ser Nula!"); // mesma logica utilizada na função 'AdicionarVeiculo'
                return;
            }
            Console.WriteLine($"Veiculo '{placa}' removido com sucesso!");

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // IMPLEMENTADO!!
                int horas = 0;
                decimal valorTotal = 0;
                horas = Convert.ToInt32(Console.ReadLine() ?? "0"); // Converte a string para um número inteiro e garante que nunca teremos null para o Convert.ToInt32()
                valorTotal = precoInicial + precoPorHora * horas; // Conforme solicitado, foi formulado o calculo "precoInicial + precoPorHora * horas" para a variável valorTotal

                // IMPLEMENTADO!!
                veiculos.Remove(placa); // Remove a placa digitada da lista de veículos
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
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
            Console.WriteLine("======================="); //Feita alteração para ficar mais organizado!!
            Console.WriteLine(" VEÍCULOS CADASTRADOS ");
            Console.WriteLine("=======================");

            int numero = 1;
                // IMPLEMENTADO!!
                foreach (var veiculo in veiculos) //Imprime todos os 'veículos' da registrados, um por linha
                {
                    Console.WriteLine($"║ {numero,2} |     {veiculo,-10} ║");
                    numero++;
                }
            Console.WriteLine("=======================");
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
     }
}
