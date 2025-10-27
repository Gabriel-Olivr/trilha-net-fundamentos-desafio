# Sistema de Estacionamento — Desafio Fundamentos

## Descrição Geral

Projeto de sistema de estacionamento desenvolvido em C#.
O sistema permite cadastrar, remover e listar veículos, calculando o valor total com base no preço inicial e preço por hora.

## Arquivo de Projeto (.csproj)

O arquivo de configuração do projeto (.csproj) foi modificado para atualizar a versão do .NET e ajustar as configurações de nulidade.

**•** Atualização do Target Framework (net6.0 → net9.0)

**•** Ativação da Análise de Nulidade (Nullable → enable)

## Arquivo Principal (Program.cs)


**exibirMenu:** Feita alteração para formatar a caixa do menu assim demonstrando o mesmo de maneira mais organizada e agradável aos olhos.


## Classe Estacionamento (Estacionamento.cs)

### 1 Método AdicionarVeiculo(): Nesta subclasse foi realizada as seguintes alterações:

  **1.1 'string placa = Console.ReadLine() ?? ""':** Utilizei , pois a partir das versões .NET 8+ há análise de nulidade mais estrita.

  **1.2 'if(string.IsNullOrWhiteSpace(placa))':** Em conjunto empreguei uma condicional para recusar valores nulos.



### 2 Método RemoverVeiculo(): Nesta subclasse foi realizada as seguintes alterações:


  **2.1 Método 'RemoverVeiculo()':** Utilizei a mesma lógica da função 'AdicionarVeiculo'.

  **2.2 'Console.ReadLine() ?? ""':** Garante que nunca teremos valor null na conversão. Mesma lógica utilizada na função AdicionarVeiculo.

  **2.3 'Convert.ToInt32':** Converte a string para um número inteiro e garante que nunca teremos null.

  **2.4 'valorTotal = precoInicial + precoPorHora * horas':** Conforme solicitado, foi formulado o cálculo (precoInicial + precoPorHora * horas) para a variável 'valorTotal'.

  **2.5 'veiculos.Remove(placa)':** Remove a placa digitada da lista de veículos.



### 3 Método ListarVeiculos(): Nesta subclasse foi realizada as seguintes alterações:
 Feita alteração no Console.WriteLine, seguindo a ideia da Classe 'Program.cs', para demonstrar o menu de maneira mais organizada e agradável.

  **3.1 Variável numero:** Utilizado comoo contador para numerar os veículos (1, 2, 3...).

  **3.2 Loop foreach:** Itera sobre cada veículo na lista veiculos, basicamente Imprime todos os 'veículos' da registrados, um por linha.

  **3.3 Formatação de string::** Tanto '{numero,2}' quanto '{veiculo,-10}', foi utilizado para alinhamento da tabela. Por fim 'numero++' aplicado como instrução fundamental que aumenta o contador cada vez que um veículo é processado, permitindo uma listagem ordenada dos veículos cadastrados no console.


