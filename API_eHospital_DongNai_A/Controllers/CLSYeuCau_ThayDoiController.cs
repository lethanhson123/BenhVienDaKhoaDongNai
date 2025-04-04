﻿namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CLSYeuCau_ThayDoiController : BaseController<CLSYeuCau_ThayDoi, ICLSYeuCau_ThayDoiService>
    {
        private readonly ICLSYeuCau_ThayDoiService _CLSYeuCau_ThayDoiService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public CLSYeuCau_ThayDoiController(ICLSYeuCau_ThayDoiService CLSYeuCau_ThayDoiService, IWebHostEnvironment WebHostEnvironment) : base(CLSYeuCau_ThayDoiService, WebHostEnvironment)
        {
            _CLSYeuCau_ThayDoiService = CLSYeuCau_ThayDoiService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByListIDToListAsync")]
        public virtual async Task<List<CLSYeuCau_ThayDoi>> GetByListIDToListAsync()
        {
            List<CLSYeuCau_ThayDoi> result = new List<CLSYeuCau_ThayDoi>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _CLSYeuCau_ThayDoiService.GetByListIDToListAsync(baseParameter.ListID);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

