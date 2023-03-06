using WebApi.Model.Domain;

namespace WebApi.Repositories
{
    public interface IRegionRepository
    {
        IEnumerable<Region> GetRegions();
    }
}
