namespace Solution.Aplication.Interface;
using Solution.Aplication.Entity;
public interface IRepositoryAlgorithm
{
    void AddAlgorithm(Algorithm algorithm);
    List<Algorithm> GetAlgorithms(int cubeId);
    Algorithm? GetAlgorithm(int id);
    bool DeleteAlgorithm(int id);
}
