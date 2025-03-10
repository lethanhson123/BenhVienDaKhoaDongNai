using System.Data.SqlClient;

namespace APIReport.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ReportController : BaseController<Report, IReportService>
    {
        private readonly IReportService _ReportService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public ReportController(IReportService ReportService, IWebHostEnvironment WebHostEnvironment) : base(ReportService, WebHostEnvironment)
        {
            _ReportService = ReportService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("ReportDictionary0001ToListAsync")]
        public async Task<List<Report>> ReportDictionary0001ToListAsync()
        {
            List<Report> result = new List<Report>();
            try
            {
                result = await _ReportService.ReportDictionary0001ToListAsync();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("ReportDictionary0002ToListAsync")]
        public async Task<List<Report>> ReportDictionary0002ToListAsync()
        {
            List<Report> result = new List<Report>();
            try
            {
                result = await _ReportService.ReportDictionary0002ToListAsync();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("ReportDictionary0003ToListAsync")]
        public async Task<List<Report>> ReportDictionary0003ToListAsync()
        {
            List<Report> result = new List<Report>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _ReportService.ReportDictionary0003ToListAsync(baseParameter.Year.Value);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("ReportDictionary0004ToListAsync")]
        public async Task<List<Report>> ReportDictionary0004ToListAsync()
        {
            List<Report> result = new List<Report>();
            Report model = new Report();
            try
            {                
                result = await _ReportService.ReportDictionary0004ToListAsync();
                string folderPathRoot = Path.Combine(_WebHostEnvironment.WebRootPath, model.GetType().Name);
                bool isFolderExists = System.IO.Directory.Exists(folderPathRoot);
                if (!isFolderExists)
                {
                    System.IO.Directory.CreateDirectory(folderPathRoot);
                }
                string fileName = model.GetType().Name + ".json";
                string path = Path.Combine(folderPathRoot, fileName);
                bool isFileExists = System.IO.File.Exists(path);
                if (!isFileExists)
                {                    
                    string json = JsonConvert.SerializeObject(result);
                    using (FileStream fs = new FileStream(path, FileMode.Create))
                    {
                        using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                        {
                            w.WriteLine(json);
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
        [Route("ReportA0001ToListAsync")]
        public async Task<List<Report>> ReportA0001ToListAsync()
        {
            List<Report> result = new List<Report>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _ReportService.ReportA0001ToListAsync(baseParameter.Year.Value, baseParameter.Month.Value, baseParameter.Day.Value, baseParameter.PhongBanID.Value);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("ReportNSTLA0001ToListAsync")]
        public async Task<List<Report>> ReportNSTLA0001ToListAsync()
        {
            List<Report> result = new List<Report>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _ReportService.ReportNSTLA0001ToListAsync();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("ReportNSTLA0002ToListAsync")]
        public async Task<List<Report>> ReportNSTLA0002ToListAsync()
        {
            List<Report> result = new List<Report>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _ReportService.ReportNSTLA0002ToListAsync();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        //[HttpPost]
        //[Route("CovertDataAsync")]
        //public async Task<List<Report>> CovertDataAsync()
        //{
        //    List<Report> result = new List<Report>();
        //    try
        //    {
        //        DataTable dataTable = new DataTable();
        //        using (SqlConnection cn = new SqlConnection(GlobalHelper.SQLServerConectionString_NewComet_NSTL_A))
        //        {
        //            string sql = "select * from Lst_Dictionary (nolock) where Dictionary_Type_Code='ChucDanh'";
        //            SqlDataAdapter adapter = new SqlDataAdapter(sql, cn);
        //            cn.Open();
        //            adapter.Fill(dataTable);
        //        }
        //        using (SqlConnection cn = new SqlConnection(GlobalHelper.SQLServerConectionString))
        //        {
        //            foreach (DataRow row in dataTable.Rows)
        //            {                      
                      
        //                StringBuilder txt = new StringBuilder();
        //                txt.Append(@"INSERT INTO DanhMucChucDanh(ID, Code, Name, Active, ParentID, ParentName)");
        //                txt.Append(@"VALUES(");
        //                txt.Append(@"" + row["Dictionary_Id"]);
        //                txt.Append(@",'" + row["Dictionary_Code"] + "'");
        //                txt.Append(@",N'" + row["Dictionary_Name"] + "'");
        //                txt.Append(@",'" + row["Enabled"] + "'");
        //                txt.Append(@"," + row["Dictionary_Type_Id"]);
        //                txt.Append(@",'" + row["Dictionary_Type_Code"] + "'");                       
        //                txt.Append(@")");
        //                string sql = txt.ToString();
        //                SqlCommand cmd = new SqlCommand(sql, cn);
        //                cmd.CommandType = CommandType.Text;
        //                try
        //                {
        //                    cn.Open();
        //                    int ret = cmd.ExecuteNonQuery();
        //                    cn.Close();
        //                }
        //                catch (Exception ex)
        //                {
        //                    string mes = ex.Message;
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string mes = ex.Message;
        //    }
        //    return result;
        //}
    }
}

