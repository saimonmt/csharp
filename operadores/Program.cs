// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Operadores Aritmeticos 
double resultado = 12 + 8 + 12 / 3 ;
Console.WriteLine(resultado);

double res2 = (12 + 8 + 12) / 3 ;
Console.WriteLine(res2);

double res3 = (2 + 8 ) * 2 / 4 ;
Console.WriteLine(res3);

//  Operadores Logicos 04/11/2024
// AND Logico &&(E)
bool a = true;
bool b = false;
Console.WriteLine(a && b) ;

// OR Logico ||(OU)
bool c = true;
bool d = false;
Console.WriteLine(c || d) ;

// NOT Logico !(Nao)
bool e = true;
bool f = false;
Console.WriteLine( !e ) ;

// XOR Logico ^(Ou Exclusivo)
bool g = true;
bool h = false;
Console.WriteLine( g ^ h ) ;

// Exemplo de Precedencia 1 
bool i = true;
bool j = false;
bool k = false;
bool res4 = !i || ( j && k );
Console.WriteLine(res4) ;

// Exemplo de Precedencia 2
bool l = false;
bool m = false;
bool n = false;
bool res5 = !l || m && n;
Console.WriteLine(res5) ;