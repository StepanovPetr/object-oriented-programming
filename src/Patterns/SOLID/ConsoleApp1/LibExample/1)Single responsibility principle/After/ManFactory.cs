namespace LibExample.Single_responsibility_principle.After;

public class ManFactory
{
    #region static fields
    static string[] _firstNames = new string[] { "Вова", "Алексей", "Егор", "Дима", "Николай", "Петр", "Максим", "Иван" };
    static string[] _secondNames = new string[] { "Мусихин", "Цыганок", "Чердынцев", "Степанов", "Куянов", "Атинк", "Максим", "Блинов" };
    static string[] _cities = new string[] { "Омск", "Москва", "Хацупетовка", "Исилькуль", "Магадан" };
    static Random _rand = new Random();
    #endregion


    public static Man GetMan()
    {
        return new Man()
        {
            FirstName = _firstNames[_rand.Next(0, _firstNames.Length)],
            SecondName = _secondNames[_rand.Next(0, _secondNames.Length)],
            City = _cities[_rand.Next(0, _cities.Length)],
            Age = _rand.Next(1, 101)
        };
    }
}