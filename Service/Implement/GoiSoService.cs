using Data.Model;
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

        private readonly IGoiSoChiTietService _GoiSoChiTietService;

        private readonly IGoiSoChiTietPhongKhamService _GoiSoChiTietPhongKhamService;

        private readonly IWebHostEnvironment _WebHostEnvironment;
        public GoiSoService(IGoiSoRepository GoiSoRepository

            , IDanhMucDichVuRepository danhMucDichVuRepository

            , IGoiSoChiTietService GoiSoChiTietService

            , IGoiSoChiTietPhongKhamService GoiSoChiTietPhongKhamService

            , IWebHostEnvironment WebHostEnvironment

            ) : base(GoiSoRepository)
        {
            _GoiSoRepository = GoiSoRepository;

            _DanhMucDichVuRepository = danhMucDichVuRepository;

            _GoiSoChiTietService = GoiSoChiTietService;

            _GoiSoChiTietPhongKhamService = GoiSoChiTietPhongKhamService;

            _WebHostEnvironment = WebHostEnvironment;
        }
        public override void Initialization(GoiSo model)
        {
            BaseInitialization(model);
            if (model.DanhMucDichVuID == null)
            {
                model.DanhMucDichVuID = GlobalHelper.DanhMucDichVuID;
            }
            if (model.DanhMucDichVuID > 0)
            {
                if (string.IsNullOrEmpty(model.DanhMucDichVuName))
                {
                    DanhMucDichVu DanhMucDichVu = _DanhMucDichVuRepository.GetByID(model.DanhMucDichVuID.Value);
                    model.DanhMucDichVuName = DanhMucDichVu.Name;
                    model.Note = DanhMucDichVu.Note;
                }
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
        public override async Task<GoiSo> SaveAsync(GoiSo model)
        {
            int result = GlobalHelper.InitializationNumber;
            if (model.ID > 0)
            {
                result = await UpdateAsync(model);
            }
            else
            {
                result = await AddAsync(model);
            }
            if (result > 0)
            {
                await Sync(model);
            }
            return model;
        }
        public virtual async Task<GoiSo> Sync(GoiSo model)
        {
            if (model.ID > 0)
            {
                if (model.DanhMucDichVuID > 0)
                {
                    GoiSoChiTiet GoiSoChiTiet = new GoiSoChiTiet();
                    GoiSoChiTiet.ParentID = model.ParentID;
                    GoiSoChiTiet.DanhMucDichVuID = model.DanhMucDichVuID;
                    GoiSoChiTiet.DanhMucDichVuName = model.DanhMucDichVuName;
                    GoiSoChiTiet.NgayCapSoSoThuTu = model.TongCong;
                    await _GoiSoChiTietService.SaveAsync(GoiSoChiTiet);
                }
            }
            return model;
        }
        public virtual async Task<GoiSo> GoiSoTiepTheoAsync(long DanhMucDichVuID, int SoHienTai, long DanhMucQuayDichVuID)
        {
            GoiSo result = new GoiSo();
            try
            {
                DateTime Now = GlobalHelper.InitializationDateTime;
                result = await GetByCondition(item => item.DanhMucDichVuID == DanhMucDichVuID && item.NgayGhiNhan.Value.Year == Now.Year && item.NgayGhiNhan.Value.Month == Now.Month && item.NgayGhiNhan.Value.Day == Now.Day).FirstOrDefaultAsync();
                if (result != null)
                {
                    if (SoHienTai > 0)
                    {
                        if (result.SoHienTai != SoHienTai)
                        {
                            result.SoHienTai = SoHienTai;
                        }
                    }
                    if (result.SoHienTai < result.TongCong)
                    {
                        result.SoHienTai = result.SoHienTai + 1;
                        await SaveAsync(result);
                    }
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

            GoiSoChiTiet GoiSoChiTiet = new GoiSoChiTiet();
            try
            {
                DateTime Now = GlobalHelper.InitializationDateTime;
                GoiSoChiTiet = await _GoiSoChiTietService.GetByDanhMucDichVuID_NgayCapSoSoThuTuAsync(DanhMucDichVuID, result.SoHienTai.Value);
                if (GoiSoChiTiet != null)
                {
                    GoiSoChiTiet.DanhMucQuayDichVuID = DanhMucQuayDichVuID;
                    GoiSoChiTiet.NgayDangKySoThuTu = result.SoHienTai;
                    GoiSoChiTiet.Active = true;
                    await _GoiSoChiTietService.SaveAsync(GoiSoChiTiet);
                }
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        public virtual async Task<GoiSo> GoiSoTiepTheoByDanhMucDichVuIDAsync(long DanhMucDichVuID, int SoHienTai, long DanhMucQuayDichVuID, string Code)
        {
            GoiSo result = new GoiSo();
            try
            {
                DateTime Now = GlobalHelper.InitializationDateTime;
                result = await GetByCondition(item => item.DanhMucDichVuID == DanhMucDichVuID && item.NgayGhiNhan.Value.Year == Now.Year && item.NgayGhiNhan.Value.Month == Now.Month && item.NgayGhiNhan.Value.Day == Now.Day).FirstOrDefaultAsync();
                if (result != null)
                {
                    if (SoHienTai > 0)
                    {
                        if (result.SoHienTai != SoHienTai)
                        {
                            result.SoHienTai = SoHienTai;
                        }
                    }
                    if (result.SoHienTai < result.TongCong)
                    {
                        result.SoHienTai = result.SoHienTai + 1;
                        await SaveAsync(result);
                    }
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

            GoiSoChiTiet GoiSoChiTiet = new GoiSoChiTiet();
            try
            {
                DateTime Now = GlobalHelper.InitializationDateTime;
                GoiSoChiTiet = await _GoiSoChiTietService.GetByDanhMucDichVuID_NgayCapSoSoThuTuAsync(DanhMucDichVuID, result.SoHienTai.Value);
                if (GoiSoChiTiet != null)
                {
                    GoiSoChiTiet.Code = Code;
                    GoiSoChiTiet.DanhMucQuayDichVuID = DanhMucQuayDichVuID;
                    GoiSoChiTiet.NgayDangKySoThuTu = result.SoHienTai;                    
                    GoiSoChiTiet.Active = true;
                    await _GoiSoChiTietService.SaveAsync(GoiSoChiTiet);
                }
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
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
                    result = await CreateHTML001ByModelAsync(result);
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
        public virtual async Task<GoiSo> CreateHTML001ByModelAsync(GoiSo result)
        {
            try
            {
                string Code = GlobalHelper.InitializationDateTimeCode;

                string folderPath = Path.Combine(GlobalHelper.CapSoFTP, result.GetType().Name);
                bool isFolderExists = System.IO.Directory.Exists(folderPath);
                if (!isFolderExists)
                {
                    System.IO.Directory.CreateDirectory(folderPath);
                }

                result.FileName = GlobalHelper.CapSoSite + "/" + GlobalHelper.Download + "/" + result.GetType().Name + "/" + Code + ".html";

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


                string physicalPathCreate = Path.Combine(GlobalHelper.CapSoFTP, result.GetType().Name);
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


        public virtual async Task<GoiSo> SaveByDanhMucPhongKhamID_GoiSoChiTietIDAsync(long DanhMucPhongKhamID, long GoiSoChiTietID)
        {
            GoiSo result = new GoiSo();
            try
            {
                DateTime Now = GlobalHelper.InitializationDateTime;
                result = await GetByCondition(item => item.DanhMucPhongKhamID == DanhMucPhongKhamID && item.NgayGhiNhan.Value.Year == Now.Year && item.NgayGhiNhan.Value.Month == Now.Month && item.NgayGhiNhan.Value.Day == Now.Day).FirstOrDefaultAsync();
                if (result == null)
                {
                    result = new GoiSo();
                    result.DanhMucPhongKhamID = DanhMucPhongKhamID;
                    result.NgayGhiNhan = Now;
                    result.TongCong = 0;
                    result.SoHienTai = 0;
                }
                result.TongCong = result.TongCong + 1;
                await SaveAsync(result);
                if (result.ID > 0)
                {
                    await SyncByDanhMucPhongKhamID_GoiSoChiTietIDAsync(result, GoiSoChiTietID);
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
        public virtual async Task<GoiSo> SyncByDanhMucPhongKhamID_GoiSoChiTietIDAsync(GoiSo model, long GoiSoChiTietID)
        {
            if (model.ID > 0)
            {
                if (model.DanhMucPhongKhamID > 0)
                {
                    if (GoiSoChiTietID > 0)
                    {
                        GoiSoChiTietPhongKham GoiSoChiTietPhongKham = new GoiSoChiTietPhongKham();
                        GoiSoChiTietPhongKham.ParentID = GoiSoChiTietID;
                        GoiSoChiTietPhongKham.DanhMucPhongKhamID = model.DanhMucPhongKhamID;
                        GoiSoChiTietPhongKham.NgayCapSoSoThuTu = model.TongCong;
                        await _GoiSoChiTietPhongKhamService.SaveAsync(GoiSoChiTietPhongKham);
                    }
                }
            }
            return model;
        }
        public virtual async Task<GoiSo> GoiSoTiepTheoByDanhMucPhongKhamIDAsync(long DanhMucPhongKhamID, int SoHienTai)
        {
            GoiSo result = new GoiSo();
            try
            {
                DateTime Now = GlobalHelper.InitializationDateTime;
                result = await GetByCondition(item => item.DanhMucPhongKhamID == DanhMucPhongKhamID && item.NgayGhiNhan.Value.Year == Now.Year && item.NgayGhiNhan.Value.Month == Now.Month && item.NgayGhiNhan.Value.Day == Now.Day).FirstOrDefaultAsync();
                if (result != null)
                {
                    if (SoHienTai > 0)
                    {
                        if (result.SoHienTai != SoHienTai)
                        {
                            result.SoHienTai = SoHienTai;
                        }
                    }
                    if (result.SoHienTai < result.TongCong)
                    {
                        result.SoHienTai = result.SoHienTai + 1;
                        await SaveAsync(result);
                    }
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

            GoiSoChiTietPhongKham GoiSoChiTietPhongKham = new GoiSoChiTietPhongKham();
            try
            {
                DateTime Now = GlobalHelper.InitializationDateTime;
                GoiSoChiTietPhongKham = await _GoiSoChiTietPhongKhamService.GetByDanhMucPhongKhamID_NgayCapSoSoThuTuAsync(DanhMucPhongKhamID, result.SoHienTai.Value);
                if (GoiSoChiTietPhongKham != null)
                {
                    GoiSoChiTietPhongKham.DanhMucPhongKhamID = DanhMucPhongKhamID;
                    GoiSoChiTietPhongKham.NgayDangKySoThuTu = result.SoHienTai;
                    GoiSoChiTietPhongKham.Active = true;
                    await _GoiSoChiTietPhongKhamService.SaveAsync(GoiSoChiTietPhongKham);

                    GoiSoChiTiet GoiSoChiTiet = new GoiSoChiTiet();
                    try
                    {
                        GoiSoChiTiet = await _GoiSoChiTietService.GetByIDAsync(GoiSoChiTietPhongKham.ParentID.Value);
                        if (GoiSoChiTiet != null)
                        {
                            GoiSoChiTiet.DanhMucPhongKhamID = DanhMucPhongKhamID;
                            GoiSoChiTiet.Active = true;
                            await _GoiSoChiTietService.SaveAsync(GoiSoChiTiet);
                        }
                    }
                    catch (Exception ex)
                    {
                        string mes = ex.Message;
                    }
                }
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }

        public virtual async Task<List<GoiSo>> GetByNgayGhiNhanToListAsync(DateTime NgayGhiNhan)
        {
            List<GoiSo> result = new List<GoiSo>();
            try
            {
                result = await GetByCondition(item => item.NgayGhiNhan.Value.Year == NgayGhiNhan.Year && item.NgayGhiNhan.Value.Month == NgayGhiNhan.Month && item.NgayGhiNhan.Value.Day == NgayGhiNhan.Day).ToListAsync();

            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            if (result == null)
            {
                result = new List<GoiSo>();
            }
            return result;
        }
    }
}

