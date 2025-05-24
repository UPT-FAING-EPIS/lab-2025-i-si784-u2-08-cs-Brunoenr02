namespace Calculator.Domain;

/// <summary>
/// Clase que realiza operaciones aritméticas básicas.
/// </summary>
public class Calculator
{
    /// <summary>
    /// Suma dos números enteros.
    /// </summary>
    /// <param name="x">Primer sumando</param>
    /// <param name="y">Segundo sumando</param>
    /// <returns>La suma de x e y</returns>
    public int Add(int x, int y) => x + y;
    /// <summary>
    /// Resta dos números enteros.
    /// </summary>
    /// <param name="x">Minuendo</param>
    /// <param name="y">Sustraendo</param>
    /// <returns>La resta de x menos y</returns>
    public int Subtract(int x, int y) => x - y;
    /// <summary>
    /// Multiplica dos números enteros.
    /// </summary>
    /// <param name="x">Primer factor</param>
    /// <param name="y">Segundo factor</param>
    /// <returns>El producto de x e y</returns>
    public int Multiply(int x, int y) => x * y;
    /// <summary>
    /// Divide dos números enteros.
    /// </summary>
    /// <param name="x">Dividendo</param>
    /// <param name="y">Divisor</param>
    /// <returns>El cociente de x entre y</returns>
    public int Divide(int x, int y) => x / y;
}