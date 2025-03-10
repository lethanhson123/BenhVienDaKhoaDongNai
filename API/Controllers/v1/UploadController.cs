using Microsoft.EntityFrameworkCore;
using Service.Model;

namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class UploadController : BaseEmptyController<DanhMucPhongBan, IDanhMucPhongBanService>
    {
        private readonly IDanhMucPhongBanService _DanhMucPhongBanService;
        private readonly IWebHostEnvironment _WebHostEnvironment;

        private readonly IDanhMucTinhThanhToaDoService _DanhMucTinhThanhToaDoService;
        private readonly IDanhMucTinhThanhService _DanhMucTinhThanhService;
        private readonly IDanhMucQuanHuyenService _DanhMucQuanHuyenService;
        private readonly IDanhMucXaPhuongService _DanhMucXaPhuongService;

        private readonly IDanhMucChucDanhService _DanhMucChucDanhService;
        public UploadController(IDanhMucPhongBanService DanhMucPhongBanService, IWebHostEnvironment WebHostEnvironment

            , IDanhMucTinhThanhToaDoService DanhMucTinhThanhToaDoService
            , IDanhMucTinhThanhService DanhMucTinhThanhService
            , IDanhMucQuanHuyenService DanhMucQuanHuyenService
            , IDanhMucXaPhuongService DanhMucXaPhuongService

            , IDanhMucChucDanhService DanhMucChucDanhService

            ) : base(DanhMucPhongBanService, WebHostEnvironment)
        {
            _DanhMucPhongBanService = DanhMucPhongBanService;
            _WebHostEnvironment = WebHostEnvironment;

            _DanhMucTinhThanhToaDoService = DanhMucTinhThanhToaDoService;
            _DanhMucTinhThanhService = DanhMucTinhThanhService;
            _DanhMucQuanHuyenService = DanhMucQuanHuyenService;
            _DanhMucXaPhuongService = DanhMucXaPhuongService;

            _DanhMucChucDanhService = DanhMucChucDanhService;
        }
        [HttpPost]
        [Route("PostDanhMucTinhThanhToaDo3ByJSONFileAsync")]
        public virtual async Task<List<DanhMucTinhThanhToaDo>> PostDanhMucTinhThanhToaDo3ByJSONFileAsync()
        {
            List<DanhMucTinhThanhToaDo> result = new List<DanhMucTinhThanhToaDo>();
            DanhMucTinhThanhToaDo DanhMucTinhThanhToaDo = new DanhMucTinhThanhToaDo();
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
                        string folderPath = Path.Combine(_WebHostEnvironment.WebRootPath, GlobalHelper.Upload, DanhMucTinhThanhToaDo.GetType().Name);
                        bool isFolderExists = System.IO.Directory.Exists(folderPath);
                        if (!isFolderExists)
                        {
                            System.IO.Directory.CreateDirectory(folderPath);
                        }

                        string fileExtension = Path.GetExtension(file.FileName);
                        string fileName = "DanhMucTinhThanhToaDo3_" + GlobalHelper.InitializationDateTimeCode0001 + fileExtension;
                        var physicalPath = Path.Combine(_WebHostEnvironment.WebRootPath, GlobalHelper.Upload, DanhMucTinhThanhToaDo.GetType().Name, fileName);

                        using (var stream = new FileStream(physicalPath, FileMode.Create))
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
                                                        DanhMucTinhThanhToaDo DanhMucTinhThanhToaDoCheck = await _DanhMucTinhThanhToaDoService.GetByCondition(item => item.ParentID == model.ParentID && item.KinhDo == model.KinhDo && item.ViDo == model.ViDo).FirstOrDefaultAsync();
                                                        if (DanhMucTinhThanhToaDoCheck == null)
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
        [HttpPost]
        [Route("PostDanhMucPhongBanByExcelFileAsync")]
        public virtual async Task<DanhMucPhongBan> PostDanhMucPhongBanByExcelFileAsync()
        {
            BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
            DanhMucPhongBan result = new DanhMucPhongBan();
            List<DanhMucPhongBan> ListDanhMucPhongBan = await _DanhMucPhongBanService.GetAllToListAsync();
            if (Request.Form.Files.Count > 0)
            {
                var file = Request.Form.Files[0];
                if (file == null || file.Length == 0)
                {
                }
                if (file != null)
                {
                    string folderPath = Path.Combine(_WebHostEnvironment.WebRootPath, GlobalHelper.Upload, result.GetType().Name);
                    bool isFolderExists = System.IO.Directory.Exists(folderPath);
                    if (!isFolderExists)
                    {
                        System.IO.Directory.CreateDirectory(folderPath);
                    }
                    string fileExtension = Path.GetExtension(file.FileName);
                    string fileName = result.GetType().Name + "_" + GlobalHelper.InitializationDateTimeCode0001 + fileExtension;
                    var physicalPath = Path.Combine(_WebHostEnvironment.WebRootPath, GlobalHelper.Upload, result.GetType().Name, fileName);
                    using (var stream = new FileStream(physicalPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                    try
                    {
                        FileInfo fileLocation = new FileInfo(physicalPath);
                        if (fileLocation.Length > 0)
                        {
                            if ((fileExtension == ".xlsx") || (fileExtension == ".xls"))
                            {
                                using (ExcelPackage package = new ExcelPackage(fileLocation))
                                {
                                    if (package.Workbook.Worksheets.Count > 0)
                                    {
                                        ExcelWorksheet workSheet = package.Workbook.Worksheets[1];
                                        if (workSheet != null)
                                        {
                                            int totalRows = workSheet.Dimension.Rows;
                                            for (int i = 2; i <= totalRows; i++)
                                            {
                                                try
                                                {
                                                    DanhMucPhongBan DanhMucPhongBan = new DanhMucPhongBan();
                                                    if (workSheet.Cells[i, 1].Value != null)
                                                    {
                                                        DanhMucPhongBan.Code = workSheet.Cells[i, 1].Value.ToString().Trim();
                                                        DanhMucPhongBan = ListDanhMucPhongBan.Where(item => item.Code == DanhMucPhongBan.Code).FirstOrDefault();
                                                        if (DanhMucPhongBan != null)
                                                        {
                                                            if (DanhMucPhongBan.ID > 0)
                                                            {
                                                                if (workSheet.Cells[i, 3].Value != null)
                                                                {
                                                                    try
                                                                    {
                                                                        DanhMucPhongBan.GroupOrder = int.Parse(workSheet.Cells[i, 3].Value.ToString().Trim());
                                                                    }
                                                                    catch (Exception ex)
                                                                    {
                                                                        string message = ex.Message;
                                                                    }
                                                                }
                                                                if (workSheet.Cells[i, 4].Value != null)
                                                                {
                                                                    try
                                                                    {
                                                                        DanhMucPhongBan.SortOrder = int.Parse(workSheet.Cells[i, 4].Value.ToString().Trim());
                                                                    }
                                                                    catch (Exception ex)
                                                                    {
                                                                        string message = ex.Message;
                                                                    }
                                                                }
                                                                await _DanhMucPhongBanService.SaveAsync(DanhMucPhongBan);
                                                            }
                                                        }
                                                    }
                                                }
                                                catch (Exception ex)
                                                {
                                                    string message = ex.Message;
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
            return result;
        }
        [HttpPost]
        [Route("PostDanhMucChucDanhByExcelFileAsync")]
        public virtual async Task<DanhMucChucDanh> PostDanhMucChucDanhByExcelFileAsync()
        {
            BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
            DanhMucChucDanh result = new DanhMucChucDanh();
            List<DanhMucChucDanh> ListDanhMucChucDanh = await _DanhMucChucDanhService.GetAllToListAsync();

            if (Request.Form.Files.Count > 0)
            {
                var file = Request.Form.Files[0];
                if (file == null || file.Length == 0)
                {
                }
                if (file != null)
                {
                    string folderPath = Path.Combine(_WebHostEnvironment.WebRootPath, GlobalHelper.Upload, result.GetType().Name);
                    bool isFolderExists = System.IO.Directory.Exists(folderPath);
                    if (!isFolderExists)
                    {
                        System.IO.Directory.CreateDirectory(folderPath);
                    }
                    string fileExtension = Path.GetExtension(file.FileName);
                    string fileName = result.GetType().Name + "_" + GlobalHelper.InitializationDateTimeCode0001 + fileExtension;
                    var physicalPath = Path.Combine(_WebHostEnvironment.WebRootPath, GlobalHelper.Upload, result.GetType().Name, fileName);
                    using (var stream = new FileStream(physicalPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                    try
                    {
                        FileInfo fileLocation = new FileInfo(physicalPath);
                        if (fileLocation.Length > 0)
                        {
                            if ((fileExtension == ".xlsx") || (fileExtension == ".xls"))
                            {
                                using (ExcelPackage package = new ExcelPackage(fileLocation))
                                {
                                    if (package.Workbook.Worksheets.Count > 0)
                                    {
                                        ExcelWorksheet workSheet = package.Workbook.Worksheets[1];
                                        if (workSheet != null)
                                        {
                                            int totalRows = workSheet.Dimension.Rows;
                                            for (int i = 2; i <= totalRows; i++)
                                            {
                                                try
                                                {
                                                    DanhMucChucDanh DanhMucChucDanh = new DanhMucChucDanh();
                                                    if (workSheet.Cells[i, 1].Value != null)
                                                    {
                                                        DanhMucChucDanh.Name = workSheet.Cells[i, 1].Value.ToString().Trim();
                                                        DanhMucChucDanh = ListDanhMucChucDanh.Where(item => DanhMucChucDanh.Name.Contains(item.Name)).FirstOrDefault();
                                                        if (DanhMucChucDanh != null)
                                                        {
                                                            if (DanhMucChucDanh.ID > 0)
                                                            {
                                                                if (workSheet.Cells[i, 2].Value != null)
                                                                {
                                                                    try
                                                                    {
                                                                        DanhMucChucDanh.GroupOrder = int.Parse(workSheet.Cells[i, 2].Value.ToString().Trim());
                                                                    }
                                                                    catch (Exception ex)
                                                                    {
                                                                        string message = ex.Message;
                                                                    }
                                                                }
                                                                if (workSheet.Cells[i, 3].Value != null)
                                                                {
                                                                    try
                                                                    {
                                                                        DanhMucChucDanh.SortOrder = int.Parse(workSheet.Cells[i, 3].Value.ToString().Trim());
                                                                    }
                                                                    catch (Exception ex)
                                                                    {
                                                                        string message = ex.Message;
                                                                    }
                                                                }
                                                                await _DanhMucChucDanhService.SaveAsync(DanhMucChucDanh);
                                                            }
                                                        }
                                                    }
                                                }
                                                catch (Exception ex)
                                                {
                                                    string message = ex.Message;
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
            return result;
        }
    }
}

