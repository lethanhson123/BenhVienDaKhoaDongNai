namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class GoiSoChiTietPhongKhamController : BaseController<GoiSoChiTietPhongKham, IGoiSoChiTietPhongKhamService>
    {
        private readonly IGoiSoChiTietPhongKhamService _GoiSoChiTietPhongKhamService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public GoiSoChiTietPhongKhamController(IGoiSoChiTietPhongKhamService GoiSoChiTietPhongKhamService, IWebHostEnvironment WebHostEnvironment) : base(GoiSoChiTietPhongKhamService, WebHostEnvironment)
        {
            _GoiSoChiTietPhongKhamService = GoiSoChiTietPhongKhamService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("SaveAsync")]
        public virtual async Task<GoiSoChiTietPhongKham> SaveAsync()
        {
            GoiSoChiTietPhongKham result = new GoiSoChiTietPhongKham();
            try
            {
                result = JsonConvert.DeserializeObject<GoiSoChiTietPhongKham>(Request.Form["data"]);
                result = await _GoiSoChiTietPhongKhamService.SaveAsync(result);
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

