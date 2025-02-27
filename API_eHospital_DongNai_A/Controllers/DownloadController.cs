using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using System.IO.Compression;

namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DownloadController : BaseController<XML1_CV130, IXML1_CV130Service>
    {
        private readonly IXML1_CV130Service _XML1_CV130Service;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DownloadController(IXML1_CV130Service XML1_CV130Service, IWebHostEnvironment WebHostEnvironment) : base(XML1_CV130Service, WebHostEnvironment)
        {
            _XML1_CV130Service = XML1_CV130Service;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("CreateXMLCV130Async")]
        public virtual async Task<JsonResult> CreateXMLCV130Async()
        {
            string result = GlobalHelper.InitializationString;
            try
            {
                DateTime NGAYLAP = GlobalHelper.InitializationDateTime;
                List<XML1_CV130> ListXML1_CV130 = JsonConvert.DeserializeObject<List<XML1_CV130>>(Request.Form["ListXML1_CV130"]);
                List<XML2_CV130> ListXML2_CV130 = JsonConvert.DeserializeObject<List<XML2_CV130>>(Request.Form["ListXML2_CV130"]);
                List<XML3_CV130> ListXML3_CV130 = JsonConvert.DeserializeObject<List<XML3_CV130>>(Request.Form["ListXML3_CV130"]);
                List<XML4_CV130> ListXML4_CV130 = JsonConvert.DeserializeObject<List<XML4_CV130>>(Request.Form["ListXML4_CV130"]);
                List<XML5_CV130> ListXML5_CV130 = JsonConvert.DeserializeObject<List<XML5_CV130>>(Request.Form["ListXML5_CV130"]);
                List<XML6_CV130> ListXML6_CV130 = JsonConvert.DeserializeObject<List<XML6_CV130>>(Request.Form["ListXML6_CV130"]);
                List<XML7_CV130> ListXML7_CV130 = JsonConvert.DeserializeObject<List<XML7_CV130>>(Request.Form["ListXML7_CV130"]);
                List<XML8_CV130> ListXML8_CV130 = JsonConvert.DeserializeObject<List<XML8_CV130>>(Request.Form["ListXML8_CV130"]);
                List<XML9_CV130> ListXML9_CV130 = JsonConvert.DeserializeObject<List<XML9_CV130>>(Request.Form["ListXML9_CV130"]);
                List<XML10_CV130> ListXML10_CV130 = JsonConvert.DeserializeObject<List<XML10_CV130>>(Request.Form["ListXML10_CV130"]);
                List<XML11_CV130> ListXML11_CV130 = JsonConvert.DeserializeObject<List<XML11_CV130>>(Request.Form["ListXML11_CV130"]);
                List<XML12_CV130> ListXML12_CV130 = JsonConvert.DeserializeObject<List<XML12_CV130>>(Request.Form["ListXML12_CV130"]);
                List<XML13_CV130> ListXML13_CV130 = JsonConvert.DeserializeObject<List<XML13_CV130>>(Request.Form["ListXML13_CV130"]);
                List<XML14_CV130> ListXML14_CV130 = JsonConvert.DeserializeObject<List<XML14_CV130>>(Request.Form["ListXML14_CV130"]);
                List<XML15_CV130> ListXML15_CV130 = JsonConvert.DeserializeObject<List<XML15_CV130>>(Request.Form["ListXML15_CV130"]);

                XMLCV130Tag XMLCV130Tag = new XMLCV130Tag();
                try
                {
                    string fileName01 = XMLCV130Tag.GetType().Name + ".json";
                    string path01 = Path.Combine(_WebHostEnvironment.WebRootPath, fileName01);
                    bool isFileExists = System.IO.File.Exists(path01);
                    if (!isFileExists)
                    {
                        string json = JsonConvert.SerializeObject(XMLCV130Tag);
                        using (FileStream fs = new FileStream(path01, FileMode.Create))
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

                }
                try
                {
                    string fileName02 = XMLCV130Tag.GetType().Name + ".json";
                    string path02 = Path.Combine(_WebHostEnvironment.WebRootPath, fileName02);
                    bool isFileExists = System.IO.File.Exists(path02);
                    if (isFileExists)
                    {
                        using (FileStream fs = new FileStream(path02, FileMode.Open))
                        {
                            using (StreamReader r = new StreamReader(fs, Encoding.UTF8))
                            {
                                string json = r.ReadToEnd();
                                XMLCV130Tag = JsonConvert.DeserializeObject<XMLCV130Tag>(json);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                }




                string NGAYLAPString = @"" + NGAYLAP.Year;
                if (NGAYLAP.Month > 9)
                {
                    NGAYLAPString = NGAYLAPString + NGAYLAP.Month;
                }
                else
                {
                    NGAYLAPString = NGAYLAPString + @"0" + NGAYLAP.Month;
                }
                if (NGAYLAP.Day > 9)
                {
                    NGAYLAPString = NGAYLAPString + NGAYLAP.Day;
                }
                else
                {
                    NGAYLAPString = NGAYLAPString + @"0" + NGAYLAP.Day;
                }
                StringBuilder XMLTong = new StringBuilder();
                XMLTong.AppendLine(GlobalHelper.XMLHeader);

                XMLTong.AppendLine(@"<GIAMDINHHS>");
                XMLTong.AppendLine(@"<THONGTINDONVI>");
                XMLTong.AppendLine(@"<MACSKCB>" + GlobalHelper.MACSKCB + @"</MACSKCB>");
                XMLTong.AppendLine(@"</THONGTINDONVI>");
                XMLTong.AppendLine(@"<THONGTINHOSO>");
                XMLTong.AppendLine(@"<NGAYLAP>" + NGAYLAPString + "</NGAYLAP>");
                XMLTong.AppendLine(@"<SOLUONGHOSO>" + ListXML1_CV130.Count + "</SOLUONGHOSO>");
                XMLTong.AppendLine(@"<DANHSACHHOSO>");


                StringBuilder XMLEncode = new StringBuilder();
                XMLEncode.AppendLine(GlobalHelper.XMLHeader);

                XMLEncode.AppendLine(@"<GIAMDINHHS>");
                XMLEncode.AppendLine(@"<THONGTINDONVI>");
                XMLEncode.AppendLine(@"<MACSKCB>" + GlobalHelper.MACSKCB + @"</MACSKCB>");
                XMLEncode.AppendLine(@"</THONGTINDONVI>");
                XMLEncode.AppendLine(@"<THONGTINHOSO>");
                XMLEncode.AppendLine(@"<NGAYLAP>" + NGAYLAPString + "</NGAYLAP>");
                XMLEncode.AppendLine(@"<SOLUONGHOSO>" + ListXML1_CV130.Count + "</SOLUONGHOSO>");
                XMLEncode.AppendLine(@"<DANHSACHHOSO>");


                foreach (XML1_CV130 XML1_CV130 in ListXML1_CV130)
                {
                    List<XML2_CV130> ListXML2_CV130Sub = ListXML2_CV130.Where(item => item.MA_LK == XML1_CV130.MA_LK).ToList();
                    List<XML3_CV130> ListXML3_CV130Sub = ListXML3_CV130.Where(item => item.MA_LK == XML1_CV130.MA_LK).ToList();
                    List<XML4_CV130> ListXML4_CV130Sub = ListXML4_CV130.Where(item => item.MA_LK == XML1_CV130.MA_LK).ToList();
                    List<XML5_CV130> ListXML5_CV130Sub = ListXML5_CV130.Where(item => item.MA_LK == XML1_CV130.MA_LK).ToList();
                    List<XML6_CV130> ListXML6_CV130Sub = ListXML6_CV130.Where(item => item.MA_LK == XML1_CV130.MA_LK).ToList();
                    List<XML7_CV130> ListXML7_CV130Sub = ListXML7_CV130.Where(item => item.MA_LK == XML1_CV130.MA_LK).ToList();
                    List<XML8_CV130> ListXML8_CV130Sub = ListXML8_CV130.Where(item => item.MA_LK == XML1_CV130.MA_LK).ToList();
                    List<XML9_CV130> ListXML9_CV130Sub = ListXML9_CV130.Where(item => item.MA_LK == XML1_CV130.MA_LK).ToList();
                    List<XML10_CV130> ListXML10_CV130Sub = ListXML10_CV130.Where(item => item.MA_LK == XML1_CV130.MA_LK).ToList();
                    List<XML11_CV130> ListXML11_CV130Sub = ListXML11_CV130.Where(item => item.MA_LK == XML1_CV130.MA_LK).ToList();
                    List<XML12_CV130> ListXML12_CV130Sub = ListXML12_CV130.Where(item => item.MA_THE_BHYT == XML1_CV130.MA_THE_BHYT).ToList();
                    List<XML13_CV130> ListXML13_CV130Sub = ListXML13_CV130.Where(item => item.MA_LK == XML1_CV130.MA_LK).ToList();
                    List<XML14_CV130> ListXML14_CV130Sub = ListXML14_CV130.Where(item => item.MA_LK == XML1_CV130.MA_LK).ToList();
                    List<XML15_CV130> ListXML15_CV130Sub = ListXML15_CV130.Where(item => item.MA_LK == XML1_CV130.MA_LK).ToList();

                    string XML1NOIDUNGFILE = CreateXML1(XML1_CV130, XMLCV130Tag);
                    string XML2NOIDUNGFILE = CreateXML2(ListXML2_CV130Sub, XMLCV130Tag);
                    string XML3NOIDUNGFILE = CreateXML3(ListXML3_CV130Sub, XMLCV130Tag);
                    string XML4NOIDUNGFILE = CreateXML4(ListXML4_CV130Sub, XMLCV130Tag);
                    string XML5NOIDUNGFILE = CreateXML5(ListXML5_CV130Sub, XMLCV130Tag);
                    string XML6NOIDUNGFILE = CreateXML6(ListXML6_CV130Sub, XMLCV130Tag);
                    string XML7NOIDUNGFILE = CreateXML7(ListXML7_CV130Sub, XMLCV130Tag);
                    string XML8NOIDUNGFILE = CreateXML8(ListXML8_CV130Sub, XMLCV130Tag);
                    string XML9NOIDUNGFILE = CreateXML9(ListXML9_CV130Sub, XMLCV130Tag);
                    string XML10NOIDUNGFILE = CreateXML10(ListXML10_CV130Sub, XMLCV130Tag);
                    string XML11NOIDUNGFILE = CreateXML11(ListXML11_CV130Sub, XMLCV130Tag);
                    string XML12NOIDUNGFILE = CreateXML12(ListXML12_CV130Sub, XMLCV130Tag);
                    string XML13NOIDUNGFILE = CreateXML13(ListXML13_CV130Sub, XMLCV130Tag);
                    string XML14NOIDUNGFILE = CreateXML14(ListXML14_CV130Sub, XMLCV130Tag);
                    string XML15NOIDUNGFILE = CreateXML15(ListXML15_CV130, XMLCV130Tag);

                    var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(XML1NOIDUNGFILE);
                    string XML1NOIDUNGFILEBase64Encode = System.Convert.ToBase64String(plainTextBytes);
                    plainTextBytes = System.Text.Encoding.UTF8.GetBytes(XML2NOIDUNGFILE);
                    string XML2NOIDUNGFILEBase64Encode = System.Convert.ToBase64String(plainTextBytes);
                    plainTextBytes = System.Text.Encoding.UTF8.GetBytes(XML3NOIDUNGFILE);
                    string XML3NOIDUNGFILEBase64Encode = System.Convert.ToBase64String(plainTextBytes);
                    plainTextBytes = System.Text.Encoding.UTF8.GetBytes(XML4NOIDUNGFILE);
                    string XML4NOIDUNGFILEBase64Encode = System.Convert.ToBase64String(plainTextBytes);
                    plainTextBytes = System.Text.Encoding.UTF8.GetBytes(XML5NOIDUNGFILE);
                    string XML5NOIDUNGFILEBase64Encode = System.Convert.ToBase64String(plainTextBytes);
                    plainTextBytes = System.Text.Encoding.UTF8.GetBytes(XML6NOIDUNGFILE);
                    string XML6NOIDUNGFILEBase64Encode = System.Convert.ToBase64String(plainTextBytes);
                    plainTextBytes = System.Text.Encoding.UTF8.GetBytes(XML7NOIDUNGFILE);
                    string XML7NOIDUNGFILEBase64Encode = System.Convert.ToBase64String(plainTextBytes);
                    plainTextBytes = System.Text.Encoding.UTF8.GetBytes(XML8NOIDUNGFILE);
                    string XML8NOIDUNGFILEBase64Encode = System.Convert.ToBase64String(plainTextBytes);
                    plainTextBytes = System.Text.Encoding.UTF8.GetBytes(XML9NOIDUNGFILE);
                    string XML9NOIDUNGFILEBase64Encode = System.Convert.ToBase64String(plainTextBytes);
                    plainTextBytes = System.Text.Encoding.UTF8.GetBytes(XML10NOIDUNGFILE);
                    string XML10NOIDUNGFILEBase64Encode = System.Convert.ToBase64String(plainTextBytes);
                    plainTextBytes = System.Text.Encoding.UTF8.GetBytes(XML11NOIDUNGFILE);
                    string XML11NOIDUNGFILEBase64Encode = System.Convert.ToBase64String(plainTextBytes);
                    plainTextBytes = System.Text.Encoding.UTF8.GetBytes(XML12NOIDUNGFILE);
                    string XML12NOIDUNGFILEBase64Encode = System.Convert.ToBase64String(plainTextBytes);
                    plainTextBytes = System.Text.Encoding.UTF8.GetBytes(XML13NOIDUNGFILE);
                    string XML13NOIDUNGFILEBase64Encode = System.Convert.ToBase64String(plainTextBytes);
                    plainTextBytes = System.Text.Encoding.UTF8.GetBytes(XML14NOIDUNGFILE);
                    string XML14NOIDUNGFILEBase64Encode = System.Convert.ToBase64String(plainTextBytes);
                    plainTextBytes = System.Text.Encoding.UTF8.GetBytes(XML15NOIDUNGFILE);
                    string XML15NOIDUNGFILEBase64Encode = System.Convert.ToBase64String(plainTextBytes);

                    XMLTong.AppendLine(@"<HOSO>");

                    if (ListXML1_CV130.Count > 0)
                    {
                        XMLTong.AppendLine(@"<FILEHOSO>");
                        XMLTong.AppendLine(@"<LOAIHOSO>XML1</LOAIHOSO>");
                        XMLTong.AppendLine(@"<NOIDUNGFILE>" + XML1NOIDUNGFILE + "</NOIDUNGFILE>");
                        XMLTong.AppendLine(@"</FILEHOSO>");
                    }

                    if (ListXML2_CV130.Count > 0)
                    {
                        XMLTong.AppendLine(@"<FILEHOSO>");
                        XMLTong.AppendLine(@"<LOAIHOSO>XML2</LOAIHOSO>");
                        XMLTong.AppendLine(@"<NOIDUNGFILE>" + XML2NOIDUNGFILE + "</NOIDUNGFILE>");
                        XMLTong.AppendLine(@"</FILEHOSO>");
                    }

                    if (ListXML3_CV130.Count > 0)
                    {
                        XMLTong.AppendLine(@"<FILEHOSO>");
                        XMLTong.AppendLine(@"<LOAIHOSO>XML3</LOAIHOSO>");
                        XMLTong.AppendLine(@"<NOIDUNGFILE>" + XML3NOIDUNGFILE + "</NOIDUNGFILE>");
                        XMLTong.AppendLine(@"</FILEHOSO>");
                    }

                    if (ListXML4_CV130.Count > 0)
                    {
                        XMLTong.AppendLine(@"<FILEHOSO>");
                        XMLTong.AppendLine(@"<LOAIHOSO>XML4</LOAIHOSO>");
                        XMLTong.AppendLine(@"<NOIDUNGFILE>" + XML4NOIDUNGFILE + "</NOIDUNGFILE>");
                        XMLTong.AppendLine(@"</FILEHOSO>");
                    }

                    if (ListXML5_CV130.Count > 0)
                    {
                        XMLTong.AppendLine(@"<FILEHOSO>");
                        XMLTong.AppendLine(@"<LOAIHOSO>XML5</LOAIHOSO>");
                        XMLTong.AppendLine(@"<NOIDUNGFILE>" + XML5NOIDUNGFILE + "</NOIDUNGFILE>");
                        XMLTong.AppendLine(@"</FILEHOSO>");
                    }

                    if (ListXML6_CV130.Count > 0)
                    {
                        XMLTong.AppendLine(@"<FILEHOSO>");
                        XMLTong.AppendLine(@"<LOAIHOSO>XML6</LOAIHOSO>");
                        XMLTong.AppendLine(@"<NOIDUNGFILE>" + XML6NOIDUNGFILE + "</NOIDUNGFILE>");
                        XMLTong.AppendLine(@"</FILEHOSO>");
                    }

                    if (ListXML7_CV130.Count > 0)
                    {
                        XMLTong.AppendLine(@"<FILEHOSO>");
                        XMLTong.AppendLine(@"<LOAIHOSO>XML7</LOAIHOSO>");
                        XMLTong.AppendLine(@"<NOIDUNGFILE>" + XML7NOIDUNGFILE + "</NOIDUNGFILE>");
                        XMLTong.AppendLine(@"</FILEHOSO>");
                    }

                    if (ListXML8_CV130.Count > 0)
                    {
                        XMLTong.AppendLine(@"<FILEHOSO>");
                        XMLTong.AppendLine(@"<LOAIHOSO>XML8</LOAIHOSO>");
                        XMLTong.AppendLine(@"<NOIDUNGFILE>" + XML8NOIDUNGFILE + "</NOIDUNGFILE>");
                        XMLTong.AppendLine(@"</FILEHOSO>");
                    }

                    if (ListXML9_CV130.Count > 0)
                    {
                        XMLTong.AppendLine(@"<FILEHOSO>");
                        XMLTong.AppendLine(@"<LOAIHOSO>XML9</LOAIHOSO>");
                        XMLTong.AppendLine(@"<NOIDUNGFILE>" + XML9NOIDUNGFILE + "</NOIDUNGFILE>");
                        XMLTong.AppendLine(@"</FILEHOSO>");
                    }

                    if (ListXML10_CV130.Count > 0)
                    {
                        XMLTong.AppendLine(@"<FILEHOSO>");
                        XMLTong.AppendLine(@"<LOAIHOSO>XML10</LOAIHOSO>");
                        XMLTong.AppendLine(@"<NOIDUNGFILE>" + XML10NOIDUNGFILE + "</NOIDUNGFILE>");
                        XMLTong.AppendLine(@"</FILEHOSO>");
                    }

                    if (ListXML11_CV130.Count > 0)
                    {
                        XMLTong.AppendLine(@"<FILEHOSO>");
                        XMLTong.AppendLine(@"<LOAIHOSO>XML11</LOAIHOSO>");
                        XMLTong.AppendLine(@"<NOIDUNGFILE>" + XML11NOIDUNGFILE + "</NOIDUNGFILE>");
                        XMLTong.AppendLine(@"</FILEHOSO>");
                    }

                    if (ListXML12_CV130.Count > 0)
                    {
                        XMLTong.AppendLine(@"<FILEHOSO>");
                        XMLTong.AppendLine(@"<LOAIHOSO>XML12</LOAIHOSO>");
                        XMLTong.AppendLine(@"<NOIDUNGFILE>" + XML12NOIDUNGFILE + "</NOIDUNGFILE>");
                        XMLTong.AppendLine(@"</FILEHOSO>");
                    }

                    if (ListXML13_CV130.Count > 0)
                    {
                        XMLTong.AppendLine(@"<FILEHOSO>");
                        XMLTong.AppendLine(@"<LOAIHOSO>XML13</LOAIHOSO>");
                        XMLTong.AppendLine(@"<NOIDUNGFILE>" + XML13NOIDUNGFILE + "</NOIDUNGFILE>");
                        XMLTong.AppendLine(@"</FILEHOSO>");
                    }

                    if (ListXML14_CV130.Count > 0)
                    {
                        XMLTong.AppendLine(@"<FILEHOSO>");
                        XMLTong.AppendLine(@"<LOAIHOSO>XML14</LOAIHOSO>");
                        XMLTong.AppendLine(@"<NOIDUNGFILE>" + XML14NOIDUNGFILE + "</NOIDUNGFILE>");
                        XMLTong.AppendLine(@"</FILEHOSO>");
                    }

                    if (ListXML15_CV130.Count > 0)
                    {
                        XMLTong.AppendLine(@"<FILEHOSO>");
                        XMLTong.AppendLine(@"<LOAIHOSO>XML15</LOAIHOSO>");
                        XMLTong.AppendLine(@"<NOIDUNGFILE>" + XML15NOIDUNGFILE + "</NOIDUNGFILE>");
                        XMLTong.AppendLine(@"</FILEHOSO>");
                    }

                    XMLTong.AppendLine(@"</HOSO>");

                  

                    

                    XMLEncode.AppendLine(@"<HOSO>");

                    if (ListXML1_CV130.Count > 0)
                    {
                        XMLEncode.AppendLine(@"<FILEHOSO>");
                        XMLEncode.AppendLine(@"<LOAIHOSO>XML1</LOAIHOSO>");
                        XMLEncode.AppendLine(@"<NOIDUNGFILE>" + XML1NOIDUNGFILEBase64Encode + "</NOIDUNGFILE>");
                        XMLEncode.AppendLine(@"</FILEHOSO>");
                    }

                    if (ListXML2_CV130.Count > 0)
                    {
                        XMLEncode.AppendLine(@"<FILEHOSO>");
                        XMLEncode.AppendLine(@"<LOAIHOSO>XML2</LOAIHOSO>");
                        XMLEncode.AppendLine(@"<NOIDUNGFILE>" + XML2NOIDUNGFILEBase64Encode + "</NOIDUNGFILE>");
                        XMLEncode.AppendLine(@"</FILEHOSO>");
                    }

                    if (ListXML3_CV130.Count > 0)
                    {
                        XMLEncode.AppendLine(@"<FILEHOSO>");
                        XMLEncode.AppendLine(@"<LOAIHOSO>XML3</LOAIHOSO>");
                        XMLEncode.AppendLine(@"<NOIDUNGFILE>" + XML3NOIDUNGFILEBase64Encode + "</NOIDUNGFILE>");
                        XMLEncode.AppendLine(@"</FILEHOSO>");
                    }

                    if (ListXML4_CV130.Count > 0)
                    {
                        XMLEncode.AppendLine(@"<FILEHOSO>");
                        XMLEncode.AppendLine(@"<LOAIHOSO>XML4</LOAIHOSO>");
                        XMLEncode.AppendLine(@"<NOIDUNGFILE>" + XML4NOIDUNGFILEBase64Encode + "</NOIDUNGFILE>");
                        XMLEncode.AppendLine(@"</FILEHOSO>");
                    }

                    if (ListXML5_CV130.Count > 0)
                    {
                        XMLEncode.AppendLine(@"<FILEHOSO>");
                        XMLEncode.AppendLine(@"<LOAIHOSO>XML5</LOAIHOSO>");
                        XMLEncode.AppendLine(@"<NOIDUNGFILE>" + XML5NOIDUNGFILEBase64Encode + "</NOIDUNGFILE>");
                        XMLEncode.AppendLine(@"</FILEHOSO>");
                    }

                    if (ListXML6_CV130.Count > 0)
                    {
                        XMLEncode.AppendLine(@"<FILEHOSO>");
                        XMLEncode.AppendLine(@"<LOAIHOSO>XML6</LOAIHOSO>");
                        XMLEncode.AppendLine(@"<NOIDUNGFILE>" + XML6NOIDUNGFILEBase64Encode + "</NOIDUNGFILE>");
                        XMLEncode.AppendLine(@"</FILEHOSO>");
                    }

                    if (ListXML7_CV130.Count > 0)
                    {
                        XMLEncode.AppendLine(@"<FILEHOSO>");
                        XMLEncode.AppendLine(@"<LOAIHOSO>XML7</LOAIHOSO>");
                        XMLEncode.AppendLine(@"<NOIDUNGFILE>" + XML7NOIDUNGFILEBase64Encode + "</NOIDUNGFILE>");
                        XMLEncode.AppendLine(@"</FILEHOSO>");
                    }

                    if (ListXML8_CV130.Count > 0)
                    {
                        XMLEncode.AppendLine(@"<FILEHOSO>");
                        XMLEncode.AppendLine(@"<LOAIHOSO>XML8</LOAIHOSO>");
                        XMLEncode.AppendLine(@"<NOIDUNGFILE>" + XML8NOIDUNGFILEBase64Encode + "</NOIDUNGFILE>");
                        XMLEncode.AppendLine(@"</FILEHOSO>");
                    }

                    if (ListXML9_CV130.Count > 0)
                    {
                        XMLEncode.AppendLine(@"<FILEHOSO>");
                        XMLEncode.AppendLine(@"<LOAIHOSO>XML9</LOAIHOSO>");
                        XMLEncode.AppendLine(@"<NOIDUNGFILE>" + XML9NOIDUNGFILEBase64Encode + "</NOIDUNGFILE>");
                        XMLEncode.AppendLine(@"</FILEHOSO>");
                    }

                    if (ListXML10_CV130.Count > 0)
                    {
                        XMLEncode.AppendLine(@"<FILEHOSO>");
                        XMLEncode.AppendLine(@"<LOAIHOSO>XML10</LOAIHOSO>");
                        XMLEncode.AppendLine(@"<NOIDUNGFILE>" + XML10NOIDUNGFILEBase64Encode + "</NOIDUNGFILE>");
                        XMLEncode.AppendLine(@"</FILEHOSO>");
                    }

                    if (ListXML11_CV130.Count > 0)
                    {
                        XMLEncode.AppendLine(@"<FILEHOSO>");
                        XMLEncode.AppendLine(@"<LOAIHOSO>XML11</LOAIHOSO>");
                        XMLEncode.AppendLine(@"<NOIDUNGFILE>" + XML11NOIDUNGFILEBase64Encode + "</NOIDUNGFILE>");
                        XMLEncode.AppendLine(@"</FILEHOSO>");
                    }

                    if (ListXML12_CV130.Count > 0)
                    {
                        XMLEncode.AppendLine(@"<FILEHOSO>");
                        XMLEncode.AppendLine(@"<LOAIHOSO>XML12</LOAIHOSO>");
                        XMLEncode.AppendLine(@"<NOIDUNGFILE>" + XML12NOIDUNGFILEBase64Encode + "</NOIDUNGFILE>");
                        XMLEncode.AppendLine(@"</FILEHOSO>");
                    }

                    if (ListXML13_CV130.Count > 0)
                    {
                        XMLEncode.AppendLine(@"<FILEHOSO>");
                        XMLEncode.AppendLine(@"<LOAIHOSO>XML13</LOAIHOSO>");
                        XMLEncode.AppendLine(@"<NOIDUNGFILE>" + XML13NOIDUNGFILEBase64Encode + "</NOIDUNGFILE>");
                        XMLEncode.AppendLine(@"</FILEHOSO>");
                    }

                    if (ListXML14_CV130.Count > 0)
                    {
                        XMLEncode.AppendLine(@"<FILEHOSO>");
                        XMLEncode.AppendLine(@"<LOAIHOSO>XML14</LOAIHOSO>");
                        XMLEncode.AppendLine(@"<NOIDUNGFILE>" + XML14NOIDUNGFILEBase64Encode + "</NOIDUNGFILE>");
                        XMLEncode.AppendLine(@"</FILEHOSO>");
                    }

                    if (ListXML15_CV130.Count > 0)
                    {
                        XMLEncode.AppendLine(@"<FILEHOSO>");
                        XMLEncode.AppendLine(@"<LOAIHOSO>XML15</LOAIHOSO>");
                        XMLEncode.AppendLine(@"<NOIDUNGFILE>" + XML15NOIDUNGFILEBase64Encode + "</NOIDUNGFILE>");
                        XMLEncode.AppendLine(@"</FILEHOSO>");
                    }

                    XMLEncode.AppendLine(@"</HOSO>");
                }

                XMLTong.AppendLine(@"</DANHSACHHOSO>");
                XMLTong.AppendLine(@"</THONGTINHOSO>");
                XMLTong.AppendLine(@"</GIAMDINHHS>");

                XMLEncode.AppendLine(@"</DANHSACHHOSO>");
                XMLEncode.AppendLine(@"</THONGTINHOSO>");
                XMLEncode.AppendLine(@"</GIAMDINHHS>");

                string Now = "XMLCV130_" + GlobalHelper.InitializationDateTimeCode0001;
                string folderPathRoot = Path.Combine(_WebHostEnvironment.WebRootPath, Now);
                Directory.CreateDirectory(folderPathRoot);
                bool isFolderExists = System.IO.Directory.Exists(folderPathRoot);
                if (!isFolderExists)
                {
                    System.IO.Directory.CreateDirectory(folderPathRoot);
                }

                string fileName = "CV130_" + GlobalHelper.InitializationDateTimeCode0001 + ".XML";
                string path = Path.Combine(_WebHostEnvironment.WebRootPath, Now, fileName);
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                    {
                        w.WriteLine(XMLTong.ToString());
                    }
                }

                fileName = "CV130_Base64Encode_" + GlobalHelper.InitializationDateTimeCode0001 + ".XML";
                path = Path.Combine(_WebHostEnvironment.WebRootPath, Now, fileName);
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                    {
                        w.WriteLine(XMLEncode.ToString());
                    }
                }

                string fileNameZIP = Now + ".zip";
                string inputPath = Path.Combine(_WebHostEnvironment.WebRootPath, Now);
                string outPath = Path.Combine(_WebHostEnvironment.WebRootPath, fileNameZIP);

                if (System.IO.File.Exists(outPath))
                {
                    try
                    {
                        System.IO.File.Delete(outPath);
                    }
                    catch (Exception ex)
                    {
                        string mes = ex.Message;
                    }
                }
                ZipFile.CreateFromDirectory(inputPath, outPath, System.IO.Compression.CompressionLevel.Fastest, true);

                result = GlobalHelper.APISite + "/" + fileNameZIP;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return Json(result);
        }

        private string CreateXML1(XML1_CV130 item, XMLCV130Tag XMLCV130Tag)
        {
            string Tag01 = GlobalHelper.InitializationString;
            string Tag02 = GlobalHelper.InitializationString;
            string Tag03 = GlobalHelper.InitializationString;
            string XMLTag = XMLCV130Tag.XML1;
            try
            {
                Tag01 = XMLTag.Split(';')[0];
            }
            catch (Exception ex)
            {
            }
            try
            {
                Tag02 = XMLTag.Split(';')[1];
            }
            catch (Exception ex)
            {
            }
            try
            {
                Tag03 = XMLTag.Split(';')[2];
            }
            catch (Exception ex)
            {
            }
            StringBuilder XML = new StringBuilder();
            //XML.AppendLine(GlobalHelper.XMLHeader);
            if (!string.IsNullOrEmpty(Tag03))
            {
                XML.AppendLine(@"<" + Tag03 + ">");
            }
            if (!string.IsNullOrEmpty(Tag02))
            {
                XML.AppendLine(@"<" + Tag02 + ">");
            }

            if (!string.IsNullOrEmpty(Tag01))
            {
                XML.AppendLine(@"<" + Tag01 + ">");
            }
            int STT = 0;
            foreach (var prop in item.GetType().GetProperties())
            {
                STT = STT + 1;
                if (STT > 5)
                {
                    XML.Append(@"<" + prop.Name + ">");
                    try
                    {
                        XML.Append(@"" + prop.GetValue(item, null).ToString());
                    }
                    catch (Exception ex)
                    {
                        XML.Append(@"");
                    }
                    XML.Append(@"</" + prop.Name + ">");
                }
            }
            if (!string.IsNullOrEmpty(Tag01))
            {
                XML.AppendLine(@"</" + Tag01 + ">");
            }

            if (!string.IsNullOrEmpty(Tag02))
            {
                XML.AppendLine(@"</" + Tag02 + ">");
            }
            if (!string.IsNullOrEmpty(Tag03))
            {
                XML.AppendLine(@"</" + Tag03 + ">");
            }
            return XML.ToString();
        }
        private string CreateXML2(List<XML2_CV130> List, XMLCV130Tag XMLCV130Tag)
        {
            string Tag01 = GlobalHelper.InitializationString;
            string Tag02 = GlobalHelper.InitializationString;
            string Tag03 = GlobalHelper.InitializationString;
            string XMLTag = XMLCV130Tag.XML2;
            try
            {
                Tag01 = XMLTag.Split(';')[0];
            }
            catch (Exception ex)
            {
            }
            try
            {
                Tag02 = XMLTag.Split(';')[1];
            }
            catch (Exception ex)
            {
            }
            try
            {
                Tag03 = XMLTag.Split(';')[2];
            }
            catch (Exception ex)
            {
            }
            StringBuilder XML = new StringBuilder();
            //XML.AppendLine(GlobalHelper.XMLHeader);
            if (!string.IsNullOrEmpty(Tag03))
            {
                XML.AppendLine(@"<" + Tag03 + ">");
            }
            if (!string.IsNullOrEmpty(Tag02))
            {
                XML.AppendLine(@"<" + Tag02 + ">");
            }
            foreach (XML2_CV130 item in List)
            {
                if (!string.IsNullOrEmpty(Tag01))
                {
                    XML.AppendLine(@"<" + Tag01 + ">");
                }
                int STT = 0;
                foreach (var prop in item.GetType().GetProperties())
                {
                    STT = STT + 1;
                    if (STT > 5)
                    {
                        XML.Append(@"<" + prop.Name + ">");
                        try
                        {
                            XML.Append(@"" + prop.GetValue(item, null).ToString());
                        }
                        catch (Exception ex)
                        {
                            XML.Append(@"");
                        }
                        XML.Append(@"</" + prop.Name + ">");
                    }
                }
                if (!string.IsNullOrEmpty(Tag01))
                {
                    XML.AppendLine(@"</" + Tag01 + ">");
                }
            }
            if (!string.IsNullOrEmpty(Tag02))
            {
                XML.AppendLine(@"</" + Tag02 + ">");
            }
            if (!string.IsNullOrEmpty(Tag03))
            {
                XML.AppendLine(@"</" + Tag03 + ">");
            }
            return XML.ToString();
        }
        private string CreateXML3(List<XML3_CV130> List, XMLCV130Tag XMLCV130Tag)
        {
            string Tag01 = GlobalHelper.InitializationString;
            string Tag02 = GlobalHelper.InitializationString;
            string Tag03 = GlobalHelper.InitializationString;
            string XMLTag = XMLCV130Tag.XML3;
            try
            {
                Tag01 = XMLTag.Split(';')[0];
            }
            catch (Exception ex)
            {
            }
            try
            {
                Tag02 = XMLTag.Split(';')[1];
            }
            catch (Exception ex)
            {
            }
            try
            {
                Tag03 = XMLTag.Split(';')[2];
            }
            catch (Exception ex)
            {
            }
            StringBuilder XML = new StringBuilder();
            //XML.AppendLine(GlobalHelper.XMLHeader);
            if (!string.IsNullOrEmpty(Tag03))
            {
                XML.AppendLine(@"<" + Tag03 + ">");
            }
            if (!string.IsNullOrEmpty(Tag02))
            {
                XML.AppendLine(@"<" + Tag02 + ">");
            }
            foreach (XML3_CV130 item in List)
            {
                if (!string.IsNullOrEmpty(Tag01))
                {
                    XML.AppendLine(@"<" + Tag01 + ">");
                }
                int STT = 0;
                foreach (var prop in item.GetType().GetProperties())
                {
                    STT = STT + 1;
                    if (STT > 5)
                    {
                        XML.Append(@"<" + prop.Name + ">");
                        try
                        {
                            XML.Append(@"" + prop.GetValue(item, null).ToString());
                        }
                        catch (Exception ex)
                        {
                            XML.Append(@"");
                        }
                        XML.Append(@"</" + prop.Name + ">");
                    }
                }
                if (!string.IsNullOrEmpty(Tag01))
                {
                    XML.AppendLine(@"</" + Tag01 + ">");
                }
            }
            if (!string.IsNullOrEmpty(Tag02))
            {
                XML.AppendLine(@"</" + Tag02 + ">");
            }
            if (!string.IsNullOrEmpty(Tag03))
            {
                XML.AppendLine(@"</" + Tag03 + ">");
            }
            return XML.ToString();
        }
        private string CreateXML4(List<XML4_CV130> List, XMLCV130Tag XMLCV130Tag)
        {
            string Tag01 = GlobalHelper.InitializationString;
            string Tag02 = GlobalHelper.InitializationString;
            string Tag03 = GlobalHelper.InitializationString;
            string XMLTag = XMLCV130Tag.XML4;
            try
            {
                Tag01 = XMLTag.Split(';')[0];
            }
            catch (Exception ex)
            {
            }
            try
            {
                Tag02 = XMLTag.Split(';')[1];
            }
            catch (Exception ex)
            {
            }
            try
            {
                Tag03 = XMLTag.Split(';')[2];
            }
            catch (Exception ex)
            {
            }
            StringBuilder XML = new StringBuilder();
            //XML.AppendLine(GlobalHelper.XMLHeader);
            if (!string.IsNullOrEmpty(Tag03))
            {
                XML.AppendLine(@"<" + Tag03 + ">");
            }
            if (!string.IsNullOrEmpty(Tag02))
            {
                XML.AppendLine(@"<" + Tag02 + ">");
            }
            foreach (XML4_CV130 item in List)
            {
                if (!string.IsNullOrEmpty(Tag01))
                {
                    XML.AppendLine(@"<" + Tag01 + ">");
                }
                int STT = 0;
                foreach (var prop in item.GetType().GetProperties())
                {
                    STT = STT + 1;
                    if (STT > 5)
                    {
                        XML.Append(@"<" + prop.Name + ">");
                        try
                        {
                            XML.Append(@"" + prop.GetValue(item, null).ToString());
                        }
                        catch (Exception ex)
                        {
                            XML.Append(@"");
                        }
                        XML.Append(@"</" + prop.Name + ">");
                    }
                }
                if (!string.IsNullOrEmpty(Tag01))
                {
                    XML.AppendLine(@"</" + Tag01 + ">");
                }
            }
            if (!string.IsNullOrEmpty(Tag02))
            {
                XML.AppendLine(@"</" + Tag02 + ">");
            }
            if (!string.IsNullOrEmpty(Tag03))
            {
                XML.AppendLine(@"</" + Tag03 + ">");
            }
            return XML.ToString();
        }
        private string CreateXML5(List<XML5_CV130> List, XMLCV130Tag XMLCV130Tag)
        {
            string Tag01 = GlobalHelper.InitializationString;
            string Tag02 = GlobalHelper.InitializationString;
            string Tag03 = GlobalHelper.InitializationString;
            string XMLTag = XMLCV130Tag.XML5;
            try
            {
                Tag01 = XMLTag.Split(';')[0];
            }
            catch (Exception ex)
            {
            }
            try
            {
                Tag02 = XMLTag.Split(';')[1];
            }
            catch (Exception ex)
            {
            }
            try
            {
                Tag03 = XMLTag.Split(';')[2];
            }
            catch (Exception ex)
            {
            }
            StringBuilder XML = new StringBuilder();
            //XML.AppendLine(GlobalHelper.XMLHeader);
            if (!string.IsNullOrEmpty(Tag03))
            {
                XML.AppendLine(@"<" + Tag03 + ">");
            }
            if (!string.IsNullOrEmpty(Tag02))
            {
                XML.AppendLine(@"<" + Tag02 + ">");
            }
            foreach (XML5_CV130 item in List)
            {
                if (!string.IsNullOrEmpty(Tag01))
                {
                    XML.AppendLine(@"<" + Tag01 + ">");
                }
                int STT = 0;
                foreach (var prop in item.GetType().GetProperties())
                {
                    STT = STT + 1;
                    if (STT > 5)
                    {
                        XML.Append(@"<" + prop.Name + ">");
                        try
                        {
                            XML.Append(@"" + prop.GetValue(item, null).ToString());
                        }
                        catch (Exception ex)
                        {
                            XML.Append(@"");
                        }
                        XML.Append(@"</" + prop.Name + ">");
                    }
                }
                if (!string.IsNullOrEmpty(Tag01))
                {
                    XML.AppendLine(@"</" + Tag01 + ">");
                }
            }
            if (!string.IsNullOrEmpty(Tag02))
            {
                XML.AppendLine(@"</" + Tag02 + ">");
            }
            if (!string.IsNullOrEmpty(Tag03))
            {
                XML.AppendLine(@"</" + Tag03 + ">");
            }
            return XML.ToString();
        }
        private string CreateXML6(List<XML6_CV130> List, XMLCV130Tag XMLCV130Tag)
        {
            string Tag01 = GlobalHelper.InitializationString;
            string Tag02 = GlobalHelper.InitializationString;
            string Tag03 = GlobalHelper.InitializationString;
            string XMLTag = XMLCV130Tag.XML6;
            try
            {
                Tag01 = XMLTag.Split(';')[0];
            }
            catch (Exception ex)
            {
            }
            try
            {
                Tag02 = XMLTag.Split(';')[1];
            }
            catch (Exception ex)
            {
            }
            try
            {
                Tag03 = XMLTag.Split(';')[2];
            }
            catch (Exception ex)
            {
            }
            StringBuilder XML = new StringBuilder();
            //XML.AppendLine(GlobalHelper.XMLHeader);
            if (!string.IsNullOrEmpty(Tag03))
            {
                XML.AppendLine(@"<" + Tag03 + ">");
            }
            if (!string.IsNullOrEmpty(Tag02))
            {
                XML.AppendLine(@"<" + Tag02 + ">");
            }
            foreach (XML6_CV130 item in List)
            {
                if (!string.IsNullOrEmpty(Tag01))
                {
                    XML.AppendLine(@"<" + Tag01 + ">");
                }
                int STT = 0;
                foreach (var prop in item.GetType().GetProperties())
                {
                    STT = STT + 1;
                    if (STT > 5)
                    {
                        XML.Append(@"<" + prop.Name + ">");
                        try
                        {
                            XML.Append(@"" + prop.GetValue(item, null).ToString());
                        }
                        catch (Exception ex)
                        {
                            XML.Append(@"");
                        }
                        XML.Append(@"</" + prop.Name + ">");
                    }
                }
                if (!string.IsNullOrEmpty(Tag01))
                {
                    XML.AppendLine(@"</" + Tag01 + ">");
                }
            }
            if (!string.IsNullOrEmpty(Tag02))
            {
                XML.AppendLine(@"</" + Tag02 + ">");
            }
            if (!string.IsNullOrEmpty(Tag03))
            {
                XML.AppendLine(@"</" + Tag03 + ">");
            }
            return XML.ToString();
        }
        private string CreateXML7(List<XML7_CV130> List, XMLCV130Tag XMLCV130Tag)
        {
            string Tag01 = GlobalHelper.InitializationString;
            string Tag02 = GlobalHelper.InitializationString;
            string Tag03 = GlobalHelper.InitializationString;
            string XMLTag = XMLCV130Tag.XML7;
            try
            {
                Tag01 = XMLTag.Split(';')[0];
            }
            catch (Exception ex)
            {
            }
            try
            {
                Tag02 = XMLTag.Split(';')[1];
            }
            catch (Exception ex)
            {
            }
            try
            {
                Tag03 = XMLTag.Split(';')[2];
            }
            catch (Exception ex)
            {
            }
            StringBuilder XML = new StringBuilder();
            //XML.AppendLine(GlobalHelper.XMLHeader);
            if (!string.IsNullOrEmpty(Tag03))
            {
                XML.AppendLine(@"<" + Tag03 + ">");
            }
            if (!string.IsNullOrEmpty(Tag02))
            {
                XML.AppendLine(@"<" + Tag02 + ">");
            }
            foreach (XML7_CV130 item in List)
            {
                if (!string.IsNullOrEmpty(Tag01))
                {
                    XML.AppendLine(@"<" + Tag01 + ">");
                }
                int STT = 0;
                foreach (var prop in item.GetType().GetProperties())
                {
                    STT = STT + 1;
                    if (STT > 5)
                    {
                        XML.Append(@"<" + prop.Name + ">");
                        try
                        {
                            XML.Append(@"" + prop.GetValue(item, null).ToString());
                        }
                        catch (Exception ex)
                        {
                            XML.Append(@"");
                        }
                        XML.Append(@"</" + prop.Name + ">");
                    }
                }
                if (!string.IsNullOrEmpty(Tag01))
                {
                    XML.AppendLine(@"</" + Tag01 + ">");
                }
            }
            if (!string.IsNullOrEmpty(Tag02))
            {
                XML.AppendLine(@"</" + Tag02 + ">");
            }
            if (!string.IsNullOrEmpty(Tag03))
            {
                XML.AppendLine(@"</" + Tag03 + ">");
            }
            return XML.ToString();
        }
        private string CreateXML8(List<XML8_CV130> List, XMLCV130Tag XMLCV130Tag)
        {
            string Tag01 = GlobalHelper.InitializationString;
            string Tag02 = GlobalHelper.InitializationString;
            string Tag03 = GlobalHelper.InitializationString;
            string XMLTag = XMLCV130Tag.XML8;
            try
            {
                Tag01 = XMLTag.Split(';')[0];
            }
            catch (Exception ex)
            {
            }
            try
            {
                Tag02 = XMLTag.Split(';')[1];
            }
            catch (Exception ex)
            {
            }
            try
            {
                Tag03 = XMLTag.Split(';')[2];
            }
            catch (Exception ex)
            {
            }
            StringBuilder XML = new StringBuilder();
            //XML.AppendLine(GlobalHelper.XMLHeader);
            if (!string.IsNullOrEmpty(Tag03))
            {
                XML.AppendLine(@"<" + Tag03 + ">");
            }
            if (!string.IsNullOrEmpty(Tag02))
            {
                XML.AppendLine(@"<" + Tag02 + ">");
            }
            foreach (XML8_CV130 item in List)
            {
                if (!string.IsNullOrEmpty(Tag01))
                {
                    XML.AppendLine(@"<" + Tag01 + ">");
                }
                int STT = 0;
                foreach (var prop in item.GetType().GetProperties())
                {
                    STT = STT + 1;
                    if (STT > 5)
                    {
                        XML.Append(@"<" + prop.Name + ">");
                        try
                        {
                            XML.Append(@"" + prop.GetValue(item, null).ToString());
                        }
                        catch (Exception ex)
                        {
                            XML.Append(@"");
                        }
                        XML.Append(@"</" + prop.Name + ">");
                    }
                }
                if (!string.IsNullOrEmpty(Tag01))
                {
                    XML.AppendLine(@"</" + Tag01 + ">");
                }
            }
            if (!string.IsNullOrEmpty(Tag02))
            {
                XML.AppendLine(@"</" + Tag02 + ">");
            }
            if (!string.IsNullOrEmpty(Tag03))
            {
                XML.AppendLine(@"</" + Tag03 + ">");
            }
            return XML.ToString();
        }
        private string CreateXML9(List<XML9_CV130> List, XMLCV130Tag XMLCV130Tag)
        {
            string Tag01 = GlobalHelper.InitializationString;
            string Tag02 = GlobalHelper.InitializationString;
            string Tag03 = GlobalHelper.InitializationString;
            string XMLTag = XMLCV130Tag.XML9;
            try
            {
                Tag01 = XMLTag.Split(';')[0];
            }
            catch (Exception ex)
            {
            }
            try
            {
                Tag02 = XMLTag.Split(';')[1];
            }
            catch (Exception ex)
            {
            }
            try
            {
                Tag03 = XMLTag.Split(';')[2];
            }
            catch (Exception ex)
            {
            }
            StringBuilder XML = new StringBuilder();
            //XML.AppendLine(GlobalHelper.XMLHeader);
            if (!string.IsNullOrEmpty(Tag03))
            {
                XML.AppendLine(@"<" + Tag03 + ">");
            }
            if (!string.IsNullOrEmpty(Tag02))
            {
                XML.AppendLine(@"<" + Tag02 + ">");
            }
            foreach (XML9_CV130 item in List)
            {
                if (!string.IsNullOrEmpty(Tag01))
                {
                    XML.AppendLine(@"<" + Tag01 + ">");
                }
                int STT = 0;
                foreach (var prop in item.GetType().GetProperties())
                {
                    STT = STT + 1;
                    if (STT > 5)
                    {
                        XML.Append(@"<" + prop.Name + ">");
                        try
                        {
                            XML.Append(@"" + prop.GetValue(item, null).ToString());
                        }
                        catch (Exception ex)
                        {
                            XML.Append(@"");
                        }
                        XML.Append(@"</" + prop.Name + ">");
                    }
                }
                if (!string.IsNullOrEmpty(Tag01))
                {
                    XML.AppendLine(@"</" + Tag01 + ">");
                }
            }
            if (!string.IsNullOrEmpty(Tag02))
            {
                XML.AppendLine(@"</" + Tag02 + ">");
            }
            if (!string.IsNullOrEmpty(Tag03))
            {
                XML.AppendLine(@"</" + Tag03 + ">");
            }
            return XML.ToString();
        }
        private string CreateXML10(List<XML10_CV130> List, XMLCV130Tag XMLCV130Tag)
        {
            string Tag01 = GlobalHelper.InitializationString;
            string Tag02 = GlobalHelper.InitializationString;
            string Tag03 = GlobalHelper.InitializationString;
            string XMLTag = XMLCV130Tag.XML10;
            try
            {
                Tag01 = XMLTag.Split(';')[0];
            }
            catch (Exception ex)
            {
            }
            try
            {
                Tag02 = XMLTag.Split(';')[1];
            }
            catch (Exception ex)
            {
            }
            try
            {
                Tag03 = XMLTag.Split(';')[2];
            }
            catch (Exception ex)
            {
            }
            StringBuilder XML = new StringBuilder();
            //XML.AppendLine(GlobalHelper.XMLHeader);
            if (!string.IsNullOrEmpty(Tag03))
            {
                XML.AppendLine(@"<" + Tag03 + ">");
            }
            if (!string.IsNullOrEmpty(Tag02))
            {
                XML.AppendLine(@"<" + Tag02 + ">");
            }
            foreach (XML10_CV130 item in List)
            {
                if (!string.IsNullOrEmpty(Tag01))
                {
                    XML.AppendLine(@"<" + Tag01 + ">");
                }
                int STT = 0;
                foreach (var prop in item.GetType().GetProperties())
                {
                    STT = STT + 1;
                    if (STT > 5)
                    {
                        XML.Append(@"<" + prop.Name + ">");
                        try
                        {
                            XML.Append(@"" + prop.GetValue(item, null).ToString());
                        }
                        catch (Exception ex)
                        {
                            XML.Append(@"");
                        }
                        XML.Append(@"</" + prop.Name + ">");
                    }
                }
                if (!string.IsNullOrEmpty(Tag01))
                {
                    XML.AppendLine(@"</" + Tag01 + ">");
                }
            }
            if (!string.IsNullOrEmpty(Tag02))
            {
                XML.AppendLine(@"</" + Tag02 + ">");
            }
            if (!string.IsNullOrEmpty(Tag03))
            {
                XML.AppendLine(@"</" + Tag03 + ">");
            }
            return XML.ToString();
        }
        private string CreateXML11(List<XML11_CV130> List, XMLCV130Tag XMLCV130Tag)
        {
            string Tag01 = GlobalHelper.InitializationString;
            string Tag02 = GlobalHelper.InitializationString;
            string Tag03 = GlobalHelper.InitializationString;
            string XMLTag = XMLCV130Tag.XML11;
            try
            {
                Tag01 = XMLTag.Split(';')[0];
            }
            catch (Exception ex)
            {
            }
            try
            {
                Tag02 = XMLTag.Split(';')[1];
            }
            catch (Exception ex)
            {
            }
            try
            {
                Tag03 = XMLTag.Split(';')[2];
            }
            catch (Exception ex)
            {
            }
            StringBuilder XML = new StringBuilder();
            //XML.AppendLine(GlobalHelper.XMLHeader);
            if (!string.IsNullOrEmpty(Tag03))
            {
                XML.AppendLine(@"<" + Tag03 + ">");
            }
            if (!string.IsNullOrEmpty(Tag02))
            {
                XML.AppendLine(@"<" + Tag02 + ">");
            }
            foreach (XML11_CV130 item in List)
            {
                if (!string.IsNullOrEmpty(Tag01))
                {
                    XML.AppendLine(@"<" + Tag01 + ">");
                }
                int STT = 0;
                foreach (var prop in item.GetType().GetProperties())
                {
                    STT = STT + 1;
                    if (STT > 5)
                    {
                        XML.Append(@"<" + prop.Name + ">");
                        try
                        {
                            XML.Append(@"" + prop.GetValue(item, null).ToString());
                        }
                        catch (Exception ex)
                        {
                            XML.Append(@"");
                        }
                        XML.Append(@"</" + prop.Name + ">");
                    }
                }
                if (!string.IsNullOrEmpty(Tag01))
                {
                    XML.AppendLine(@"</" + Tag01 + ">");
                }
            }
            if (!string.IsNullOrEmpty(Tag02))
            {
                XML.AppendLine(@"</" + Tag02 + ">");
            }
            if (!string.IsNullOrEmpty(Tag03))
            {
                XML.AppendLine(@"</" + Tag03 + ">");
            }
            return XML.ToString();
        }
        private string CreateXML12(List<XML12_CV130> List, XMLCV130Tag XMLCV130Tag)
        {
            string Tag01 = GlobalHelper.InitializationString;
            string Tag02 = GlobalHelper.InitializationString;
            string Tag03 = GlobalHelper.InitializationString;
            string XMLTag = XMLCV130Tag.XML12;
            try
            {
                Tag01 = XMLTag.Split(';')[0];
            }
            catch (Exception ex)
            {
            }
            try
            {
                Tag02 = XMLTag.Split(';')[1];
            }
            catch (Exception ex)
            {
            }
            try
            {
                Tag03 = XMLTag.Split(';')[2];
            }
            catch (Exception ex)
            {
            }
            StringBuilder XML = new StringBuilder();
            //XML.AppendLine(GlobalHelper.XMLHeader);
            if (!string.IsNullOrEmpty(Tag03))
            {
                XML.AppendLine(@"<" + Tag03 + ">");
            }
            if (!string.IsNullOrEmpty(Tag02))
            {
                XML.AppendLine(@"<" + Tag02 + ">");
            }
            foreach (XML12_CV130 item in List)
            {
                if (!string.IsNullOrEmpty(Tag01))
                {
                    XML.AppendLine(@"<" + Tag01 + ">");
                }
                int STT = 0;
                foreach (var prop in item.GetType().GetProperties())
                {
                    STT = STT + 1;
                    if (STT > 5)
                    {
                        XML.Append(@"<" + prop.Name + ">");
                        try
                        {
                            XML.Append(@"" + prop.GetValue(item, null).ToString());
                        }
                        catch (Exception ex)
                        {
                            XML.Append(@"");
                        }
                        XML.Append(@"</" + prop.Name + ">");
                    }
                }
                if (!string.IsNullOrEmpty(Tag01))
                {
                    XML.AppendLine(@"</" + Tag01 + ">");
                }
            }
            if (!string.IsNullOrEmpty(Tag02))
            {
                XML.AppendLine(@"</" + Tag02 + ">");
            }
            if (!string.IsNullOrEmpty(Tag03))
            {
                XML.AppendLine(@"</" + Tag03 + ">");
            }
            return XML.ToString();
        }
        private string CreateXML13(List<XML13_CV130> List, XMLCV130Tag XMLCV130Tag)
        {
            string Tag01 = GlobalHelper.InitializationString;
            string Tag02 = GlobalHelper.InitializationString;
            string Tag03 = GlobalHelper.InitializationString;
            string XMLTag = XMLCV130Tag.XML13;
            try
            {
                Tag01 = XMLTag.Split(';')[0];
            }
            catch (Exception ex)
            {
            }
            try
            {
                Tag02 = XMLTag.Split(';')[1];
            }
            catch (Exception ex)
            {
            }
            try
            {
                Tag03 = XMLTag.Split(';')[2];
            }
            catch (Exception ex)
            {
            }
            StringBuilder XML = new StringBuilder();
            //XML.AppendLine(GlobalHelper.XMLHeader);
            if (!string.IsNullOrEmpty(Tag03))
            {
                XML.AppendLine(@"<" + Tag03 + ">");
            }
            if (!string.IsNullOrEmpty(Tag02))
            {
                XML.AppendLine(@"<" + Tag02 + ">");
            }
            foreach (XML13_CV130 item in List)
            {
                if (!string.IsNullOrEmpty(Tag01))
                {
                    XML.AppendLine(@"<" + Tag01 + ">");
                }
                int STT = 0;
                foreach (var prop in item.GetType().GetProperties())
                {
                    STT = STT + 1;
                    if (STT > 5)
                    {
                        XML.Append(@"<" + prop.Name + ">");
                        try
                        {
                            XML.Append(@"" + prop.GetValue(item, null).ToString());
                        }
                        catch (Exception ex)
                        {
                            XML.Append(@"");
                        }
                        XML.Append(@"</" + prop.Name + ">");
                    }
                }
                if (!string.IsNullOrEmpty(Tag01))
                {
                    XML.AppendLine(@"</" + Tag01 + ">");
                }
            }
            if (!string.IsNullOrEmpty(Tag02))
            {
                XML.AppendLine(@"</" + Tag02 + ">");
            }
            if (!string.IsNullOrEmpty(Tag03))
            {
                XML.AppendLine(@"</" + Tag03 + ">");
            }
            return XML.ToString();
        }
        private string CreateXML14(List<XML14_CV130> List, XMLCV130Tag XMLCV130Tag)
        {
            string Tag01 = GlobalHelper.InitializationString;
            string Tag02 = GlobalHelper.InitializationString;
            string Tag03 = GlobalHelper.InitializationString;
            string XMLTag = XMLCV130Tag.XML14;
            try
            {
                Tag01 = XMLTag.Split(';')[0];
            }
            catch (Exception ex)
            {
            }
            try
            {
                Tag02 = XMLTag.Split(';')[1];
            }
            catch (Exception ex)
            {
            }
            try
            {
                Tag03 = XMLTag.Split(';')[2];
            }
            catch (Exception ex)
            {
            }
            StringBuilder XML = new StringBuilder();
            //XML.AppendLine(GlobalHelper.XMLHeader);
            if (!string.IsNullOrEmpty(Tag03))
            {
                XML.AppendLine(@"<" + Tag03 + ">");
            }
            if (!string.IsNullOrEmpty(Tag02))
            {
                XML.AppendLine(@"<" + Tag02 + ">");
            }
            foreach (XML14_CV130 item in List)
            {
                if (!string.IsNullOrEmpty(Tag01))
                {
                    XML.AppendLine(@"<" + Tag01 + ">");
                }
                int STT = 0;
                foreach (var prop in item.GetType().GetProperties())
                {
                    STT = STT + 1;
                    if (STT > 5)
                    {
                        XML.Append(@"<" + prop.Name + ">");
                        try
                        {
                            XML.Append(@"" + prop.GetValue(item, null).ToString());
                        }
                        catch (Exception ex)
                        {
                            XML.Append(@"");
                        }
                        XML.Append(@"</" + prop.Name + ">");
                    }
                }
                if (!string.IsNullOrEmpty(Tag01))
                {
                    XML.AppendLine(@"</" + Tag01 + ">");
                }
            }
            if (!string.IsNullOrEmpty(Tag02))
            {
                XML.AppendLine(@"</" + Tag02 + ">");
            }
            if (!string.IsNullOrEmpty(Tag03))
            {
                XML.AppendLine(@"</" + Tag03 + ">");
            }
            return XML.ToString();
        }
        private string CreateXML15(List<XML15_CV130> List, XMLCV130Tag XMLCV130Tag)
        {
            string Tag01 = GlobalHelper.InitializationString;
            string Tag02 = GlobalHelper.InitializationString;
            string Tag03 = GlobalHelper.InitializationString;
            string XMLTag = XMLCV130Tag.XML15;
            try
            {
                Tag01 = XMLTag.Split(';')[0];
            }
            catch (Exception ex)
            {
            }
            try
            {
                Tag02 = XMLTag.Split(';')[1];
            }
            catch (Exception ex)
            {
            }
            try
            {
                Tag03 = XMLTag.Split(';')[2];
            }
            catch (Exception ex)
            {
            }
            StringBuilder XML = new StringBuilder();
            //XML.AppendLine(GlobalHelper.XMLHeader);
            if (!string.IsNullOrEmpty(Tag03))
            {
                XML.AppendLine(@"<" + Tag03 + ">");
            }
            if (!string.IsNullOrEmpty(Tag02))
            {
                XML.AppendLine(@"<" + Tag02 + ">");
            }
            foreach (XML15_CV130 item in List)
            {
                if (!string.IsNullOrEmpty(Tag01))
                {
                    XML.AppendLine(@"<" + Tag01 + ">");
                }
                int STT = 0;
                foreach (var prop in item.GetType().GetProperties())
                {
                    STT = STT + 1;
                    if (STT > 5)
                    {
                        XML.Append(@"<" + prop.Name + ">");
                        try
                        {
                            XML.Append(@"" + prop.GetValue(item, null).ToString());
                        }
                        catch (Exception ex)
                        {
                            XML.Append(@"");
                        }
                        XML.Append(@"</" + prop.Name + ">");
                    }
                }
                if (!string.IsNullOrEmpty(Tag01))
                {
                    XML.AppendLine(@"</" + Tag01 + ">");
                }
            }
            if (!string.IsNullOrEmpty(Tag02))
            {
                XML.AppendLine(@"</" + Tag02 + ">");
            }
            if (!string.IsNullOrEmpty(Tag03))
            {
                XML.AppendLine(@"</" + Tag03 + ">");
            }
            return XML.ToString();
        }

    }
}

