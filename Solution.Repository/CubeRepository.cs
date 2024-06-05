namespace Solution.Repository;

using System.Collections.Generic;
using Solution.Aplication.Entity;
using Solution.Aplication.Interface;

public class CubeRepository : IRepositoryCube
{
    public static void Initialization(){
        using var db = new Context();
        if(db.Database.EnsureCreated()){
            db.Cubes.Add(new Cube(){
                Text = "Test1"
            });
            db.Cubes.Add(new Cube(){
                Text = "Test2"
            });
            db.SaveChanges();
            Console.WriteLine("Se creo la base de datos.");
        }
    }
    
    public void AddCube(Cube cube)
    {
        using var db = new Context();
        db.Cubes.Add(cube);
        db.SaveChanges();
    }

    public bool DeleteCube(int id)
    {
        using var db = new Context();
        var query = db.Cubes.Where(cube => cube.Id == id).SingleOrDefault();
        if(query != null){
            db.Cubes.Remove(query);
            db.SaveChanges();
            return true;
        }
        else{
            return false;
        }
    }

    public Cube? GetCube(int id)
    {
        using var db = new Context();
        return db.Cubes.Where(cube => cube.Id == id).FirstOrDefault();
    }

    public List<Cube> GetCubes()
    {
        using var db = new Context();
        return db.Cubes.ToList();
    }
}
