﻿namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class KhamBenhController : BaseController<KhamBenh, IKhamBenhService>
    {
        private readonly IKhamBenhService _KhamBenhService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public KhamBenhController(IKhamBenhService KhamBenhService, IWebHostEnvironment WebHostEnvironment) : base(KhamBenhService, WebHostEnvironment)
        {
            _KhamBenhService = KhamBenhService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByKhamBenh_IdAsync")]
        public virtual async Task<KhamBenh> GetByKhamBenh_IdAsync()
        {
            KhamBenh result = new KhamBenh();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _KhamBenhService.GetByKhamBenh_IdAsync(baseParameter.KhamBenh_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByNgayKham_SearchStringToListAsync")]
        public virtual async Task<List<KhamBenh>> GetByNgayKham_SearchStringToListAsync()
        {
            List<KhamBenh> result = new List<KhamBenh>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _KhamBenhService.GetByNgayKham_SearchStringToListAsync(baseParameter.NgayKham.Value, baseParameter.SearchString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByYear_Month_Day_SearchStringToListAsync")]
        public virtual async Task<List<KhamBenh>> GetByYear_Month_Day_SearchStringToListAsync()
        {
            List<KhamBenh> result = new List<KhamBenh>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _KhamBenhService.GetByYear_Month_Day_SearchStringToListAsync(baseParameter.Year.Value, baseParameter.Month.Value, baseParameter.Day.Value, baseParameter.SearchString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByBenhNhan_Id_Year_Month_DayToListAsync")]
        public virtual async Task<List<KhamBenh>> GetByBenhNhan_Id_Year_Month_DayToListAsync()
        {
            List<KhamBenh> result = new List<KhamBenh>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _KhamBenhService.GetByBenhNhan_Id_Year_Month_DayToListAsync(baseParameter.BenhNhan_Id.Value, baseParameter.Year.Value, baseParameter.Month.Value, baseParameter.Day.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

