using Solution.Aplication.Entity;
using Solution.Aplication.Interface;
using Solution.Aplication.Services;

namespace Solution.Aplication;

public class CubeUseCaseModify (IRepositoryCube repositoryCube)
{
    public void Execute(Cube cube){
        if(cube.IsValid()){
            if(!repositoryCube.ModifyCube(cube)){
                throw new ReposirotyException("No existe el cubo a modificar.");
            }
        }
        else{
            throw new ValidationException("Lo datos ingresados no son adecuados.");
        }
    }
}
