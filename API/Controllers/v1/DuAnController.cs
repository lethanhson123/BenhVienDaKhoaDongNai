﻿namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DuAnController : BaseController<DuAn, IDuAnService>
    {
        private readonly IDuAnService _DuAnService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DuAnController(IDuAnService DuAnService, IWebHostEnvironment WebHostEnvironment) : base(DuAnService, WebHostEnvironment)
        {
            _DuAnService = DuAnService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetBySearchString_BatDau_KetThucToListAsync")]
        public async Task<List<DuAn>> GetBySearchString_BatDau_KetThucToListAsync()
        {
            List<DuAn> result = new List<DuAn>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DuAnService.GetBySearchString_BatDau_KetThucToListAsync(model.SearchString, model.BatDau.Value, model.KetThuc.Value);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
    }
}
