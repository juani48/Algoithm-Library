using Solution.Aplication.Interface;
namespace Solution.Aplication.UseCase.Algorithm;
using Solution.Aplication.Entity;

public class AlgorithmUseCaseList(IRepositoryAlgorithm repositoryAlgorithm)
{
    public List<Algorithm> Execute(int cubeId){
        List<Algorithm> algorithms = repositoryAlgorithm.GetAlgorithms(cubeId);
        if(algorithms != null){
            return algorithms;
        }
        else{
            throw new ReposirotyException("No existen algoritmos cargados.");
        }
    }
}
