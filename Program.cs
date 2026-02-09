/* int[] idade = new int[2];
string[] nomes = new string[2];
for(int i = 0; i < 2; i++)
{
    Console.WriteLine($"Entre com o nome da {i+1}° pessoa");
    nomes[i] = Console.ReadLine();
    Console.WriteLine($"Coloque a idade da {i+1}° pessoa");
    idade[i] = int.Parse(Console.ReadLine());
}

if(idade[0]> idade[1])
{
    Console.WriteLine($"A pessoa {nomes[0]} é a mais velha");
}
else
{
    Console.WriteLine($"A pessoa {nomes[1]} é a mais velha");
}


int contador = 0;
while (true)
{
    if(contador == 3) break;
    Console.WriteLine("Entre com o usuario");
    string user = Console.ReadLine();
    Console.WriteLine("Entre com a senha");
    string senha = Console.ReadLine();
    if(user == "admin" && senha == "1234")
    {
        Console.WriteLine("Logado com sucesso");
        break;
    }
    Console.WriteLine($"usuario ou senha errados. Tentativa {contador+1}/3");
    contador++;
} */



/* 
Console.WriteLine("Coloque o primeiro numero");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Coloque o segundo numero");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("1. soma\n2. subtração\n3. multiplição\n4. divisão");
int opc = int.Parse(Console.ReadLine());
switch (opc)
{
    case 1:
    Console.WriteLine($"Soma: {num1+num2}");
    break;
    case 2:
    Console.WriteLine($"Subtração: {num1-num2}");
    break;
    case 3:
    Console.WriteLine($"Soma: {num1*num2}");
    break;
    case 5:
    Console.WriteLine($"Soma: {num1/num2}");
    break;
    default:
    Console.WriteLine("Opção invalida");
    break;
}

Console.WriteLine("Coloque um numero: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Dobro: {num*2} Triplo: {num*3}");



Console.WriteLine("Coloque o seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine($"Boas vindas, {nome}!");


Console.WriteLine("Coloque sua idade: ");
int idade = int.Parse(Console.ReadLine());
Console.WriteLine($"Em 10 ano voce tera: {idade+10}");

//2

Console.WriteLine("Coloque um numero: ");
num = int.Parse(Console.ReadLine());
if(num%2 == 0)
{
    Console.WriteLine("é par");
}
else
{
    Console.WriteLine("é impar");
}

Console.WriteLine("Coloque o primeiro numero: ");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Coloque o segundo numero: ");
int n2 = int.Parse(Console.ReadLine());
if (n1 > n2)
{
    Console.WriteLine($"Esse numero é maior: {n1}");
}
else if(n1== n2)
{
    Console.WriteLine("Eles sao iguais!");
}
else
{
    Console.WriteLine($"Esse numero é maior: {n2}");
}


Console.WriteLine("Coloque uma nota: ");
int n = int.Parse(Console.ReadLine());

if (n > 7)
{
    Console.WriteLine("Aprovado");
}
else if(n>5 && n < 7)
{
    Console.WriteLine("Em recuperação");
}
else
{
    Console.WriteLine("Reprovado");
}


Console.WriteLine("Coloque a idade de uma pessoa: ");
idade = int.Parse(Console.ReadLine());

if (idade > 18 && idade<60)
{
    Console.WriteLine("Você é adulto! ");
}else if (idade < 18)
{
    Console.WriteLine("Você é menor de idade! ");
}
else if (idade > 60)
{
    Console.WriteLine("Você é idosa");
}


Console.WriteLine("Coloque um numero: ");
num = int.Parse(Console.ReadLine());
if (num > 0)
{
    Console.WriteLine("Numero positivo");
}
else if (num < 0){
    Console.WriteLine("Numero negativo");
}
else if(num == 0)
{
    Console.WriteLine("é nulo");
}

//3
Console.WriteLine("Mostrado todos numero do 1 ao 10");
for(int i = 1; i < 11; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("Mostrando todos os numeros pares do 1 ao 50");
for(int i = 1;i< 50; i++)
{
    if(i%2 == 0)
    {
        Console.WriteLine(i);
    }
}



Console.WriteLine("Coloque um numero para fazer a tabuada");
num = int.Parse(Console.ReadLine());

Console.WriteLine("Mostrando a tabuada: ");
for(int i = 0; i< 10; i++)
{
    Console.WriteLine(i*num);
}


float soma = 0;
Console.WriteLine("Coloque varios numeros: (0 para sair)");
while (true)
{
    float nFloat = float.Parse(Console.ReadLine());
    if(nFloat == 0) break;
    soma+= nFloat;
}
Console.WriteLine($"A soma é {soma}");
 */


