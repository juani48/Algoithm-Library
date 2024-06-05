namespace Solution.Aplication.UseCase.Algorithm;
using Solution.Aplication.Interface;

public class AlgorithmUseCaseDelete (IRepositoryAlgorithm repositoryAlgorithm)
{
    public void Execute(int id){
        if(!repositoryAlgorithm.DeleteAlgorithm(id)){
            throw new ReposirotyException("El cubo a eliminar no existe.");
        }
    }
}
