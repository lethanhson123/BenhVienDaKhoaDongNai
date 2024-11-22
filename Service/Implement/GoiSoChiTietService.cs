using Data.Model;
using Microsoft.IdentityModel.Tokens;
using Microsoft.SqlServer.Server;
using Microsoft.VisualBasic;
using Service.Interface;

namespace Service.Implement
{
    public class GoiSoChiTietService : BaseService<GoiSoChiTiet, IGoiSoChiTietRepository>
    , IGoiSoChiTietService
    {
        private readonly IGoiSoChiTietRepository _GoiSoChiTietRepository;

        private readonly IDanhMucDichVuRepository _DanhMucDichVuRepository;

        private readonly IDanhMucQuayDichVuRepository _DanhMucQuayDichVuRepository;

        private readonly IKhachHangService _KhachHangService;
        public GoiSoChiTietService(IGoiSoChiTietRepository GoiSoChiTietRepository

            , IDanhMucDichVuRepository danhMucDichVuRepository

            , IDanhMucQuayDichVuRepository DanhMucQuayDichVuRepository

            , IKhachHangService KhachHangService

            ) : base(GoiSoChiTietRepository)
        {
            _GoiSoChiTietRepository = GoiSoChiTietRepository;
            _DanhMucDichVuRepository = danhMucDichVuRepository;
            _DanhMucQuayDichVuRepository = DanhMucQuayDichVuRepository;
            _KhachHangService = KhachHangService;
        }
        public override void Initialization(GoiSoChiTiet model)
        {
            BaseInitialization(model);
            if (model.DanhMucDichVuID > 0)
            {
                if (string.IsNullOrEmpty(model.DanhMucDichVuName))
                {
                    DanhMucDichVu DanhMucDichVu = _DanhMucDichVuRepository.GetByID(model.DanhMucDichVuID.Value);
                    model.DanhMucDichVuName = DanhMucDichVu.Name;
                    model.Note = DanhMucDichVu.Note;
                }
            }
            if (model.DanhMucQuayDichVuID > 0)
            {
                if (string.IsNullOrEmpty(model.DanhMucQuayDichVuName))
                {
                    DanhMucQuayDichVu DanhMucQuayDichVu = _DanhMucQuayDichVuRepository.GetByID(model.DanhMucQuayDichVuID.Value);
                    model.DanhMucQuayDichVuName = DanhMucQuayDichVu.Name;
                }
            }
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
                    KhachHang.HoTen = model.HoTen;
                    KhachHang.DienThoai = model.DienThoai;
                    KhachHang.CCCD = model.CCCD;
                    KhachHang.HoTen = model.HoTen;
                    KhachHang.HoTen = model.HoTen;
                    KhachHang.HoTen = model.HoTen;
                    await _KhachHangService.SaveAsync(KhachHang);
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
            List<GoiSoChiTiet> result = new List<GoiSoChiTiet>();
            List<DanhMucQuayDichVu> ListDanhMucQuayDichVu = await _DanhMucQuayDichVuRepository.GetByCondition(item => ListDanhMucQuayDichVuID.Contains(item.ID)).ToListAsync();
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
        public virtual async Task<List<DanhMucQuayDichVu>> GetGoiSoChiTietDangKy02_001ToListAsync(string SearchString)
        {
            List<DanhMucQuayDichVu> ListDanhMucQuayDichVu = new List<DanhMucQuayDichVu>();
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
            return ListDanhMucQuayDichVu;
        }
        public virtual async Task<List<GoiSoChiTiet>> GetGoiSoChiTietDangKy03ToListAsync(long DanhMucQuayDichVuID, long DanhMucDichVuID, int Number)
        {
            List<GoiSoChiTiet> result = new List<GoiSoChiTiet>();
            DateTime Now = GlobalHelper.InitializationDateTime;
            result.AddRange(await GetByCondition(item => item.DanhMucQuayDichVuID == DanhMucQuayDichVuID && item.Active == true && item.NgayDangKy.Value.Year == Now.Year && item.NgayDangKy.Value.Month == Now.Month && item.NgayDangKy.Value.Day == Now.Day).OrderByDescending(item => item.NgayDangKySoThuTu).Take(1).ToListAsync());
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
            DateTime Now = GlobalHelper.InitializationDateTime;
            result.AddRange(await GetByCondition(item => item.DanhMucQuayDichVuID == DanhMucQuayDichVuID && item.Active == true && item.NgayDangKy.Value.Year == Now.Year && item.NgayDangKy.Value.Month == Now.Month && item.NgayDangKy.Value.Day == Now.Day).OrderBy(item => item.NgayDangKySoThuTu).Take(Number).ToListAsync());

            if (result == null)
            {
                result = new List<GoiSoChiTiet>();
            }
            return result;
        }
    }
}

