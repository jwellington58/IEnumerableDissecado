// See https://aka.ms/new-console-template for more information
var numeroDe1A3 = RetornaDe1a10().Onde(x => x <= 3);
foreach(var i in numeroDe1A3)
{
    Console.WriteLine(i);
}


static IEnumerable<int> RetornaDe1a10()
{
    yield return 1;
    yield return 2;
    yield return 3;
    yield return 4;
    yield return 5;
    yield return 6;
    yield return 7;
    yield return 8;
    yield return 9;
    yield return 10;
}

public static class MeuLinq 
{
    public static IEnumerable<T> Onde<T>(this IEnumerable<T> lista, Func<T, bool> condicao)
    {
            foreach(var item in lista)
            {
                if(condicao(item))
                    yield return item;
                else
                    yield break;
            }
    }
}
