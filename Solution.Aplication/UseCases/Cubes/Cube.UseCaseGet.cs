namespace Solution.Aplication.UseCase.Cube;
using Solution.Aplication.Entity;
using Solution.Aplication.Interface;

public class CubeUseCaseGet (IRepositoryCube repositoryCube)
{
    public Cube Execute(int id){
        Cube? query = repositoryCube.GetCube(id);
        if(query != null){
            return query;
        }
        else{
            throw new ReposirotyException("No existe el cubo buscado.");
        }
    }
}
