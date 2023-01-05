// See https://aka.ms/new-console-template for more information

using Calculadora.Domain;

static int Operacao()
{
    int op = 0;
    do
    {
        Console.Clear();
        Console.Write("*Calculadora Operacao*\n" +
            "1 - Somar\n" +
            "2 - Subtrair\n" +
            "3 - Multiplicar\n" +
            "4 - Dividir\n" +
            "5 - Potencia2\n" +
            "6 - PotenciaY\n" +
            "7 - Exponencial\n" +
            "8 - Raiz\n" +
            "9 - Logaritimo2\n" +
            "10 - Logaritimo10\n" +
            "11 - Sair\n" +
            "Digite: ");
        op = int.Parse(Console.ReadLine());
    } while (op < 0 || op > 11);
    return op;
}

static void Input(int Op, Valores valores)
{
    if (Op == 1)
    {
        Console.Write("Digite o Valor 1: ");
        valores.Valor1 = long.Parse(Console.ReadLine());
    }
    Console.Write("Digite o Valor 2: ");
    valores.Valor2 = long.Parse(Console.ReadLine());

}

static long Insert(Valores valores, Operadores operadores, string tipo, int Op)
{
    Input(Op, valores);
    return operadores.TipoOperador(tipo, valores);
}

static bool continua(Valores valores, long total)
{
    bool res = false;
    Console.Write("Quer usar o resultado da ultima operação numa proxima conta \n 1 - Sim \n 2 - Não \n Digite: ");
    switch (int.Parse(Console.ReadLine()))
    {
        case 1:
            res = true;
            valores.Valor1 = total;
            break;
        case 2:
            res = false;
            break;
        default:
            continua(valores, total);
            break;
    }
    return res;
}

Valores valores = new Valores();
Operadores operadores = new Operadores();

bool end = false;
int Op = 1;
long total = 0;
while (end != true)
{
    switch (Operacao())
    {
        case 1:
            Console.Clear();
            total = Insert(valores, operadores, "Soma", Op);
            Console.WriteLine(total);
            Op = continua(valores, total) ? 2 : 1;
            break;
        case 2:
            Console.Clear();
            total = Insert(valores, operadores, "Subitrai", Op);
            Console.WriteLine(total);
            Op = continua(valores, total) ? 2 : 1;
            break;
        case 3:
            Console.Clear();
            total = Insert(valores, operadores, "Mutiplica", Op);
            Console.WriteLine(total);
            Op = continua(valores, total) ? 2 : 1;
            break;
        case 4:
            Console.Clear();
            total = Insert(valores, operadores, "Divide", Op);
            Console.WriteLine(total);
            Op = continua(valores, total) ? 2 : 1;
            break;
        case 5:
            Console.Clear();
            total = Insert(valores, operadores, "Potencia2", Op);
            Console.WriteLine(total);
            Op = continua(valores, total) ? 2 : 1;
            break;
        case 6:
            Console.Clear();
            total = Insert(valores, operadores, "PotenciaY", Op);
            Console.WriteLine(total);
            Op = continua(valores, total) ? 2 : 1;
            break;
        case 7:
            Console.Clear();
            total = Insert(valores, operadores, "Exp", Op);
            Console.WriteLine(total);
            Op = continua(valores, total) ? 2 : 1;
            break;
        case 8:
            Console.Clear();
            total = Insert(valores, operadores, "Raiz", Op);
            Console.WriteLine(total);

            Op = continua(valores, total) ? 2 : 1;
            break;
        case 9:
            Console.Clear();
            total = Insert(valores, operadores, "Log", Op);
            Console.WriteLine(total);
            Op = continua(valores, total) ? 2 : 1;
            break;
        case 10:
            Console.Clear();
            total = Insert(valores, operadores, "Log10", Op);
            Console.WriteLine(total);
            Op = continua(valores, total) ? 2 : 1;
            break;
        case 11:
            Console.WriteLine("Programa encerrado");
            end = true;
            break;
        default:
            Operacao();
            break;
    }
}