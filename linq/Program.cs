int[] ages = { 1, 4, 9, 11, 10, 35 };

// Query Expression Syntax 
// (execução adiada, maior performance, pois consigo trazer apenas os dados que eu quero, tudo junto)
var queryExpressionResult = from number in ages
                            where number < 10
                            select number;
Console.WriteLine(string.Join(", ", queryExpressionResult)); // 1, 4, 9 

// Lambda Expression Syntax (execução imediata)
var lambdaResult = ages.Where(number => number < 10);
Console.WriteLine(string.Join(", ", lambdaResult)); // 1, 4, 9 


// count
int amountNumbers = ages.Count();
Console.WriteLine(amountNumbers);