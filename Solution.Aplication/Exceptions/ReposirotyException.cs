namespace Solution.Aplication;

public class ReposirotyException : Exception
{
    public ReposirotyException(){}
    public ReposirotyException(string message) : base(message){}
    public ReposirotyException(string message, Exception innerException) : base(message, innerException){}
}
