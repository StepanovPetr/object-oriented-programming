namespace LibExample.Single_responsibility_principle.After;

public static class ManExtensions
{
    public static string ManInfo(this Man man)
    {
        return $"FirstName - {man.FirstName} SecondName - {man.SecondName} Age - {man.Age} City - {man.City} Hash - {man.GetHashCode()}";
        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated Стандарт C# 6
    }

    // значение переменной по умолчанию.
    public static string ManInfoWithPlanet(this Man man, string planet = "Татуин")
    {
        return $"FirstName - {man.FirstName} SecondName - {man.SecondName} Age - {man.Age} Planet - {planet}";
        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated Стандарт C# 6
    }
}