namespace Solution.Aplication;

public interface IEntity
{
    int Id { get; set; }
    string Text { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
}
