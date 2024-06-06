namespace Solution.Aplication.Entity;
public class Cube : IEntity
{
    public int Id { get; set; }
    public string Text { get; set; } = "";
    public List<Algorithm>? algorithms{ get; set; } = new List<Algorithm>();
    public string Image { get; set; } = "Images/";
}