using EDI.Entities.Entities;
using EDI315.Contracts.Generics;
using EDI315.Entities.Entities;

namespace EDI315.Contracts.Repository
{
    public interface IEDI315Repository : IGenericActionDbAdd<ItemContainer>, IGenericActionDbUpdate<ItemContainer>, IGenericActionDbQuery<Item>
    {
    }
}
