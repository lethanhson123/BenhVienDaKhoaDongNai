namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ThanhVienController : BaseController<ThanhVien, IThanhVienService>
    {
        private readonly IThanhVienService _ThanhVienService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public ThanhVienController(IThanhVienService ThanhVienService, IWebHostEnvironment WebHostEnvironment) : base(ThanhVienService, WebHostEnvironment)
        {
            _ThanhVienService = ThanhVienService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("AuthenticationAsync")]
        public async Task<ThanhVien> AuthenticationAsync()
        {
            ThanhVien result = new ThanhVien();
            try
            {
                result = JsonConvert.DeserializeObject<ThanhVien>(Request.Form["data"]);
                result = await _ThanhVienService.AuthenticationAsync(result);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [AllowAnonymous]
        [HttpGet]
        [Route("GetAuthenticationAsync")]
        public virtual async Task<ThanhVien> GetAuthenticationAsync(string TaiKhoan, string MatKhau)
        {
            ThanhVien result = new ThanhVien();
            try
            {
                result.TaiKhoan = TaiKhoan;
                result.MatKhau = MatKhau;
                result = await _ThanhVienService.AuthenticationAsync(result);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                result.Note = message;
            }
            return result;
        }
    }
}

