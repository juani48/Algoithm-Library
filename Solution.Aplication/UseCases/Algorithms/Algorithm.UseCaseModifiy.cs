using Solution.Aplication.Entity;
using Solution.Aplication.Interface;
using Solution.Aplication.Services;

namespace Solution.Aplication;

public class AlgorithmUseCaseModifiy (IRepositoryAlgorithm repositoryAlgorithm)
{
    public void Execute(Algorithm algorithm){
        if(algorithm.IsValid()){
            if(!repositoryAlgorithm.ModifyAlgorithm(algorithm)){
                throw new ReposirotyException("No existe el algoritmo a modificar.");
            }
        }
        else{
            throw new ValidationException("Lo datos ingresados no son adecuados.");
        }
    }
}
