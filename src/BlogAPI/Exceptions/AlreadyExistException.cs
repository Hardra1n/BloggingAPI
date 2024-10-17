public class AlreadyExistsException<T> : Exception
{
    public AlreadyExistsException(int id) : base($"{typeof(T)} with id {id} already exists.") { }
}