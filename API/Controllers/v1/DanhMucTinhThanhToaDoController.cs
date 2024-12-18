
using Microsoft.EntityFrameworkCore;

namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucTinhThanhToaDoController : BaseController<DanhMucTinhThanhToaDo, IDanhMucTinhThanhToaDoService>
    {
        private readonly IDanhMucTinhThanhToaDoService _DanhMucTinhThanhToaDoService;
        private readonly IWebHostEnvironment _WebHostEnvironment;

        private readonly IDanhMucTinhThanhService _DanhMucTinhThanhService;
        private readonly IDanhMucQuanHuyenService _DanhMucQuanHuyenService;
        private readonly IDanhMucXaPhuongService _DanhMucXaPhuongService;
        public DanhMucTinhThanhToaDoController(IDanhMucTinhThanhToaDoService DanhMucTinhThanhToaDoService

            , IWebHostEnvironment WebHostEnvironment

            , IDanhMucTinhThanhService DanhMucTinhThanhService
            , IDanhMucQuanHuyenService DanhMucQuanHuyenService
            , IDanhMucXaPhuongService DanhMucXaPhuongService

            ) : base(DanhMucTinhThanhToaDoService, WebHostEnvironment)
        {
            _DanhMucTinhThanhToaDoService = DanhMucTinhThanhToaDoService;
            _WebHostEnvironment = WebHostEnvironment;

            _DanhMucTinhThanhService = DanhMucTinhThanhService;
            _DanhMucQuanHuyenService = DanhMucQuanHuyenService;
            _DanhMucXaPhuongService = DanhMucXaPhuongService;
        }
        [HttpPost]
        [Route("GetSQLDanhMucQuanHuyenByParentID_ActiveToListAsync")]
        public async Task<List<DanhMucTinhThanhToaDo>> GetSQLDanhMucQuanHuyenByParentID_ActiveToListAsync()
        {
            List<DanhMucTinhThanhToaDo> result = new List<DanhMucTinhThanhToaDo>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DanhMucTinhThanhToaDoService.GetSQLDanhMucQuanHuyenByParentID_ActiveToListAsync(model.ParentID.Value, model.Active.Value);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetSQLDanhMucXaPhuongByParentID_ActiveToListAsync")]
        public async Task<List<DanhMucTinhThanhToaDo>> GetSQLDanhMucXaPhuongByParentID_ActiveToListAsync()
        {
            List<DanhMucTinhThanhToaDo> result = new List<DanhMucTinhThanhToaDo>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DanhMucTinhThanhToaDoService.GetSQLDanhMucXaPhuongByParentID_ActiveToListAsync(model.ParentID.Value, model.Active.Value);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByParentID_Active_NumberToListAsync")]
        public async Task<List<DanhMucTinhThanhToaDo>> GetByParentID_Active_NumberToListAsync()
        {
            List<DanhMucTinhThanhToaDo> result = new List<DanhMucTinhThanhToaDo>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DanhMucTinhThanhToaDoService.GetByParentID_Active_NumberToListAsync(model.ParentID.Value, model.Active.Value, model.Number.Value);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("PostDanhMucTinhThanhToaDo3ByJSONFileAsync")]
        public virtual async Task<List<DanhMucTinhThanhToaDo>> PostDanhMucTinhThanhToaDo3ByJSONFileAsync()
        {
            List<DanhMucTinhThanhToaDo> result = new List<DanhMucTinhThanhToaDo>();
            try
            {
                if (Request.Form.Files.Count > 0)
                {
                    var file = Request.Form.Files[0];
                    if (file == null || file.Length == 0)
                    {
                    }
                    if (file != null)
                    {
                        string fileExtension = Path.GetExtension(file.FileName);
                        string fileName = "DanhMucTinhThanhToaDo3_" + GlobalHelper.InitializationDateTimeCode0001 + fileExtension;
                        var folderPath = Path.Combine(_WebHostEnvironment.WebRootPath, GlobalHelper.Upload, fileName);
                        bool isFolderExists = System.IO.Directory.Exists(folderPath);
                        if (!isFolderExists)
                        {
                            System.IO.Directory.CreateDirectory(folderPath);
                        }
                        using (var stream = new FileStream(folderPath, FileMode.Create))
                        {
                            file.CopyTo(stream);
                        }
                        try
                        {
                            FileInfo fileLocation = new FileInfo(folderPath);
                            string contentHTML = GlobalHelper.InitializationString;
                            if (fileLocation.Length > 0)
                            {
                                using (FileStream fs = new FileStream(folderPath, FileMode.Open))
                                {
                                    using (StreamReader r = new StreamReader(fs, Encoding.UTF8))
                                    {
                                        contentHTML = r.ReadToEnd();

                                    }
                                }
                                var json = JsonConvert.DeserializeObject<dynamic>(contentHTML);

                                List<DanhMucTinhThanh> ListDanhMucTinhThanh = await _DanhMucTinhThanhService.GetAllToListAsync();
                                List<DanhMucQuanHuyen> ListDanhMucQuanHuyen = await _DanhMucQuanHuyenService.GetAllToListAsync();
                                List<DanhMucXaPhuong> ListDanhMucXaPhuong = await _DanhMucXaPhuongService.GetAllToListAsync();

                                var features = json["features"];
                                foreach (var feature in features)
                                {
                                    var properties = feature["properties"];
                                    var NAME_1 = properties["NAME_1"];
                                    var NAME_2 = properties["NAME_2"];
                                    var NAME_3 = properties["NAME_3"];
                                    string typeName = NAME_1.ToString();
                                    string display = NAME_2.ToString();
                                    string fileName001 = NAME_3.ToString();
                                    if (typeName == "ĐồngNai")
                                    {
                                        DanhMucXaPhuong danhMucXaPhuong = ListDanhMucXaPhuong.Where(item => item.TypeName == typeName && item.Display == display && item.FileName == fileName001).FirstOrDefault();
                                        if (danhMucXaPhuong != null)
                                        {
                                            if (danhMucXaPhuong.ID > 0)
                                            {
                                                var geometry = feature["geometry"];
                                                var coordinates = geometry["coordinates"];
                                                foreach (var coordinate in coordinates)
                                                {
                                                    string coordinateSubs = coordinate.ToString();
                                                    List<DanhMucTinhThanhToaDo> listDanhMucTinhThanhToaDo = new List<DanhMucTinhThanhToaDo>();
                                                    for (int i = 0; i < coordinateSubs.Split(',').Length; i++)
                                                    {
                                                        string toaDo = coordinateSubs.Split(',')[i];
                                                        toaDo = toaDo.Replace(@"[", @"");
                                                        toaDo = toaDo.Replace(@"]", @"");
                                                        toaDo = toaDo.Trim();
                                                        DanhMucTinhThanhToaDo danhMucTinhThanhToaDo = new DanhMucTinhThanhToaDo();
                                                        danhMucTinhThanhToaDo.Active = danhMucXaPhuong.Active;
                                                        danhMucTinhThanhToaDo.ParentID = danhMucXaPhuong.ID;
                                                        danhMucTinhThanhToaDo.DanhMucXaPhuongID = danhMucXaPhuong.ID;
                                                        danhMucTinhThanhToaDo.TypeName = danhMucXaPhuong.TypeName;
                                                        danhMucTinhThanhToaDo.Display = danhMucXaPhuong.Display;
                                                        danhMucTinhThanhToaDo.FileName = danhMucXaPhuong.FileName;
                                                        danhMucTinhThanhToaDo.Name = danhMucXaPhuong.Name;
                                                        danhMucTinhThanhToaDo.KinhDo = toaDo;
                                                        listDanhMucTinhThanhToaDo.Add(danhMucTinhThanhToaDo);
                                                    }

                                                    for (int i = 0; i < listDanhMucTinhThanhToaDo.Count; i = i + 2)
                                                    {
                                                        DanhMucTinhThanhToaDo model = listDanhMucTinhThanhToaDo[i];
                                                        model.ViDo = listDanhMucTinhThanhToaDo[i + 1].KinhDo;
                                                        DanhMucTinhThanhToaDo DanhMucTinhThanhToaDo = await _DanhMucTinhThanhToaDoService.GetByCondition(item => item.ParentID == model.ParentID && item.KinhDo == model.KinhDo && item.ViDo == model.ViDo).FirstOrDefaultAsync();
                                                        if (DanhMucTinhThanhToaDo == null)
                                                        {
                                                            await _DanhMucTinhThanhToaDoService.SaveAsync(model);
                                                        }
                                                        result.Add(model);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            string mes = e.Message;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }

            return result;
        }
    }
}

