namespace Solution.Aplication.UseCase.Cube;
using Solution.Aplication.Entity;
using Solution.Aplication.Interface;
using Solution.Aplication.Services;

public class CubeUseCaseAdd (IRepositoryCube repositoryCube)
{
    public void Execute(Cube cube){
        if(cube.IsValid()){
            repositoryCube.AddCube(cube);
        }
        else{
            throw new ValidationException("Los datos del cubo no son corretos.");
        }
    }
}
