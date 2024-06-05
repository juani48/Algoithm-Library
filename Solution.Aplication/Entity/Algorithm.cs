namespace Solution.Aplication.Entity;

public class Algorithm : IEntity
{
    public int Id { get; set; }
    public int CubeId { get; set; }
    public string Text { get; set; } = "";
}
