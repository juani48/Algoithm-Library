namespace Solution.Aplication.Interface;
using Solution.Aplication.Entity;
public interface IRepositoryCube
{
    void AddCube(Cube cube);
    List<Cube> GetCubes();
    Cube? GetCube(int id);
    bool DeleteCube(int id);
    bool ModifyCube(Cube cube); 
}
