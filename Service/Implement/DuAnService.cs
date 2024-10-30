using Microsoft.AspNetCore.Hosting;

namespace Service.Implement
{
    public class DuAnService : BaseService<DuAn, IDuAnRepository>
    , IDuAnService
    {
        private readonly IDuAnRepository _DuAnRepository;

        private readonly IDuAnThuChiService _DuAnThuChiService;

        private readonly IDuAnTapTinDinhKemService _DuAnTapTinDinhKemService;

        private readonly IToChucRepository _ToChucRepository;

        private readonly IToChucTaiKhoanRepository _ToChucTaiKhoanRepository;

        private readonly IThanhVienRepository _ThanhVienRepository;

        private readonly IDanhMucTinhTrangRepository _DanhMucTinhTrangRepository;

        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DuAnService(IDuAnRepository DuAnRepository

            , IDuAnThuChiService DuAnThuChiService

            , IDuAnTapTinDinhKemService DuAnTapTinDinhKemService

            , IToChucRepository ToChucRepository

            , IToChucTaiKhoanRepository ToChucTaiKhoanRepository

            , IThanhVienRepository ThanhVienRepository

            , IDanhMucTinhTrangRepository DanhMucTinhTrangRepository

            , IWebHostEnvironment WebHostEnvironment

            ) : base(DuAnRepository)
        {
            _DuAnRepository = DuAnRepository;

            _DuAnThuChiService = DuAnThuChiService;

            _DuAnTapTinDinhKemService = DuAnTapTinDinhKemService;

            _ToChucRepository = ToChucRepository;

            _ToChucTaiKhoanRepository = ToChucTaiKhoanRepository;

            _ThanhVienRepository = ThanhVienRepository;

            _DanhMucTinhTrangRepository = DanhMucTinhTrangRepository;

            _WebHostEnvironment = WebHostEnvironment;
        }

        public override void Initialization(DuAn model)
        {
            BaseInitialization(model);

            if (model.TypeName == null)
            {
                model.TypeName = GlobalHelper.InitializationGUICode;
            }

            if (model.Code == null)
            {
                model.Code = GlobalHelper.InitializationGUICode;
            }

            if (string.IsNullOrEmpty(model.FileName))
            {
                string folderPath = Path.Combine(_WebHostEnvironment.WebRootPath, model.GetType().Name);
                bool isFolderExists = System.IO.Directory.Exists(folderPath);
                if (!isFolderExists)
                {
                    System.IO.Directory.CreateDirectory(folderPath);
                }
                model.FileName = GlobalHelper.APISite + "/" + model.GetType().Name + "/" + model.Code + ".html";

                model.FileNameQRCode = GlobalHelper.APISite + "/" + model.GetType().Name + "/" + model.Code + ".png";

                QRCodeHelper.CreateQRCodeURL(model.Code, model.FileName, folderPath);
            }

            if (model.NgayBatDau == null)
            {
                model.NgayBatDau = GlobalHelper.InitializationDateTime;
            }

            if (model.DanhMucTinhTrangID == null)
            {
                model.DanhMucTinhTrangID = GlobalHelper.DanhMucThanhVienID;
            }
            if (model.DanhMucTinhTrangID > 0)
            {
                model.DanhMucTinhTrangName = _DanhMucTinhTrangRepository.GetByID(model.DanhMucTinhTrangID.Value).Name;
            }

            if (model.BenDauTuID > 0)
            {
                ToChuc ToChuc = _ToChucRepository.GetByID(model.BenDauTuID.Value);
                model.BenDauTuName = ToChuc.Name;
                model.BenDauTuMaSoThue = ToChuc.MaSoThue;
                model.BenDauTuDienThoai = ToChuc.DienThoai;
                model.BenDauTuDiaChi = ToChuc.DiaChi;
                model.BenDauTuEmail = ToChuc.Email;
            }
            else
            {
                if (!string.IsNullOrEmpty(model.BenDauTuName))
                {
                    ToChuc ToChuc = _ToChucRepository.GetByName(model.BenDauTuName);
                    if (ToChuc == null)
                    {
                        ToChuc = new ToChuc();
                        ToChuc.Name = model.BenDauTuName;
                        _ToChucRepository.Add(ToChuc);
                    }
                    model.BenDauTuID = ToChuc.ID;
                }
            }

            if (model.BenDauTuTaiKhoanID > 0)
            {
                ToChucTaiKhoan ToChucTaiKhoan = _ToChucTaiKhoanRepository.GetByID(model.BenDauTuTaiKhoanID.Value);
                model.BenDauTuSoTaiKhoan = ToChucTaiKhoan.Display;
                model.BenDauTuNganHang = ToChucTaiKhoan.Description;
            }

            if (model.BenThucHienID > 0)
            {
                ToChuc ToChuc = _ToChucRepository.GetByID(model.BenThucHienID.Value);
                model.BenThucHienName = ToChuc.Name;
                model.BenThucHienMaSoThue = ToChuc.MaSoThue;
                model.BenThucHienDienThoai = ToChuc.DienThoai;
                model.BenThucHienDiaChi = ToChuc.DiaChi;
                model.BenThucHienEmail = ToChuc.Email;
            }
            else
            {
                if (!string.IsNullOrEmpty(model.BenThucHienName))
                {
                    ToChuc ToChuc = _ToChucRepository.GetByName(model.BenThucHienName);
                    if (ToChuc == null)
                    {
                        ToChuc = new ToChuc();
                        ToChuc.Name = model.BenThucHienName;
                        _ToChucRepository.Add(ToChuc);
                    }
                    model.BenThucHienID = ToChuc.ID;
                }
            }

            if (model.BenThucHienTaiKhoanID > 0)
            {
                ToChucTaiKhoan ToChucTaiKhoan = _ToChucTaiKhoanRepository.GetByID(model.BenThucHienTaiKhoanID.Value);
                model.BenThucHienSoTaiKhoan = ToChucTaiKhoan.Display;
                model.BenThucHienNganHang = ToChucTaiKhoan.Description;
            }

            if (model.NguoiDauTuID > 0)
            {
                ThanhVien ThanhVien = _ThanhVienRepository.GetByID(model.NguoiDauTuID.Value);
                model.NguoiDauTuName = ThanhVien.Name;
                model.NguoiDauTuChucDanh = ThanhVien.DanhMucChucDanhName;
            }
            else
            {
                if (!string.IsNullOrEmpty(model.NguoiDauTuName))
                {
                    ThanhVien ThanhVien = _ThanhVienRepository.GetByName(model.NguoiDauTuName);
                    if (ThanhVien == null)
                    {
                        ThanhVien = new ThanhVien();
                        ThanhVien.Name = model.NguoiDauTuName;
                        _ThanhVienRepository.Add(ThanhVien);
                    }
                    model.NguoiDauTuID = ThanhVien.ID;
                }
            }

            if (model.NguoiThucHienID > 0)
            {
                ThanhVien ThanhVien = _ThanhVienRepository.GetByID(model.NguoiThucHienID.Value);
                model.NguoiThucHienName = ThanhVien.Name;
                model.NguoiThucHienChucDanh = ThanhVien.DanhMucChucDanhName;
            }
            else
            {
                if (!string.IsNullOrEmpty(model.NguoiThucHienName))
                {
                    ThanhVien ThanhVien = _ThanhVienRepository.GetByName(model.NguoiThucHienName);
                    if (ThanhVien == null)
                    {
                        ThanhVien = new ThanhVien();
                        ThanhVien.Name = model.NguoiThucHienName;
                        _ThanhVienRepository.Add(ThanhVien);
                    }
                    model.NguoiThucHienID = ThanhVien.ID;
                }
            }
        }
        public override async Task<DuAn> SaveAsync(DuAn model)
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
        private async Task<int> Sync(DuAn model)
        {
            int result = GlobalHelper.InitializationNumber;
            if (model != null)
            {
                if (model.ID > 0)
                {
                    List<DuAnThuChi> ListDuAnThuChi = await _DuAnThuChiService.GetBySearchStringToListAsync(model.Code);
                    for (int i = 0; i < ListDuAnThuChi.Count; i++)
                    {
                        DuAnThuChi DuAnThuChiItem = ListDuAnThuChi[i];
                        DuAnThuChiItem.ParentID = model.ID;
                        DuAnThuChiItem.TypeName = model.TypeName;
                        await _DuAnThuChiService.SaveAsync(DuAnThuChiItem);
                    }

                    List<DuAnTapTinDinhKem> ListDuAnTapTinDinhKem = await _DuAnTapTinDinhKemService.GetBySearchStringToListAsync(model.Code);
                    for (int i = 0; i < ListDuAnThuChi.Count; i++)
                    {
                        DuAnTapTinDinhKem DuAnTapTinDinhKemItem = ListDuAnTapTinDinhKem[i];
                        DuAnTapTinDinhKemItem.DuAnID = model.ID;
                        DuAnTapTinDinhKemItem.TypeName = model.TypeName;
                        await _DuAnTapTinDinhKemService.SaveAsync(DuAnTapTinDinhKemItem);
                    }
                }
            }
            return result;
        }
        public virtual async Task<List<DuAn>> GetByBatDau_KetThucToListAsync(DateTime BatDau, DateTime KetThuc)
        {
            List<DuAn> result = new List<DuAn>();
            try
            {
                BatDau = new DateTime(BatDau.Year, BatDau.Month, BatDau.Day, 0, 0, 0);
                KetThuc = new DateTime(KetThuc.Year, KetThuc.Month, KetThuc.Day, 23, 59, 59);
                result = await GetByCondition(item => item.NgayBatDau >= BatDau && item.NgayBatDau <= KetThuc).ToListAsync();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        public override async Task<List<DuAn>> GetBySearchStringToListAsync(string SearchString)
        {
            List<DuAn> result = new List<DuAn>();
            try
            {
                if (!string.IsNullOrEmpty(SearchString))
                {

                    result = await GetByCondition(item => item.Name.Contains(SearchString)

                    || item.SoHoSo.Contains(SearchString)

                    || item.SoQuyetDinh.Contains(SearchString)

                    || item.BenDauTuName.Contains(SearchString)

                    || item.BenDauTuMaSoThue.Contains(SearchString)

                    || item.BenDauTuDienThoai.Contains(SearchString)

                    || item.BenDauTuEmail.Contains(SearchString)

                    || item.BenDauTuSoTaiKhoan.Contains(SearchString)

                    || item.BenThucHienName.Contains(SearchString)

                    || item.BenThucHienMaSoThue.Contains(SearchString)

                    || item.BenThucHienDienThoai.Contains(SearchString)

                    || item.BenThucHienEmail.Contains(SearchString)

                    || item.BenThucHienSoTaiKhoan.Contains(SearchString)

                    || item.NguoiDauTuName.Contains(SearchString)

                    || item.NguoiThucHienName.Contains(SearchString)

                    || item.DanhMucTinhTrangName.Contains(SearchString)

                    ).ToListAsync();
                }
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        public virtual async Task<List<DuAn>> GetBySearchString_BatDau_KetThucToListAsync(string SearchString, DateTime BatDau, DateTime KetThuc)
        {
            List<DuAn> result = new List<DuAn>();
            try
            {
                if (!string.IsNullOrEmpty(SearchString))
                {
                    result = await GetBySearchStringToListAsync(SearchString);
                }
                else
                {
                    result = await GetByBatDau_KetThucToListAsync(BatDau, KetThuc);
                }
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
    }
}

