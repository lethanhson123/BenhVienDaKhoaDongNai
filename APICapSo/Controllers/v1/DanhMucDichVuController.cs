namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucDichVuController : BaseController<DanhMucDichVu, IDanhMucDichVuService>
    {
        private readonly IDanhMucDichVuService _DanhMucDichVuService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DanhMucDichVuController(IDanhMucDichVuService DanhMucDichVuService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucDichVuService, WebHostEnvironment)
        {
            _DanhMucDichVuService = DanhMucDichVuService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("ZaloSendMessageAsync")]
        public virtual async Task<int> ZaloSendMessageAsync(string user_id, string Message)
        {
            int result = GlobalHelper.InitializationNumber;
            try
            {
                string access_token = "VVpCP9z4xcDn_SnkaKViRdRzo6ELMver28haRBrheWypskDXqnEwCrJBv43mUi0T5vssU9b_yNWXaPD_m5Nb95cgmaZZQ9ae0wwvKQnrc2C3h_0lXNUnTH2x-WsKTuXK4PpI0gjiWMODlQ9deMUAQoUEynwzSzfB1fUu3PrwpWynWua8b4EiU027XGkqMgrA9QNJBOKQaNiGqVKzY3ASGIZbkq380laORhghU-XHZ3LKuETNiZsdBY_JnK2l4wD4BUBt4umErcC0oVPdaHc40Id-p6sIHPmKQPZqJebSe4ebiu48btYYQ2oHnm-KSRXs9eh58RXabbuyk-8okqIyCYx-d4JFEzirLO6FD-bJ-4nPjeqrwasiSWgNoH69J99NRul02D4tdrvctD4GuH-BK7Nbw2CmreWHD9zQwMK";
                ZaloClient client = new ZaloClient(access_token);                
                JObject jObject = client.sendTextMessageToUserIdV3(user_id, Message);

            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetAllToListAsync")]
        public virtual async Task<List<DanhMucDichVu>> GetAllToListAsync()
        {
            List<DanhMucDichVu> result = new List<DanhMucDichVu>();
            try
            {
                result = await _DanhMucDichVuService.GetAllToListAsync();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByIsBHYTToListAsync")]
        public virtual async Task<List<DanhMucDichVu>> GetByIsBHYTToListAsync()
        {
            List<DanhMucDichVu> result = new List<DanhMucDichVu>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DanhMucDichVuService.GetByIsBHYTToListAsync(baseParameter.IsBHYT.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

