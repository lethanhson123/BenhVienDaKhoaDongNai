using Microsoft.AspNetCore.Hosting;
using Service.Interface;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Service.Implement
{
    public class GoiSoService : BaseService<GoiSo, IGoiSoRepository>
    , IGoiSoService
    {
        private readonly IGoiSoRepository _GoiSoRepository;
        private readonly IDanhMucDichVuRepository _DanhMucDichVuRepository;

        private readonly IWebHostEnvironment _WebHostEnvironment;
        public GoiSoService(IGoiSoRepository GoiSoRepository

            , IDanhMucDichVuRepository danhMucDichVuRepository

            , IWebHostEnvironment WebHostEnvironment
            ) : base(GoiSoRepository)
        {
            _GoiSoRepository = GoiSoRepository;

            _DanhMucDichVuRepository = danhMucDichVuRepository;

            _WebHostEnvironment = WebHostEnvironment;
        }
        public override void Initialization(GoiSo model)
        {
            BaseInitialization(model);
            if (model.DanhMucDichVuID > 0)
            {
                DanhMucDichVu DanhMucDichVu = _DanhMucDichVuRepository.GetByID(model.DanhMucDichVuID.Value);
                model.DanhMucDichVuName = DanhMucDichVu.Name;
                model.Note = DanhMucDichVu.Note;
            }
            if (model.TongCong > 0)
            {
                model.TongCongString = model.TongCong.ToString();
                if (model.TongCong < 10)
                {
                    model.TongCongString = "000" + model.TongCongString;
                }
                else
                {
                    if (model.TongCong < 100)
                    {
                        model.TongCongString = "00" + model.TongCongString;
                    }
                    else
                    {
                        if (model.TongCong < 1000)
                        {
                            model.TongCongString = "0" + model.TongCongString;
                        }
                    }
                }
            }
            if (model.SoHienTai > 0)
            {
                model.SoHienTaiString = model.SoHienTai.ToString();
                if (model.SoHienTai < 10)
                {
                    model.SoHienTaiString = "000" + model.SoHienTaiString;
                }
                else
                {
                    if (model.SoHienTai < 100)
                    {
                        model.SoHienTaiString = "00" + model.SoHienTaiString;
                    }
                    else
                    {
                        if (model.SoHienTai < 1000)
                        {
                            model.SoHienTaiString = "0" + model.SoHienTaiString;
                        }
                    }
                }
            }
        }
        public virtual async Task<GoiSo> SaveByDanhMucDichVuIDAsync(long DanhMucDichVuID)
        {
            GoiSo result = new GoiSo();
            try
            {
                DateTime Now = GlobalHelper.InitializationDateTime;
                result = await GetByCondition(item => item.DanhMucDichVuID == DanhMucDichVuID && item.NgayGhiNhan.Value.Year == Now.Year && item.NgayGhiNhan.Value.Month == Now.Month && item.NgayGhiNhan.Value.Day == Now.Day).FirstOrDefaultAsync();
                if (result == null)
                {
                    result = new GoiSo();
                    result.DanhMucDichVuID = DanhMucDichVuID;
                    result.NgayGhiNhan = Now;
                    result.TongCong = 0;
                    result.SoHienTai = 0;
                }
                result.TongCong = result.TongCong + 1;
                await SaveAsync(result);
                if (result.ID > 0)
                {
                    result = await CreateHTMLByModelAsync(result);
                }
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            if (result == null)
            {
                result = new GoiSo();
            }
            return result;
        }
        public virtual async Task<GoiSo> CreateHTMLByModelAsync(GoiSo result)
        {
            try
            {
                string Code = GlobalHelper.InitializationDateTimeCode;

                string folderPath = Path.Combine(_WebHostEnvironment.WebRootPath, result.GetType().Name);
                bool isFolderExists = System.IO.Directory.Exists(folderPath);
                if (!isFolderExists)
                {
                    System.IO.Directory.CreateDirectory(folderPath);
                }

                result.FileName = GlobalHelper.APISite + "/" + result.GetType().Name + "/" + Code + ".html";

                string contentHTML = GlobalHelper.InitializationString;
                string physicalPathOpen = Path.Combine(_WebHostEnvironment.WebRootPath, GlobalHelper.Download, result.GetType().Name + ".html");
                using (FileStream fs = new FileStream(physicalPathOpen, FileMode.Open))
                {
                    using (StreamReader r = new StreamReader(fs, Encoding.UTF8))
                    {
                        contentHTML = r.ReadToEnd();
                    }
                }
                DateTime NgayIn = GlobalHelper.InitializationDateTime;
                DateTime BatDau = NgayIn.AddHours(2);
                DateTime KetThuc = BatDau.AddMinutes(30);

                contentHTML = contentHTML.Replace("[NgayIn]", NgayIn.ToString("dd/MM/yyyy HH:mm:ss"));
                contentHTML = contentHTML.Replace("[BatDau]", BatDau.ToString("HH:mm"));
                contentHTML = contentHTML.Replace("[KetThuc]", KetThuc.ToString("HH:mm"));

                contentHTML = contentHTML.Replace("[APISite]", GlobalHelper.APISite);

                contentHTML = contentHTML.Replace("[DanhMucDichVuName]", result.DanhMucDichVuName);
                contentHTML = contentHTML.Replace("[Note]", result.Note);
                contentHTML = contentHTML.Replace("[TongCongString]", result.TongCongString);
                contentHTML = contentHTML.Replace("[SoHienTaiString]", result.SoHienTaiString);


                string physicalPathCreate = Path.Combine(_WebHostEnvironment.WebRootPath, result.GetType().Name);
                isFolderExists = System.IO.Directory.Exists(physicalPathCreate);
                if (!isFolderExists)
                {
                    System.IO.Directory.CreateDirectory(physicalPathCreate);
                }

                string fileName = Code + ".html";
                physicalPathCreate = Path.Combine(physicalPathCreate, fileName);
                using (FileStream fs = new FileStream(physicalPathCreate, FileMode.Create))
                {
                    using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                    {
                        w.WriteLine(contentHTML);
                    }
                }

                await UpdateAsync(result);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
    }
}

