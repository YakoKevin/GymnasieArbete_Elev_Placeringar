using SharedModels.Models.EleverModels;

namespace GymnasieArbetePlaceringarAPI.IServices.IElevServices
{
    public interface IGetElevObjectService
    {
        public List<ElevModel> GetEleverAsObjects();
    }
}
