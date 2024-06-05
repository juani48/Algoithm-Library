namespace Solution.Aplication.UseCase.Cube;
using Solution.Aplication.Interface;

public class CubeUseCaseDelete (IRepositoryCube repositoryCube)
{
    public void Execute(int id){
        if(!repositoryCube.DeleteCube(id)){
            throw new ReposirotyException("El cubo a eliminar no existe.");
        }
    }
}
