# Calculadora

Este projeto é uma implementação simples de uma calculadora em C#. A classe `CalculadoraImp` fornece operações básicas, como adição, subtração, multiplicação e divisão, além de um histórico das operações realizadas.

## Funcionalidades

- **Somar**: Adiciona dois números e registra o resultado no histórico.
- **Subtrair**: Subtrai o segundo número do primeiro e registra o resultado no histórico.
- **Multiplicar**: Multiplica dois números e registra o resultado no histórico.
- **Dividir**: Divide o primeiro número pelo segundo e registra o resultado no histórico, com tratamento para divisão por zero.
- **Histórico**: Mantém um registro das últimas três operações realizadas.

## TESTES
Os testes foram implementados seguindo a abordagem TDD (Test-Driven Development) e utilizam o framework xUnit para testes unitários. A classe CalculadoraTest verifica a funcionalidade das operações e o gerenciamento do histórico.

## Estrutura do Código

### CalculadoraImp

A classe `CalculadoraImp` contém os métodos para realizar as operações e gerenciar o histórico:

```csharp
public class CalculadoraImp
{
    // Métodos:
    public int Somar(int num1, int num2);
    public int Subtrair(int num1, int num2);
    public int Multiplicar(int num1, int num2);
    public int Dividir(int num1, int num2);
    public List<string> Historico();
}
