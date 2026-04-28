# CursoLinq

Este projeto é um exemplo prático de uso do LINQ (Language Integrated Query) em C# para manipulação de dados em aplicações .NET. Ele demonstra como realizar consultas, filtragens, projeções e outras operações utilizando LINQ sobre coleções e entidades de um modelo de dados.

## Estrutura do Projeto

- **Program.cs**: Ponto de entrada da aplicação, onde são realizados os testes e exemplos de uso do LINQ.
- **repositorio/**: Contém as classes de modelo e o contexto do Entity Framework:
  - `Categoria.cs`: Modelo de categoria de produtos.
  - `Produtos.cs`: Modelo de produto.
  - `LojaModel.Context.cs` e arquivos relacionados: Contexto do Entity Framework para acesso ao banco de dados.

## Pré-requisitos

- .NET Framework 4.5 ou superior
- Visual Studio 2015 ou superior
- Entity Framework (instalado via NuGet)

## Como Executar

1. Abra a solução `CursoLinq.sln` no Visual Studio.
2. Restaure os pacotes NuGet se necessário.
3. Compile a solução.
4. Execute o projeto (F5 ou Ctrl+F5).

## Funcionalidades Demonstradas

- Consultas simples e compostas com LINQ
- Projeções e seleções de dados
- Filtros e ordenações
- Uso de métodos de extensão LINQ
- Integração com Entity Framework para acesso a banco de dados

## Observações

- O projeto utiliza um modelo de dados simples para fins didáticos.
- O banco de dados pode ser gerado automaticamente pelo Entity Framework na primeira execução, conforme a configuração do contexto.

## Licença

Este projeto é livre para uso educacional.
