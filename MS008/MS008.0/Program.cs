Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

// A primeira linha de código cria uma instância da classe Random chamada dice.
// A segunda linha de código usa o método dice.Next(1, 7) para atribuir um valor aleatório a um número inteiro chamado roll.
// Observe que a instrução chamada fornece dois argumentos separados por um símbolo , (vírgula)
// O método Next() inclui uma assinatura de método que aceita dois parâmetros do tipo int. Esses parâmetros são usados para configurar os marcos de delimitação inferior e superior do número aleatório que é retornado.

// Os argumentos passados para um método devem ter o mesmo tipo de dados que os parâmetros correspondentes definidos pelo método.

// Console.WriteLine(dice.Next(1, 7));
//Em alguns casos, é possível usar o valor de retorno diretamente, sem atribuí-lo a uma variável.