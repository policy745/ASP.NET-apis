using WebApi.Model.Domain;

namespace WebApi.Repositories
{
    public interface IRegionRepository
    {
        Task<IEnumerable<Region>> GetRegions();
    }
}
