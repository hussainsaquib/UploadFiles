using ImageFunc.Models.Domain;

namespace ImageFunc.Repository.Abstract
{
    public interface IProductRepository
    {
        bool Add(Product model);
    }
}
