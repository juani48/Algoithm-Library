namespace Solution.Aplication.Interface;
using Solution.Aplication.Entity;
public interface IRepositoryAlgorithm
{
    void AddAlgorithm(Algorithm algorithm);
    List<Algorithm> GetAlgorithms();
    Algorithm? GetAlgorithm(int id);
    bool DeleteAlgorithm(int id);
}
