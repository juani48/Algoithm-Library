namespace Solution.Aplication.UseCase.Algorithm;
using Solution.Aplication.Entity;
using Solution.Aplication.Interface;
using Solution.Aplication.Services;

public class AlgorithmUseCaseAdd (IRepositoryAlgorithm repositoryAlgorithm)
{
    public void Execute(Algorithm algorithm){
        if(algorithm.IsValid()){
            repositoryAlgorithm.AddAlgorithm(algorithm);
        }
        else{
            throw new ValidationException("Los datos del cubo no son corretos.");
        }
    }
}
