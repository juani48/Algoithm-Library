namespace Solution.Aplication.UseCase.Algorithm;
using Solution.Aplication.Entity;
using Solution.Aplication.Interface;

public class AlgorithmUseCaseGet (IRepositoryAlgorithm repositoryAlgorithm)
{
    public Algorithm Execute(int id){
        Algorithm? query = repositoryAlgorithm.GetAlgorithm(id);
        if(query != null){
            return query;
        }
        else{
            throw new ReposirotyException("No existe el algoritmo buscado.");
        }
    }
}
