namespace Solution.Aplication.UseCase.Cube;
using Solution.Aplication.Entity;
using Solution.Aplication.Interface;

public class CubeUseCaseList (IRepositoryCube repositoryCube)
{
    public List<Cube> Execute(){
        List<Cube> cubes = repositoryCube.GetCubes();
        if(cubes != null){
            return cubes;
        }
        else{
            throw new ReposirotyException("No hay cubos guardados.");
        }
    }
}
