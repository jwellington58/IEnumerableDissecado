// See https://aka.ms/new-console-template for more information
var numberFrom1To3 = ReturnFrom1To10().Onde(x => x <= 3);
foreach(var i in numberFrom1To3)
{
    Console.WriteLine(i);
}


static IEnumerable<int> ReturnFrom1To10()
{
    var i = 0;
    while(true)
        yield return i++;
}

public static class MyLinq 
{
    public static IEnumerable<T> Onde<T>(this IEnumerable<T> list, Func<T, bool> condicao)
    {
            foreach(var item in list)
            {
                if(condicao(item))
                    yield return item;
                else
                    yield break;
            }
    }
}
