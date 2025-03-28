﻿namespace API.Controllers.v1
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
        [HttpPost]
        [Route("GetByThanhVienID_ActiveToListAsync")]
        public async Task<List<DanhMucDichVu>> GetByThanhVienID_ActiveToListAsync()
        {
            List<DanhMucDichVu> result = new List<DanhMucDichVu>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DanhMucDichVuService.GetByThanhVienID_ActiveToListAsync(model.ThanhVienID.Value, model.Active.Value);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("KhoiPhucAsync")]
        public virtual async Task<List<DanhMucDichVu>> KhoiPhucAsync()
        {
            List<DanhMucDichVu> result = new List<DanhMucDichVu>();
            try
            {
                result = await _DanhMucDichVuService.KhoiPhucAsync();
                foreach (DanhMucDichVu item in result)
                {
                    await _DanhMucDichVuService.SaveAsync(item);
                    result.Add(item);
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

