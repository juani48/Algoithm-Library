namespace Solution.Repository;

using System.Collections.Generic;
using Solution.Aplication.Entity;
using Solution.Aplication.Interface;

public class AlgorithmRepository : IRepositoryAlgorithm
{
    public static void Initialization(){
        using var db = new Context();
        if(db.Database.EnsureCreated()){
            Console.WriteLine("Se creo la base de datos.");
        }
    }
    
    public void AddAlgorithm(Algorithm algorithm)
    {
        using var db = new Context();
        db.Algorithms.Add(algorithm);
        db.SaveChanges();
    }

    public bool DeleteAlgorithm(int id)
    {
        using var db = new Context();
        var query = db.Algorithms.Where(algorithm => algorithm.Id == id).SingleOrDefault();
        if(query != null){
            db.Algorithms.Remove(query);
            db.SaveChanges();
            return true;
        }
        else{
            return false;
        }
    }

    public Algorithm? GetAlgorithm(int id)
    {
        using var db = new Context();
        return db.Algorithms.Where(algorithm => algorithm.Id == id).SingleOrDefault();
    }

    public List<Algorithm> GetAlgorithms()
    {
        using var db = new Context();
        return db.Algorithms.ToList();
    }
}
