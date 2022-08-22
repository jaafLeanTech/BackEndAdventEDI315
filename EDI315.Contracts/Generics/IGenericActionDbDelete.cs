namespace EDI315.Contracts.Generics
{
    public interface IGenericActionDbDelete<T> where T : class
    {
        Task<bool> DeleteAsync(int id);
    }
}