// Console.WriteLine("Coloque 5 numeros: ");
// int qtPositivos = 0;
// for(int i = 0;i < 5; i++)
// {
//     int num = int.Parse(Console.ReadLine());
//     if(num%2 == 0)
//     {
//         qtPositivos++;
//     }
// }
// Console.WriteLine($"A Quantidade de positivos: {qtPositivos}");



// Console.WriteLine("Coloque o primeiro numero");
// int num1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Coloque o segundo numero");
// int num2 = int.Parse(Console.ReadLine());

// Console.WriteLine("1. soma\n2. subtração\n3. multiplição\n4. divisão");
// int opc = int.Parse(Console.ReadLine());
// switch (opc)
// {
//     case 1:
//     Console.WriteLine($"Soma: {num1+num2}");
//     break;
//     case 2:
//     Console.WriteLine($"Subtração: {num1-num2}");
//     break;
//     case 3:
//     Console.WriteLine($"Soma: {num1*num2}");
//     break;
//     case 5:
//     Console.WriteLine($"Soma: {num1/num2}");
//     break;
//     default:
//     Console.WriteLine("Opção invalida");
//     break;
// }


// Console.WriteLine("Coloque um dia para retornar o dia da semana");
// int num = int.Parse(Console.ReadLine());

// switch (num)
// {
//     case 1:
//     Console.WriteLine("domingo");
//     break;
//     case 2:
//     Console.WriteLine("Segunda");
//     break;
//     case 3:
//     Console.WriteLine("Terca");
//     break;
//     case 4:
//     Console.WriteLine("Quarta");
//     break;
//     case 5:
//     Console.WriteLine("Quinta");
//     break;
//     case 6:
//     Console.WriteLine("Sexta");
//     break;
//     case 7:
//     Console.WriteLine("Sabado");
//     break;
// }


// Console.WriteLine("Coloque a categoria do alimento");
// int categoria = int.Parse(Console.ReadLine());
// switch (categoria)
// {
//     case 1:
//     Console.WriteLine("Alimento");
//     break;
//     case 2:
//     Console.WriteLine("Bebida");
//     break;
//     case 3:
//     Console.WriteLine("Limpeza");
//     break;
// }

Console.WriteLine("COloque 10 numeros: ");
int soma=0;
int maior = 0;
for(int i = 0; i < 10; i++)
{
    int numeros = int.Parse(Console.ReadLine());
    soma += numeros;
    if(numeros> maior) maior = numeros;
}
Console.WriteLine($"Soma: {soma}\nNumero maior: {maior}\nMedia: {soma/10}");

Console.WriteLine("Coloque as idades: (-1 para sair)");
int somaIdades = 0;
int contador = 0;
while (true)
{
    int numero = int.Parse(Console.ReadLine());
    if(numero < 0) break;
    somaIdades += numero;
    contador++;
}
Console.WriteLine($"A media das idades: {somaIdades/contador}  ");


Console.WriteLine("Coloque varios numeros (0 para sair): ");
int contadorPar = 0;
int contadorImpar = 0;

while (true)
{
    int numero = int.Parse(Console.ReadLine());
    if(numero==0) break;
    if(numero%2 == 0)
    {
        contadorPar++;
    }
    else
    {
        contadorImpar++;
    }
}






