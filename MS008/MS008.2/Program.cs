Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

/* 
- A primeira versão do método Next() não define um limite superior e inferior; portanto, o método retornará valores que variam de 0 a 2,147,483,647, que é o valor máximo que um int pode armazenar.

- A segunda versão do método Next() especifica o valor máximo como um limite superior, portanto, nesse caso, espere um valor aleatório entre 0 e 100.

-  terceira versão do método Next() especifica os valores mínimo e máximo. Portanto, nesse caso, é possível esperar um valor aleatório entre 50 e 100.
*/