
using Azure.Core;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using ZXing.QrCode.Internal;

namespace Service.Implement
{
    public class ZaloTokenService : BaseService<ZaloToken, IZaloTokenRepository>
    , IZaloTokenService
    {
        private readonly IZaloTokenRepository _ZaloTokenRepository;
        public ZaloTokenService(IZaloTokenRepository ZaloTokenRepository) : base(ZaloTokenRepository)
        {
            _ZaloTokenRepository = ZaloTokenRepository;
        }
        public override void Initialization(ZaloToken model)
        {
            BaseInitialization(model);

            if (string.IsNullOrEmpty(model.Note))
            {
                model.Note = GlobalHelper.ZaloTokenNote;
            }
            if (string.IsNullOrEmpty(model.URL))
            {
                model.URL = GlobalHelper.ZaloRefreshTokenAPIURL;
            }           
        }
        public virtual async Task<ZaloToken> GetLatestAsync()
        {
            ZaloToken result = new ZaloToken();
            try
            {
                DateTime Now = GlobalHelper.InitializationDateTime;
                result = await GetByCondition(item => item.Active == true && item.NgayGhiNhan.Value.Year == Now.Year && item.NgayGhiNhan.Value.Month == Now.Month && item.NgayGhiNhan.Value.Day == Now.Day).FirstOrDefaultAsync();
                if (result == null)
                {                 
                    result = await GetByCondition(item => item.Active == true).OrderByDescending(item => item.ID).Take(1).FirstOrDefaultAsync();
                    if (result != null)
                    {
                        string url = result.URL;
                        string secret_key = result.SecretKey;
                        string refresh_token = result.OARefreshToken;
                        string app_id = result.AppID;

                        HttpClient HttpClient = new HttpClient();
                        HttpClient.BaseAddress = new Uri(url);

                        HttpClient.DefaultRequestHeaders.Accept.Clear();
                        HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        HttpClient.DefaultRequestHeaders.Add("secret_key", secret_key);

                        var data = new List<KeyValuePair<string, string>>();
                        data.Add(new KeyValuePair<string, string>("refresh_token", refresh_token));
                        data.Add(new KeyValuePair<string, string>("app_id", app_id));
                        data.Add(new KeyValuePair<string, string>("grant_type", "refresh_token"));


                        var task = HttpClient.PostAsync(url, new FormUrlEncodedContent(data));
                        var ContentResult = await task.Result.Content.ReadAsStringAsync();
                        ZaloRefreshTokenDataRespond ZaloRefreshTokenDataRespond = JsonConvert.DeserializeObject<ZaloRefreshTokenDataRespond>(ContentResult);
                        result = new ZaloToken();
                        result.AppID = app_id;
                        result.URL = url;
                        result.SecretKey = secret_key;

                        result.Active = true;
                        result.OAAccessToken = ZaloRefreshTokenDataRespond.access_token;
                        result.OARefreshToken = ZaloRefreshTokenDataRespond.refresh_token;
                        result = await SaveAsync(result);
                    }
                }
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            if (result == null)
            {
                result = new ZaloToken();
            }
            return result;
        }
    }
}

