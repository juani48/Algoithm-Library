using System.Reflection.Metadata;

namespace Solution.Aplication.Entity;

public class Algorithm : IEntity
{
    public int Id { get; set; }
    public int CubeId { get; set; }
    public string Text { get; set; } = "";
    public string Description { get; set; } = "";
}
