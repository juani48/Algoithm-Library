using Solution.Aplication.Interface;
using Solution.Aplication.Entity;
namespace Solution.Aplication;

public class AlgorithmUseCaseList(IRepositoryAlgorithm repositoryAlgorithm)
{
    public List<Algorithm> Execute(){
        List<Algorithm> algorithms = repositoryAlgorithm.GetAlgorithms();
        if(algorithms != null){
            return algorithms;
        }
        else{
            throw new ReposirotyException("No existen algoritmos cargados.");
        }
    }
}
