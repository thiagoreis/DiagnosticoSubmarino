# Diagnóstico Submarino

lê uma lista de números binários representando diagnósticos de um submarino. Calcula:
- **Taxa Gama**: Bit mais comum por posição.
- **Taxa Épsilon**: Bit menos comum por posição (inverso da Gama).
para definir o consumo de energia ( multiplicação dos dois valores em decimal.)

## Tecnologias
- C#
- .NET 8
- xUnit (Testes)

## Padrões de Projeto utilizados 
- Strategy: Permite trocar ou adicionar novos critérios de cálculo.
- Service Layer: Centraliza a lógica de diagnóstico.
- Repository (Simples): Preparado para ler dados de diferentes fontes (lista, arquivo, API).


## Execução
Execute via terminal:

```bash
dotnet run
dotnet test .\tests\DiagnosticoSubmarino.Tests\DiagnosticoSubmarino.Tests.csproj

