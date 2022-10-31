using GymnasieArbetePlaceringarInterface.IServices;

namespace GymnasieArbetePlaceringarInterface.Services
{
    public class GetElevService : IGetElevService
    {
        private readonly HttpClient _httpClient;

        public GetElevService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<string> GetElever()
        {
            var responseMessage = await _httpClient.GetAsync($"api/Elev");

            if (responseMessage.IsSuccessStatusCode)
            {
                string responseJson = await responseMessage.Content.ReadAsStringAsync();

                return responseJson;
            }

            return "failed";
        }
    }
}
