using GymnasieArbetePlaceringarAPI.IServices.IElevServices;
using SharedModels.Models.EleverModels;
using System.Text.Json;

namespace GymnasieArbetePlaceringarAPI.Services.ElevServices
{
    public class GetElevObjectService : IGetElevObjectService
    {
        public List<ElevModel> GetEleverAsObjects()
        {
            using (StreamReader r = new StreamReader("elever.json"))
            {
                string json = r.ReadToEnd();
                List<ElevModel> elever = JsonSerializer.Deserialize<List<ElevModel>>(json);
                return elever;
            }
        }
    }
}
