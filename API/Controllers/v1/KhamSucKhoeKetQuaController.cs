namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class KhamSucKhoeKetQuaController : BaseController<KhamSucKhoeKetQua, IKhamSucKhoeKetQuaService>
    {
        private readonly IKhamSucKhoeKetQuaService _KhamSucKhoeKetQuaService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public KhamSucKhoeKetQuaController(IKhamSucKhoeKetQuaService KhamSucKhoeKetQuaService, IWebHostEnvironment WebHostEnvironment) : base(KhamSucKhoeKetQuaService, WebHostEnvironment)
        {
            _KhamSucKhoeKetQuaService = KhamSucKhoeKetQuaService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("SaveListByExcelFileAsync")]
        public virtual async Task<List<KhamSucKhoeKetQua>> SaveListByExcelFileAsync()
        {
            List<KhamSucKhoeKetQua> result = new List<KhamSucKhoeKetQua>();
            KhamSucKhoeKetQua KhamSucKhoeKetQua = new KhamSucKhoeKetQua();
            try
            {
                if (Request.Form.Files.Count > 0)
                {
                    BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                    var file = Request.Form.Files[0];
                    if (file == null || file.Length == 0)
                    {
                    }
                    if (file != null)
                    {
                        string fileExtension = Path.GetExtension(file.FileName);
                        string fileName = KhamSucKhoeKetQua.GetType().Name + "_" + GlobalHelper.InitializationDateTimeCode0001 + fileExtension;
                        var physicalPath = Path.Combine(_WebHostEnvironment.WebRootPath, GlobalHelper.Upload, fileName);
                        using (var stream = new FileStream(physicalPath, FileMode.Create))
                        {
                            file.CopyTo(stream);
                        }
                        try
                        {
                            FileInfo fileLocation = new FileInfo(physicalPath);
                            if (fileLocation.Length > 0)
                            {
                                if (fileExtension == ".xlsx" || fileExtension == ".xls")
                                {
                                    using (ExcelPackage package = new ExcelPackage(fileLocation))
                                    {
                                        if (package.Workbook.Worksheets.Count > 0)
                                        {
                                            ExcelWorksheet workSheet = package.Workbook.Worksheets[1];
                                            if (workSheet != null)
                                            {
                                                int totalRows = workSheet.Dimension.Rows;
                                                for (int i = 12; i <= totalRows; i++)
                                                {
                                                    KhamSucKhoeKetQua = new KhamSucKhoeKetQua();
                                                    KhamSucKhoeKetQua.ParentID = baseParameter.ParentID;
                                                    if (workSheet.Cells[i, 2].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.SoThe = workSheet.Cells[i, 2].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 3].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.HoTen = workSheet.Cells[i, 3].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 4].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.GioiTinh = workSheet.Cells[i, 4].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 5].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.BoPhan = workSheet.Cells[i, 5].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 6].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.NgaySinh = workSheet.Cells[i, 6].Value.ToString().Trim();
                                                        KhamSucKhoeKetQua.NgaySinh = KhamSucKhoeKetQua.NgaySinh.Split(' ')[0];
                                                    }
                                                    if (workSheet.Cells[i, 7].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.PhanLoaiSucKhoe = workSheet.Cells[i, 7].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 8].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.ChieuCao = workSheet.Cells[i, 8].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 9].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.CanNang = workSheet.Cells[i, 9].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 10].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.Mach = workSheet.Cells[i, 10].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 11].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.HuyetAp = workSheet.Cells[i, 11].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 12].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.Noi = workSheet.Cells[i, 12].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 13].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.Ngoai = workSheet.Cells[i, 13].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 14].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.Mat = workSheet.Cells[i, 14].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 15].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.TaiMuiHong = workSheet.Cells[i, 15].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 16].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.RangHamMat = workSheet.Cells[i, 16].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 17].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.LamSang = workSheet.Cells[i, 17].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 18].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.PhuSanTienSu = workSheet.Cells[i, 18].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 19].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.PhuSanKhamLamSang = workSheet.Cells[i, 19].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 20].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.PhuSanPAPSMEAR = workSheet.Cells[i, 20].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 21].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.SieuAmTongQuat = workSheet.Cells[i, 21].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 22].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.SieuAmPhuKhoa = workSheet.Cells[i, 22].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 23].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.SieuAmTuyenVu = workSheet.Cells[i, 23].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 24].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.ViemGanSieuViA = workSheet.Cells[i, 24].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 25].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.ViemGanSieuViE = workSheet.Cells[i, 25].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 26].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.HBsAb = workSheet.Cells[i, 26].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 27].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.HbA1C = workSheet.Cells[i, 27].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 28].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.CystatineC = workSheet.Cells[i, 28].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 29].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.Glucose = workSheet.Cells[i, 29].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 30].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.CHO = workSheet.Cells[i, 30].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 31].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.TRI = workSheet.Cells[i, 31].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 32].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.HDL = workSheet.Cells[i, 32].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 33].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.LDL = workSheet.Cells[i, 33].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 34].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.TPT = workSheet.Cells[i, 34].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 35].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.TeBaoMauNgoaiVi = workSheet.Cells[i, 35].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 36].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.XQuangPhoi = workSheet.Cells[i, 36].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 37].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.CanLamSangLamThem = workSheet.Cells[i, 37].Value.ToString().Trim();
                                                    }
                                                    if (workSheet.Cells[i, 38].Value != null)
                                                    {
                                                        KhamSucKhoeKetQua.Note = workSheet.Cells[i, 38].Value.ToString().Trim();
                                                    }
                                                    await _KhamSucKhoeKetQuaService.SaveAsync(KhamSucKhoeKetQua);
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
            catch (Exception e)
            {
                string mes = e.Message;
            }
            if (result == null)
            {
                result = new List<KhamSucKhoeKetQua>();
            }
            return result;
        }
    }
}

