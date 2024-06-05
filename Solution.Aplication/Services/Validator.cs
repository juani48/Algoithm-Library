namespace Solution.Aplication.Services;

public static class CubeValidator
{
    public static bool IsValid<T>(this T entity)where T : IEntity{
        return entity != null && entity.Text != "";
    }
}
