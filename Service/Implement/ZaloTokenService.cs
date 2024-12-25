
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
            if (string.IsNullOrEmpty(model.OARefreshToken))
            {
                model.OARefreshToken = GlobalHelper.ZaloOARefreshToken;
            }
            if (string.IsNullOrEmpty(model.Display))
            {
                model.Display = GlobalHelper.ZaloRefreshTokenAPIURL;
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
                    Now = Now.AddDays(-1);
                    result = await GetByCondition(item => item.Active == true && item.NgayGhiNhan.Value.Year == Now.Year && item.NgayGhiNhan.Value.Month == Now.Month && item.NgayGhiNhan.Value.Day == Now.Day).FirstOrDefaultAsync();
                    if (result != null)
                    {
                        string url = result.Display;
                        string secret_key = result.Code;
                        string refresh_token = result.OARefreshToken;
                        string app_id = result.TypeName;

                        HttpClient HttpClient = new HttpClient();
                        HttpClient.BaseAddress = new Uri(url);

                        HttpClient.DefaultRequestHeaders.Accept.Clear();
                        HttpClient.DefaultRequestHeaders.Add("secret_key", secret_key);

                        var data = new List<KeyValuePair<string, string>>();
                        data.Add(new KeyValuePair<string, string>("refresh_token", refresh_token));
                        data.Add(new KeyValuePair<string, string>("app_id", app_id));
                        data.Add(new KeyValuePair<string, string>("grant_type", "refresh_token"));

                        HttpResponseMessage httpResponseMessage = HttpClient.PostAsync(url, new FormUrlEncodedContent(data)).GetAwaiter().GetResult();
                    }

                }
                result = await GetByCondition(item => item.Active == true && item.NgayGhiNhan.Value.Year == Now.Year && item.NgayGhiNhan.Value.Month == Now.Month && item.NgayGhiNhan.Value.Day == Now.Day).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
    }
}

