namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ThongKeChiTietController : BaseController<ThongKeChiTiet, IThongKeChiTietService>
    {
        private readonly IThongKeChiTietService _ThongKeChiTietService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public ThongKeChiTietController(IThongKeChiTietService ThongKeChiTietService, IWebHostEnvironment WebHostEnvironment) : base(ThongKeChiTietService, WebHostEnvironment)
        {
            _ThongKeChiTietService = ThongKeChiTietService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("ReportAToaThuoc_MinhToListAsync")]
        public virtual async Task<List<ThongKeChiTiet>> ReportAToaThuoc_MinhToListAsync()
        {
            List<ThongKeChiTiet> result = new List<ThongKeChiTiet>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _ThongKeChiTietService.ReportAToaThuoc_MinhToListAsync(baseParameter.BatDau.Value, baseParameter.KetThuc.Value, baseParameter.SearchString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("ReportAToaThuoc_MinhToExcelAsync")]
        public async Task<JsonResult> ReportAToaThuoc_MinhToExcelAsync()
        {
            string result = GlobalHelper.InitializationString;
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                List<ThongKeChiTiet> ListThongKeChiTiet = await _ThongKeChiTietService.ReportAToaThuoc_MinhToListAsync(baseParameter.BatDau.Value, baseParameter.KetThuc.Value, baseParameter.SearchString);
                string fileName = @"Minh001_" + baseParameter.SearchString + "_" + GlobalHelper.InitializationDateTimeCode + ".xlsx";
                var streamExport = new MemoryStream();
                InitializationExcelReportAToaThuoc_Minh(ListThongKeChiTiet, streamExport);
                var physicalPathCreate = Path.Combine(_WebHostEnvironment.WebRootPath, GlobalHelper.Download, fileName);
                using (var stream = new FileStream(physicalPathCreate, FileMode.Create))
                {
                    streamExport.CopyTo(stream);
                }
                result = GlobalHelper.APISite + "/" + GlobalHelper.Download + "/" + fileName;
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return Json(result);
        }
        private void InitializationExcelReportAToaThuoc_Minh(List<ThongKeChiTiet> list, MemoryStream streamExport)
        {
            using (var package = new ExcelPackage(streamExport))
            {
                var workSheet = package.Workbook.Worksheets.Add("CamKet17");
                int row = 1;
                int column = 1;
                workSheet.Cells[row, column].Value = "STT";
                column = column + 1;
                workSheet.Cells[row, column].Value = "Ngày khám";
                column = column + 1;
                workSheet.Cells[row, column].Value = "Phòng khám";
                column = column + 1;
                workSheet.Cells[row, column].Value = "Bác sĩ";
                column = column + 1;
                workSheet.Cells[row, column].Value = "Mã dược";
                column = column + 1;
                workSheet.Cells[row, column].Value = "Dược phẩm";
                column = column + 1;
                workSheet.Cells[row, column].Value = "Số lượng toa thuốc (Kê)";
                column = column + 1;
                workSheet.Cells[row, column].Value = "Số lượng chứng từ (Bán)";
                column = column + 1;

                for (int i = 1; i < column; i++)
                {
                    workSheet.Cells[row, i].Style.Font.Bold = true;
                    workSheet.Cells[row, i].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    workSheet.Cells[row, i].Style.Font.Name = "Times New Roman";
                    workSheet.Cells[row, i].Style.Font.Size = 14;
                    workSheet.Cells[row, i].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                    workSheet.Cells[row, i].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    workSheet.Cells[row, i].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                    workSheet.Cells[row, i].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                }

                row = row + 1;
                int stt = 1;
                foreach (ThongKeChiTiet item in list)
                {
                    try
                    {
                        workSheet.Cells[row, 1].Value = stt;
                        workSheet.Cells[row, 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        if (item.DateTime001 == null)
                        {
                            workSheet.Cells[row, 2].Value = GlobalHelper.InitializationString;
                        }
                        else
                        {
                            workSheet.Cells[row, 2].Value = item.DateTime001.Value.ToString("dd/MM/yyyy");
                        }
                        workSheet.Cells[row, 3].Value = item.Name001;
                        workSheet.Cells[row, 4].Value = item.Name002;
                        workSheet.Cells[row, 5].Value = item.Name003;
                        workSheet.Cells[row, 6].Value = item.Name004;
                        workSheet.Cells[row, 7].Value = item.ThongKe001.Value.ToString("N0");
                        workSheet.Cells[row, 8].Value = item.ThongKe002.Value.ToString("N0");
                        for (int i = 1; i < column; i++)
                        {
                            workSheet.Cells[row, i].Style.Font.Name = "Times New Roman";
                            workSheet.Cells[row, i].Style.Font.Size = 14;
                            workSheet.Cells[row, i].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                            workSheet.Cells[row, i].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                            workSheet.Cells[row, i].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                            workSheet.Cells[row, i].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                            if (i > 6)
                            {
                                workSheet.Cells[row, i].Style.Font.Bold = true;
                                workSheet.Cells[row, i].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                            }
                        }
                        stt = stt + 1;
                        row = row + 1;
                    }
                    catch (Exception ex)
                    {
                        string mes = ex.Message;
                    }

                }
                for (int i = 1; i <= column; i++)
                {
                    workSheet.Column(i).AutoFit();
                }
                package.Save();
            }
            streamExport.Position = 0;
        }
    }
}

