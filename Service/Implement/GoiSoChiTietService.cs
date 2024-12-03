



using Microsoft.VisualBasic;

namespace Service.Implement
{
    public class GoiSoChiTietService : BaseService<GoiSoChiTiet, IGoiSoChiTietRepository>
    , IGoiSoChiTietService
    {
        private readonly IGoiSoChiTietRepository _GoiSoChiTietRepository;

        private readonly IGoiSoChiTietPhongKhamService _GoiSoChiTietPhongKhamService;

        private readonly IDanhMucDichVuRepository _DanhMucDichVuRepository;

        private readonly IDanhMucQuayDichVuRepository _DanhMucQuayDichVuRepository;

        private readonly IDanhMucPhongKhamRepository _DanhMucPhongKhamRepository;

        private readonly IKhachHangService _KhachHangService;

        private readonly IDanhMucTinhThanhRepository _DanhMucTinhThanhRepository;
        private readonly IDanhMucQuanHuyenRepository _DanhMucQuanHuyenRepository;
        private readonly IDanhMucXaPhuongRepository _DanhMucXaPhuongRepository;

        private readonly IWebHostEnvironment _WebHostEnvironment;
        public GoiSoChiTietService(IGoiSoChiTietRepository GoiSoChiTietRepository

            , IGoiSoChiTietPhongKhamService GoiSoChiTietPhongKhamService

            , IDanhMucDichVuRepository danhMucDichVuRepository

            , IDanhMucQuayDichVuRepository DanhMucQuayDichVuRepository

            , IDanhMucPhongKhamRepository DanhMucPhongKhamRepository

            , IKhachHangService KhachHangService

            , IDanhMucTinhThanhRepository DanhMucTinhThanhRepository
            , IDanhMucQuanHuyenRepository DanhMucQuanHuyenRepository
            , IDanhMucXaPhuongRepository DanhMucXaPhuongRepository

            , IWebHostEnvironment WebHostEnvironment

            ) : base(GoiSoChiTietRepository)
        {
            _GoiSoChiTietRepository = GoiSoChiTietRepository;
            _GoiSoChiTietPhongKhamService = GoiSoChiTietPhongKhamService;

            _DanhMucDichVuRepository = danhMucDichVuRepository;
            _DanhMucQuayDichVuRepository = DanhMucQuayDichVuRepository;
            _DanhMucPhongKhamRepository = DanhMucPhongKhamRepository;

            _KhachHangService = KhachHangService;

            _DanhMucTinhThanhRepository = DanhMucTinhThanhRepository;
            _DanhMucQuanHuyenRepository = DanhMucQuanHuyenRepository;
            _DanhMucXaPhuongRepository = DanhMucXaPhuongRepository;

            _WebHostEnvironment = WebHostEnvironment;
        }
        public override void Initialization(GoiSoChiTiet model)
        {
            BaseInitialization(model);

            if (model.GioiTinh == null)
            {
                model.GioiTinh = false;
            }
            if (model.DanhMucTinhThanhID > 0)
            {
                model.DanhMucTinhThanhName = _DanhMucTinhThanhRepository.GetByID(model.DanhMucTinhThanhID.Value).Name;
            }
            if (model.DanhMucQuanHuyenID > 0)
            {
                model.DanhMucQuanHuyenName = _DanhMucQuanHuyenRepository.GetByID(model.DanhMucQuanHuyenID.Value).Name;
            }
            if (model.DanhMucXaPhuongID > 0)
            {
                model.DanhMucXaPhuongName = _DanhMucTinhThanhRepository.GetByID(model.DanhMucXaPhuongID.Value).Name;
            }

            if (string.IsNullOrEmpty(model.Barcode))
            {
                string folderPath = Path.Combine(_WebHostEnvironment.WebRootPath, model.GetType().Name);
                bool isFolderExists = System.IO.Directory.Exists(folderPath);
                if (!isFolderExists)
                {
                    System.IO.Directory.CreateDirectory(folderPath);
                }
                Barcode Barcode = new Barcode();
                Barcode = Ean13.CreateEAN13(folderPath);
                model.Barcode = Barcode.Code;
                model.BarcodeFileName = GlobalHelper.APISite + "/" + model.GetType().Name + "/" + Barcode.FileName;
            }
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
                    model.DanhMucDichVuCode = DanhMucDichVu.Code;
                    model.Note = DanhMucDichVu.Note;
                }
            }
            if (model.DanhMucQuayDichVuID > 0)
            {
                if (string.IsNullOrEmpty(model.DanhMucQuayDichVuName))
                {
                    DanhMucQuayDichVu DanhMucQuayDichVu = _DanhMucQuayDichVuRepository.GetByID(model.DanhMucQuayDichVuID.Value);
                    model.DanhMucQuayDichVuName = DanhMucQuayDichVu.Name;
                    model.DanhMucQuayDichVuCode = DanhMucQuayDichVu.Code;
                }
            }
            if (model.DanhMucPhongKhamID > 0)
            {
                if (string.IsNullOrEmpty(model.DanhMucPhongKhamName))
                {
                    DanhMucPhongKham DanhMucPhongKham = _DanhMucPhongKhamRepository.GetByID(model.DanhMucPhongKhamID.Value);
                    model.DanhMucPhongKhamName = DanhMucPhongKham.Name;
                    model.DanhMucPhongKhamCode = DanhMucPhongKham.Code;
                }
            }
            if (string.IsNullOrEmpty(model.NgayCapSoSoThuTuString))
            {
                if (model.NgayCapSoSoThuTu > 0)
                {
                    model.NgayCapSo = GlobalHelper.InitializationDateTime;
                    model.NgayCapSoSoThuTuString = model.NgayCapSoSoThuTu.ToString();
                    if (model.NgayCapSoSoThuTu < 10)
                    {
                        model.NgayCapSoSoThuTuString = "000" + model.NgayCapSoSoThuTuString;
                    }
                    else
                    {
                        if (model.NgayCapSoSoThuTu < 100)
                        {
                            model.NgayCapSoSoThuTuString = "00" + model.NgayCapSoSoThuTuString;
                        }
                        else
                        {
                            if (model.NgayCapSoSoThuTu < 1000)
                            {
                                model.NgayCapSoSoThuTuString = "0" + model.NgayCapSoSoThuTuString;
                            }
                        }
                    }
                }
            }

