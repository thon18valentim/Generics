using Generics;

// Exemplo de aplicação com classe sem generics
Console.WriteLine(Compare.Equal("othon", "aluno"));
Console.WriteLine(Compare.Equal(2.5, 2.5));
Console.WriteLine(Compare.Equal(7, 7));

// Resultado esperado
// false - true - true

Console.WriteLine("\n-----------------\n");

// Exemplo de aplicação com classe com generics
Console.WriteLine(CompareObjects.Equal("othon", "othon"));
Console.WriteLine(CompareObjects.Equal(2.5, 2.4));
Console.WriteLine(CompareObjects.Equal(3, 5));
Console.WriteLine(CompareObjects.Equal(5M, 5M));

// Resultado esperado
// true - false - false - true
