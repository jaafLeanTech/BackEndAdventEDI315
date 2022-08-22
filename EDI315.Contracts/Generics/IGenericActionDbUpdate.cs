
namespace EDI315.Contracts.Generics
{
    public interface IGenericActionDbUpdate<T> where T : class
    {
        Task<bool> UpdateAsync(string id, T item);
    }
}