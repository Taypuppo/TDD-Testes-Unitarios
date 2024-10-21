using System.Collections;
using Calculadora;

namespace test;

public class CalculadoraTest
{
    private CalculadoraImp _calc;

    public CalculadoraTest()
    {
        _calc = new CalculadoraImp();
    }

    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void TesteSomar(int num1, int num2, int resultado)
    {
        int resultadoCalculadora = _calc.Somar(num1, num2);

        Assert.Equal(resultadoCalculadora, resultado);
    }


    [Theory]
    [InlineData (6, 2, 4)]
    [InlineData (5, 4, 1)]
    public void TesteSubtrair(int num1, int num2, int resultado)
    {

        int resultadoCalculadora = _calc.Subtrair(num1, num2);

        Assert.Equal(resultadoCalculadora, resultado);
    }

    [Theory]
    [InlineData (1, 2, 2)]
    [InlineData (4, 5, 20)]
    public void TesteMultiplicar(int num1, int num2, int resultado)
    {

        int resultadoCalculadora = _calc.Multiplicar(num1, num2);

        Assert.Equal(resultadoCalculadora, resultado);
    }


    [Theory]
    [InlineData (6, 2, 3)]
    [InlineData (5, 5, 1)]
    public void TesteDividir(int num1, int num2, int resultado)
    {

        int resultadoCalculadora = _calc.Dividir(num1, num2);

        Assert.Equal(resultadoCalculadora, resultado);
    }


    [Fact]
    public void TestarDivisaoPorZero()
    {
        Assert.Throws<DivideByZeroException>(() => _calc.Dividir(3,0));
    }

    [Fact]
    public void TestarHistorico()
    {
        _calc.Somar(1,2);
        _calc.Somar(2,8);
        _calc.Somar(3,7);
        _calc.Somar(4,1);

        var lista = _calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }

    
}