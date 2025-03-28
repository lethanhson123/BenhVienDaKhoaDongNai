using System.Data.SqlClient;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;

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
        [HttpGet]
        [Route("BaoHiemXaHoiAsync")]
        public async Task<string> BaoHiemXaHoiAsync()
        {
            string result = GlobalHelper.InitializationString;
            try
            {
                //ThongTinBenhNhan ThongTinBenhNhan = new ThongTinBenhNhan();
                //ThongTinBenhNhan.maThe = "GD4757523268412";
                //ThongTinBenhNhan.hoTen = "NGUYỄN KHÁNH HIỀN";
                //ThongTinBenhNhan.ngaySinh = "1952";
                //ThongTinBenhNhan.hoTenCb = "Nguyễn Khánh Thoại";
                //ThongTinBenhNhan.cccdCb = "075087002073";
                //string _serviceURL = "http://10.84.2.177:8083/";
                //using (HttpClient httpClient = new HttpClient())
                //{
                //    httpClient.BaseAddress = new Uri(_serviceURL);
                //    httpClient.DefaultRequestHeaders.Accept.Clear();
                //    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //    HttpResponseMessage result2 = httpClient.PostAsJsonAsync("/CheckTheBHYT", ThongTinBenhNhan).Result;
                //    if (result2.IsSuccessStatusCode)
                //    {
                //        try
                //        {
                //            var result3 = result2.Content.ReadAsStringAsync().Result;
                //            KQLichSuKCB KQLichSuKCB = JsonConvert.DeserializeObject<KQLichSuKCB>(result3);
                //        }
                //        catch (Exception ex)
                //        {
                //        }
                //    }
                //}


                string username = "75001_075087002073";
                string PasswordDecrypt = "Thoai@123";
                string password = "Thoai@123";
                MD5 md5 = new MD5CryptoServiceProvider();
                md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(PasswordDecrypt));
                byte[] PasswordResult = md5.Hash;
                StringBuilder strBuilder = new StringBuilder();
                for (int i = 0; i < PasswordResult.Length; i++)
                {
                    strBuilder.Append(PasswordResult[i].ToString("x2"));
                }

                password = strBuilder.ToString();
                result = password;

                string URL = "https://egw.baohiemxahoi.gov.vn/api/token/take";
                HttpClient HttpClient = new HttpClient();
                StringContent HttpContent = new StringContent(@"{ ""username"": """ + username + @""", ""password"": """ + password + @""" }", Encoding.UTF8, "application/json");
                var response = await HttpClient.PostAsync(URL, HttpContent);

                var resultAPI = await response.Content.ReadAsStringAsync();

                BaoHiemXaHoi BaoHiemXaHoi = JsonConvert.DeserializeObject<BaoHiemXaHoi>(resultAPI);

                if (BaoHiemXaHoi.maKetQua == "200")
                {
                    string maThe = "GD4757523268412";
                    string hoTen = "NGUYỄN KHÁNH HIỀN";
                    string ngaySinh = "1952";
                    string hoTenCb = "Nguyễn Khánh Thoại";
                    string cccdCb = "075087002073";

                    //string URL001 = "http://egw.baohiemxahoi.gov.vn/api/egw/KQNhanLichSuKCB2019?token=" + BaoHiemXaHoi.APIKey.access_token + "&id_token=" + BaoHiemXaHoi.APIKey.id_token + "&username=" + username + "&password=" + password;
                    string URL001 = "https://egw.baohiemxahoi.gov.vn/api/egw/KQNhanLichSuKCB2024";
                    HttpClient HttpClient001 = new HttpClient();
                    StringContent HttpContent001 = new StringContent(@"{ ""maThe"": """ + maThe + @""", ""hoTen"": """ + hoTen + @""", ""ngaySinh"": """ + ngaySinh + @""", ""hoTenCb"": """ + hoTenCb + @""", ""cccdCb"": """ + cccdCb + @"""}", Encoding.UTF8, "application/json");
                    //StringContent HttpContent001 = new StringContent(@"{ ""maThe"": """ + maThe + @""", ""hoTen"": """ + hoTen + @""", ""ngaySinh"": """ + ngaySinh + @"""}", Encoding.UTF8, "application/json");
                    HttpClient001.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", BaoHiemXaHoi.APIKey.access_token);
                    var response001 = await HttpClient001.PostAsync(URL001, HttpContent001);

                    var resultAPI001 = await response001.Content.ReadAsStringAsync();


                }

                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                //var httpWebRequest = (HttpWebRequest)WebRequest.Create(URL);
                //httpWebRequest.ContentType = "application/json";
                //httpWebRequest.Method = "POST";

                //using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                //{
                //    string json = @"{""username"": """ + username + @""",""password"":""" + password + @"""}";
                //    streamWriter.Write(json);
                //}

                //var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                //using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                //{
                //    var resultAPI = streamReader.ReadToEnd();

                //    BaoHiemXaHoi BaoHiemXaHoi = JsonConvert.DeserializeObject<BaoHiemXaHoi>(resultAPI);

                //    string URL001 = "https://egw.baohiemxahoi.gov.vn/api/egw/KQNhanLichSuKCB2024";
                //    string maThe = "GD4757523268412";
                //    string hoTen = "NGUYỄN KHÁNH HIỀN";
                //    string ngaySinh = "1952";
                //    string hoTenCb = "Nguyễn Khánh Thoại";
                //    string cccdCb = "075087002073";

                //    var httpWebRequest001 = (HttpWebRequest)WebRequest.Create(URL001);
                //    httpWebRequest001.ContentType = "application/json";
                //    httpWebRequest001.Method = "POST";
                //    httpWebRequest001.Headers

                //    using (var streamWriter001 = new StreamWriter(httpWebRequest001.GetRequestStream()))
                //    {
                //        string json001 = @"{""maThe"": """ + maThe + @""",""hoTen"":""" + hoTen + @""",""ngaySinh"":""" + ngaySinh + @""",""hoTenCb"":""" + hoTenCb + @""",""cccdCb"":""" + cccdCb + @"""}";
                //        streamWriter001.Write(json001);
                //    }

                //}
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("BaoHiemXaHoiKiemTraThongTuyenAsync")]
        public async Task<string> BaoHiemXaHoiKiemTraThongTuyenAsync()
        {
            string result = GlobalHelper.InitializationString;
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);                
                baseParameter.ThongTinBenhNhan.hoTenCb = GlobalHelper.BaoHiemXaHoihoTenCb;
                baseParameter.ThongTinBenhNhan.cccdCb = GlobalHelper.BaoHiemXaHoicccdCb;
                string _serviceURL = GlobalHelper.BaoHiemXaHoiAPISite;
                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri(_serviceURL);
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage result2 = httpClient.PostAsJsonAsync(GlobalHelper.BaoHiemXaHoiController, baseParameter.ThongTinBenhNhan).Result;
                    if (result2.IsSuccessStatusCode)
                    {
                        try
                        {
                            var result3 = result2.Content.ReadAsStringAsync().Result;
                            KQLichSuKCB KQLichSuKCB = JsonConvert.DeserializeObject<KQLichSuKCB>(result3);
                        }
                        catch (Exception ex)
                        {
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

