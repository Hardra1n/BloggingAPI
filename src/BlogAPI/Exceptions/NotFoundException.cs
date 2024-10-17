namespace BlogAPI.Exceptions;

public class NotFoundException<T> : Exception
{
    public NotFoundException(int id) : base($"{typeof(T)} not found with ID: {id}") { }
}