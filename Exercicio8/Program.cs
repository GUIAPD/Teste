class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Digite um numero de 1 a 5 para ver o exercicio: ");
        int opção = int.Parse(Console.ReadLine());
        switch (opção)
        {
            case 1:
                exercicio1();
                break;
            case 2:
                exercicio2();
                break;
            case 3:
                exercicio3();
                break;
            case 4:
                exercicio4();
                break;
            case 5:
                exercicio5();
                break;
            default:
                    Console.WriteLine("erro: mumero indisponivel. ");
                break;
        }
    }

    static void exercicio1()
    {
        try
        {
            Console.WriteLine("Digite a base da potencia: ");
            int Base = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente da potencia: ");
            int Expo = int.Parse(Console.ReadLine());
            int Potencia = potencia(Base, Expo);
            Console.WriteLine(Potencia);
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Formato invalido");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
    static void exercicio2()
    {
        try
        {
            Console.WriteLine("Digte um numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(mais(num1));
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Formato invalido");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
    static void exercicio3()
    {
        try
        {
            Console.WriteLine("Digite um numero: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(fibonaci(num2 -1));
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Formato invalido");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
    static void exercicio4()
    {
        try
        {
            Console.WriteLine("Digite um numero: ");
            int num3 = int.Parse(Console.ReadLine());
            int contagem = ContagemRegressiva(num3);
            Console.WriteLine(contagem);
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Formato invalido");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
    static void exercicio5()
    {
        try
        {
            Console.WriteLine("Digite 2 numeros: ");
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            Console.WriteLine(mdc(N1,N2));


        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Formato invalido");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
    static int potencia(int Base, int Expo)
    {
        if (Expo == 0)
        {
            return 1;
        }

        return Base * potencia(Base, Expo - 1);
    }
    static int mais(int num1)
    {
        if(num1 == 0)
        {
            return 0;
        }
        return num1 + mais(num1 - 1);
    }
    static int fibonaci(int num2)
    {
        if(num2 == 1 || num2 == 0)
        {
            return num2;
        }
        return fibonaci(num2 - 1) + fibonaci(num2 - 2);
    }
    static int ContagemRegressiva(int num3)
    {
        if(num3 == 1)
        {
            return 1;
        }
        Console.WriteLine(num3);
        return ContagemRegressiva(num3 - 1);
    }
        static int mdc(int a, int b)
        {
            if(b == 0)
        {
            return a;
        }
        return mdc(b, a % b);
        }
}


    

    