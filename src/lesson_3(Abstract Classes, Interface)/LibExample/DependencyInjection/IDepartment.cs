namespace LibExample.DependencyInjection;

public interface IDepartment
{
    /// <summary> Получить информацию о студенте. </summary>
    /// <param name="email"></param>
    /// <returns> Инфомация о студенте </returns>
    public Student GetStudent(string email);
}