            if (string.IsNullOrEmpty(model.Code))
            {
                model.Code = model.NgayCapSoSoThuTuString;
            }
            if (string.IsNullOrEmpty(model.DienThoai))
            {
                model.DienThoai = model.Code;
            }

            if (string.IsNullOrEmpty(model.NgayDangKySoThuTuString))
            {
                if (model.NgayDangKySoThuTu > 0)
                {
                    model.NgayDangKy = GlobalHelper.InitializationDateTime;
                    model.NgayDangKySoThuTuString = model.NgayCapSoSoThuTu.ToString();
                    if (model.NgayDangKySoThuTu < 10)
                    {
                        model.NgayDangKySoThuTuString = "000" + model.NgayDangKySoThuTuString;
                    }
                    else
                    {
                        if (model.NgayDangKySoThuTu < 100)
                        {
                            model.NgayDangKySoThuTuString = "00" + model.NgayDangKySoThuTuString;
                        }
                        else
                        {
                            if (model.NgayDangKySoThuTu < 1000)
                            {
                                model.NgayDangKySoThuTuString = "0" + model.NgayDangKySoThuTuString;
                            }
                        }
                    }
                }
            }
            if (string.IsNullOrEmpty(model.NgayThanhToanSoThuTuString))
            {
                if (model.NgayThanhToanSoThuTu > 0)
                {
                    model.NgayThanhToan = GlobalHelper.InitializationDateTime;
                    model.NgayThanhToanSoThuTuString = model.NgayCapSoSoThuTu.ToString();
                    if (model.NgayThanhToanSoThuTu < 10)
                    {
                        model.NgayThanhToanSoThuTuString = "000" + model.NgayThanhToanSoThuTuString;
                    }
                    else
                    {
                        if (model.NgayThanhToanSoThuTu < 100)
                        {
                            model.NgayThanhToanSoThuTuString = "00" + model.NgayThanhToanSoThuTuString;
                        }
                        else
                        {
                            if (model.NgayThanhToanSoThuTu < 1000)
                            {
                                model.NgayThanhToanSoThuTuString = "0" + model.NgayThanhToanSoThuTuString;
                            }
                        }
                    }
                }
            }
            if (string.IsNullOrEmpty(model.NgayLinhThuocSoThuTuString))
            {
                if (model.NgayLinhThuocSoThuTu > 0)
                {
                    model.NgayLinhThuoc = GlobalHelper.InitializationDateTime;
                    model.NgayLinhThuocSoThuTuString = model.NgayCapSoSoThuTu.ToString();
                    if (model.NgayLinhThuocSoThuTu < 10)
                    {
                        model.NgayLinhThuocSoThuTuString = "000" + model.NgayLinhThuocSoThuTuString;
                    }
                    else
                    {
                        if (model.NgayLinhThuocSoThuTu < 100)
                        {
                            model.NgayLinhThuocSoThuTuString = "00" + model.NgayLinhThuocSoThuTuString;
                        }
                        else
                        {
                            if (model.NgayLinhThuocSoThuTu < 1000)
                            {
                                model.NgayLinhThuocSoThuTuString = "0" + model.NgayLinhThuocSoThuTuString;
                            }
                        }
                    }
                }
            }
        }
        public override async Task<GoiSoChiTiet> SaveAsync(GoiSoChiTiet model)
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
        public virtual async Task<GoiSoChiTiet> Sync(GoiSoChiTiet model)
        {
            if (model.ID > 0)
            {
                if (!string.IsNullOrEmpty(model.DienThoai))
                {
                    KhachHang KhachHang = new KhachHang();
                    KhachHang.Code = model.Code;
                    KhachHang.HoTen = model.HoTen;
                    KhachHang.DienThoai = model.DienThoai;
                    KhachHang.CCCD = model.CCCD;
                    KhachHang.BHYT = model.BHYT;
                    KhachHang.GioiTinh = model.GioiTinh;
                    KhachHang.DanhMucTinhThanhID = model.DanhMucTinhThanhID;
                    KhachHang.DanhMucQuanHuyenID = model.DanhMucQuanHuyenID;
                    KhachHang.DanhMucXaPhuongID = model.DanhMucXaPhuongID;
                    await _KhachHangService.SaveAsync(KhachHang);
                    if (KhachHang.ID > 0)
                    {
                        model.KhachHangID = KhachHang.ID;
                        await _GoiSoChiTietRepository.UpdateAsync(model);
                    }
                }
            }
            return model;
        }
        public virtual async Task<GoiSoChiTiet> GetByDanhMucDichVuID_NgayCapSoSoThuTuAsync(long DanhMucDichVuID, int NgayCapSoSoThuTu)
        {
            GoiSoChiTiet result = new GoiSoChiTiet();
            try
            {
                DateTime Now = GlobalHelper.InitializationDateTime;
                result = await GetByCondition(item => item.DanhMucDichVuID == DanhMucDichVuID && item.NgayCapSoSoThuTu == NgayCapSoSoThuTu && item.NgayCapSo.Value.Year == Now.Year && item.NgayCapSo.Value.Month == Now.Month && item.NgayCapSo.Value.Day == Now.Day).FirstOrDefaultAsync();
                if (result == null)
                {
                    result = new GoiSoChiTiet();
                }
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            if (result == null)
            {
                result = new GoiSoChiTiet();
            }
            return result;
        }
        public virtual async Task<GoiSoChiTiet> GetByDanhMucPhongKhamID_NgayCapSoSoThuTuAsync(long DanhMucPhongKhamID, int NgayCapSoSoThuTu)
        {
            GoiSoChiTiet result = new GoiSoChiTiet();
            try
            {
                DateTime Now = GlobalHelper.InitializationDateTime;
                result = await GetByCondition(item => item.DanhMucPhongKhamID == DanhMucPhongKhamID && item.NgayCapSoSoThuTu == NgayCapSoSoThuTu && item.NgayCapSo.Value.Year == Now.Year && item.NgayCapSo.Value.Month == Now.Month && item.NgayCapSo.Value.Day == Now.Day).FirstOrDefaultAsync();
                if (result == null)
                {
                    result = new GoiSoChiTiet();
                }
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            if (result == null)
            {
                result = new GoiSoChiTiet();
            }
            return result;
        }
        public virtual async Task<GoiSoChiTiet> GetNgayCapSoSoThuTuStringToAsync(string NgayCapSoSoThuTuString)
        {
            GoiSoChiTiet result = new GoiSoChiTiet();
            if (!string.IsNullOrEmpty(NgayCapSoSoThuTuString))
            {
                result = await GetByCondition(item => item.NgayCapSoSoThuTuString == NgayCapSoSoThuTuString).FirstOrDefaultAsync();
            }
            if (result == null)
            {
                result = new GoiSoChiTiet();
            }
            return result;
        }
        public virtual async Task<List<DanhMucQuayDichVu>> GetGoiSoChiTietDangKy01ToListAsync()
        {
            List<GoiSoChiTiet> result = new List<GoiSoChiTiet>();
            List<DanhMucQuayDichVu> ListDanhMucQuayDichVu = await _DanhMucQuayDichVuRepository.GetByActiveToListAsync(true);
            DateTime Now = GlobalHelper.InitializationDateTime;
            for (int i = 0; i < ListDanhMucQuayDichVu.Count; i++)
            {
                ListDanhMucQuayDichVu[i].SortOrder = GlobalHelper.InitializationNumber;
                ListDanhMucQuayDichVu[i].Display = GlobalHelper.InitializationString;
                result = await GetByCondition(item => item.DanhMucQuayDichVuID == ListDanhMucQuayDichVu[i].ID && item.Active == true && item.NgayDangKy.Value.Year == Now.Year && item.NgayDangKy.Value.Month == Now.Month && item.NgayDangKy.Value.Day == Now.Day).OrderByDescending(item => item.NgayDangKySoThuTu).Take(1).ToListAsync();
                if (result != null)
                {
                    if (result.Count > 0)
                    {
                        ListDanhMucQuayDichVu[i].SortOrder = result[0].NgayDangKySoThuTu;
                        ListDanhMucQuayDichVu[i].Display = result[0].NgayDangKySoThuTuString;
                    }
                }
            }
            return ListDanhMucQuayDichVu;
        }

        public virtual async Task<List<DanhMucQuayDichVu>> GetGoiSoChiTietDangKy02ToListAsync(List<long> ListDanhMucQuayDichVuID)
        {
            List<DanhMucQuayDichVu> ListDanhMucQuayDichVu = new List<DanhMucQuayDichVu>();
            try
            {
                if (ListDanhMucQuayDichVuID.Count > 0)
                {
                    List<GoiSoChiTiet> ListGoiSoChiTiet = new List<GoiSoChiTiet>();
                    ListDanhMucQuayDichVu = await _DanhMucQuayDichVuRepository.GetByCondition(item => ListDanhMucQuayDichVuID.Contains(item.ID)).ToListAsync();
                    if (ListDanhMucQuayDichVu.Count > 0)
                    {
                        DateTime Now = GlobalHelper.InitializationDateTime;
                        for (int i = 0; i < ListDanhMucQuayDichVu.Count; i++)
                        {
                            ListDanhMucQuayDichVu[i].SortOrder = GlobalHelper.InitializationNumber;
                            ListDanhMucQuayDichVu[i].Display = GlobalHelper.InitializationString;
                            ListGoiSoChiTiet = await GetByCondition(item => item.DanhMucQuayDichVuID == ListDanhMucQuayDichVu[i].ID && item.Active == true && item.NgayDangKy.Value.Year == Now.Year && item.NgayDangKy.Value.Month == Now.Month && item.NgayDangKy.Value.Day == Now.Day).OrderByDescending(item => item.NgayDangKySoThuTu).Take(1).ToListAsync();
                            if (ListGoiSoChiTiet != null)
                            {
                                if (ListGoiSoChiTiet.Count > 0)
                                {
                                    ListDanhMucQuayDichVu[i].SortOrder = ListGoiSoChiTiet[0].NgayDangKySoThuTu;
                                    ListDanhMucQuayDichVu[i].Display = ListGoiSoChiTiet[0].NgayDangKySoThuTuString;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            if (ListDanhMucQuayDichVu == null)
            {
                ListDanhMucQuayDichVu = new List<DanhMucQuayDichVu>();
            }
            return ListDanhMucQuayDichVu;
        }
        public virtual async Task<List<DanhMucQuayDichVu>> GetGoiSoChiTietDangKy02_001ToListAsync(string SearchString)
        {
            List<DanhMucQuayDichVu> ListDanhMucQuayDichVu = new List<DanhMucQuayDichVu>();
            try
            {
                if (!string.IsNullOrEmpty(SearchString))
                {
                    List<long> ListDanhMucQuayDichVuID = new List<long>();
                    foreach (string DanhMucQuayDichVuIDString in SearchString.Split('-'))
                    {
                        if (!string.IsNullOrEmpty(DanhMucQuayDichVuIDString))
                        {
                            try
                            {
                                ListDanhMucQuayDichVuID.Add(long.Parse(DanhMucQuayDichVuIDString));
                            }
                            catch (Exception ex)
                            {
                                string message = ex.Message;
                            }
                        }
                    }
                    ListDanhMucQuayDichVu = await GetGoiSoChiTietDangKy02ToListAsync(ListDanhMucQuayDichVuID);
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return ListDanhMucQuayDichVu;
        }
        public virtual async Task<List<DanhMucQuayDichVu>> GetGoiSoChiTietDangKy02_002ToListAsync(string SearchString)
        {
            List<DanhMucQuayDichVu> ListDanhMucQuayDichVu = new List<DanhMucQuayDichVu>();
            try
            {
                if (!string.IsNullOrEmpty(SearchString))
                {
                    List<long> ListDanhMucQuayDichVuID = new List<long>();
                    List<string> ListDanhMucQuayDichVuCode = new List<string>();
                    foreach (string Code in SearchString.Split('-'))
                    {
                        if (!string.IsNullOrEmpty(Code))
                        {
                            ListDanhMucQuayDichVuCode.Add(Code);
                        }
                    }
                    ListDanhMucQuayDichVuID = await _DanhMucQuayDichVuRepository.GetByCondition(item => ListDanhMucQuayDichVuCode.Contains(item.Code)).Select(item => item.ID).ToListAsync();
                    ListDanhMucQuayDichVu = await GetGoiSoChiTietDangKy02ToListAsync(ListDanhMucQuayDichVuID);
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return ListDanhMucQuayDichVu;
        }
        public virtual async Task<List<GoiSoChiTiet>> GetGoiSoChiTietDangKy03ToListAsync(long DanhMucQuayDichVuID, long DanhMucDichVuID, int Number)
        {
            List<GoiSoChiTiet> result = new List<GoiSoChiTiet>();
            DateTime Now = GlobalHelper.InitializationDateTime;
            result.AddRange(await GetByCondition(item => item.DanhMucQuayDichVuID == DanhMucQuayDichVuID && item.DanhMucDichVuID == DanhMucDichVuID && item.Active == true && item.NgayDangKy.Value.Year == Now.Year && item.NgayDangKy.Value.Month == Now.Month && item.NgayDangKy.Value.Day == Now.Day).OrderByDescending(item => item.NgayDangKySoThuTu).Take(1).ToListAsync());
            result.AddRange(await GetByCondition(item => item.DanhMucDichVuID == DanhMucDichVuID && item.Active == false && item.NgayDangKy.Value.Year == Now.Year && item.NgayDangKy.Value.Month == Now.Month && item.NgayDangKy.Value.Day == Now.Day).OrderBy(item => item.NgayDangKySoThuTu).Take(Number).ToListAsync());

            if (result == null)
            {
                result = new List<GoiSoChiTiet>();
            }
            return result;
        }
        public virtual async Task<List<GoiSoChiTiet>> GetGoiSoChiTietDangKy04ToListAsync(long DanhMucQuayDichVuID, int Number)
        {
            List<GoiSoChiTiet> result = new List<GoiSoChiTiet>();
            try
            {
                if (DanhMucQuayDichVuID > 0)
                {
                    if (Number > 0)
                    {
                        DateTime Now = GlobalHelper.InitializationDateTime;
                        result.AddRange(await GetByCondition(item => item.DanhMucQuayDichVuID == DanhMucQuayDichVuID && item.Active == true && item.NgayDangKy.Value.Year == Now.Year && item.NgayDangKy.Value.Month == Now.Month && item.NgayDangKy.Value.Day == Now.Day).OrderBy(item => item.NgayDangKySoThuTu).Take(Number).ToListAsync());
                        if (result == null)
                        {
                            result = new List<GoiSoChiTiet>();
                        }
                        if (result.Count < Number)
                        {
                            DanhMucQuayDichVu DanhMucQuayDichVu = await _DanhMucQuayDichVuRepository.GetByIDAsync(DanhMucQuayDichVuID);
                            for (int i = result.Count; i < Number; i++)
                            {
                                GoiSoChiTiet GoiSoChiTiet = new GoiSoChiTiet();
                                GoiSoChiTiet.DanhMucQuayDichVuID = DanhMucQuayDichVu.ID;
                                GoiSoChiTiet.DanhMucQuayDichVuCode = DanhMucQuayDichVu.Code;
                                GoiSoChiTiet.NgayDangKy = Now;
                                result.Add(GoiSoChiTiet);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            if (result == null)
            {
                result = new List<GoiSoChiTiet>();
            }
            return result;
        }
        public virtual async Task<List<GoiSoChiTiet>> GetGoiSoChiTietDangKy04_001ToListAsync(string Code, int Number)
        {
            List<GoiSoChiTiet> result = new List<GoiSoChiTiet>();
            if (!string.IsNullOrEmpty(Code))
            {
                DanhMucQuayDichVu DanhMucQuayDichVu = await _DanhMucQuayDichVuRepository.GetByCodeAsync(Code);
                if (DanhMucQuayDichVu.ID > 0)
                {
                    result = await GetGoiSoChiTietDangKy04ToListAsync(DanhMucQuayDichVu.ID, Number);
                }
            }
            if (result == null)
            {
                result = new List<GoiSoChiTiet>();
            }
            return result;
        }
        public virtual async Task<List<GoiSoChiTiet>> GetGoiSoChiTietDangKy05ToListAsync(long DanhMucPhongKhamID, int Number)
        {
            List<GoiSoChiTiet> result = new List<GoiSoChiTiet>();
            List<GoiSoChiTietPhongKham> ListGoiSoChiTietPhongKham = new List<GoiSoChiTietPhongKham>();

            DateTime Now = GlobalHelper.InitializationDateTime;
            ListGoiSoChiTietPhongKham.AddRange(await _GoiSoChiTietPhongKhamService.GetByCondition(item => item.DanhMucPhongKhamID == DanhMucPhongKhamID && item.Active == true && item.NgayDangKy.Value.Year == Now.Year && item.NgayDangKy.Value.Month == Now.Month && item.NgayDangKy.Value.Day == Now.Day).OrderByDescending(item => item.NgayCapSoSoThuTu).Take(1).ToListAsync());
            ListGoiSoChiTietPhongKham.AddRange(await _GoiSoChiTietPhongKhamService.GetByCondition(item => item.DanhMucPhongKhamID == DanhMucPhongKhamID && item.Active == false && item.NgayCapSo.Value.Year == Now.Year && item.NgayCapSo.Value.Month == Now.Month && item.NgayCapSo.Value.Day == Now.Day).OrderBy(item => item.NgayCapSoSoThuTu).Take(Number).ToListAsync());
            if (ListGoiSoChiTietPhongKham.Count > 0)
            {
                List<long> ListGoiSoChiTietID = new List<long>();
                ListGoiSoChiTietID = ListGoiSoChiTietPhongKham.Select(item => item.ParentID.Value).ToList();
                result = await GetByCondition(item => ListGoiSoChiTietID.Contains(item.ID)).ToListAsync();
            }
            if (result == null)
            {
                result = new List<GoiSoChiTiet>();
            }
            return result;
        }
    }
}

