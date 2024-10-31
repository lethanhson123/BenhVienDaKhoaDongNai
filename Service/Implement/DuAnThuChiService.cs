using Service.Interface;

namespace Service.Implement
{
    public class DuAnThuChiService : BaseService<DuAnThuChi, IDuAnThuChiRepository>
    , IDuAnThuChiService
    {
        private readonly IDuAnThuChiRepository _DuAnThuChiRepository;

        private readonly IDuAnRepository _DuAnRepository;

        private readonly IToChucRepository _ToChucRepository;

        private readonly IToChucTaiKhoanRepository _ToChucTaiKhoanRepository;

        private readonly IThanhVienRepository _ThanhVienRepository;

        private readonly IDanhMucTinhTrangRepository _DanhMucTinhTrangRepository;

        private readonly IDanhMucBieuMauRepository _DanhMucBieuMauRepository;

        private readonly IDanhMucHinhThucThanhToanRepository _DanhMucHinhThucThanhToanRepository;

        public DuAnThuChiService(IDuAnThuChiRepository DuAnThuChiRepository

            , IDuAnRepository DuAnRepository

            , IToChucRepository ToChucRepository

            , IToChucTaiKhoanRepository ToChucTaiKhoanRepository

            , IThanhVienRepository ThanhVienRepository

            , IDanhMucTinhTrangRepository DanhMucTinhTrangRepository

            , IDanhMucBieuMauRepository DanhMucBieuMauRepository

            , IDanhMucHinhThucThanhToanRepository DanhMucHinhThucThanhToanRepository

            ) : base(DuAnThuChiRepository)
        {
            _DuAnThuChiRepository = DuAnThuChiRepository;

            _DuAnRepository = DuAnRepository;

            _DanhMucBieuMauRepository = DanhMucBieuMauRepository;

            _ToChucRepository = ToChucRepository;

            _ToChucTaiKhoanRepository = ToChucTaiKhoanRepository;

            _ThanhVienRepository = ThanhVienRepository;

            _DanhMucTinhTrangRepository = DanhMucTinhTrangRepository;

            _DanhMucHinhThucThanhToanRepository = DanhMucHinhThucThanhToanRepository;
        }
        public override void Initialization(DuAnThuChi model)
        {
            BaseInitialization(model);

            if (model.NgayBatDau == null)
            {
                model.NgayBatDau = GlobalHelper.InitializationDateTime;
            }

            if (model.DanhMucHinhThucThanhToanID == null)
            {
                model.DanhMucHinhThucThanhToanID = GlobalHelper.DanhMucHinhThucThanhToanID;
            }
            if (model.DanhMucHinhThucThanhToanID > 0)
            {
                model.DanhMucHinhThucThanhToanName = _DanhMucHinhThucThanhToanRepository.GetByID(model.DanhMucHinhThucThanhToanID.Value).Name;
            }
            if (model.DanhMucTinhTrangID == null)
            {
                model.DanhMucTinhTrangID = GlobalHelper.DanhMucThanhVienID;
            }
            if (model.DanhMucTinhTrangID > 0)
            {
                model.DanhMucTinhTrangName = _DanhMucTinhTrangRepository.GetByID(model.DanhMucTinhTrangID.Value).Name;
            }
            if (model.DanhMucBieuMauID == null)
            {
                model.DanhMucBieuMauID = GlobalHelper.DanhMucBieuMauID;
            }
            if (model.DanhMucBieuMauID > 0)
            {
                DanhMucBieuMau DanhMucBieuMau = _DanhMucBieuMauRepository.GetByID(model.DanhMucBieuMauID.Value);
                model.DanhMucBieuMauName = DanhMucBieuMau.Name;
                model.HeSo = DanhMucBieuMau.HeSo;
            }
            if (model.SoLuong == null)
            {
                model.SoLuong = 1;
            }
            if (model.DonGia == null)
            {
                model.DonGia = 0;
            }
            if (model.HeSo == null)
            {
                model.HeSo = 1;
            }
            if (model.GhiCo == null)
            {
                model.GhiCo = 0;
            }
            if (model.GhiNo == null)
            {
                model.GhiNo = 0;
            }
            model.ThanhTien = model.SoLuong * model.DonGia * model.HeSo;
            if (model.ThanhTien > 0)
            {
                model.GhiCo = model.DonGia;
            }
            else
            {
                model.GhiNo = model.DonGia;
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
            else
            {
                if (!string.IsNullOrEmpty(model.BenDauTuSoTaiKhoan))
                {
                    ToChucTaiKhoan ToChucTaiKhoan = _ToChucTaiKhoanRepository.GetByName(model.BenDauTuSoTaiKhoan);
                    if (ToChucTaiKhoan == null)
                    {
                        ToChucTaiKhoan = new ToChucTaiKhoan();
                        ToChucTaiKhoan.Display = model.BenDauTuSoTaiKhoan;
                        ToChucTaiKhoan.Description = model.BenDauTuNganHang;
                        _ToChucTaiKhoanRepository.Add(ToChucTaiKhoan);
                    }
                    model.BenDauTuTaiKhoanID = ToChucTaiKhoan.ID;
                }
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
            else
            {
                if (!string.IsNullOrEmpty(model.BenThucHienSoTaiKhoan))
                {
                    ToChucTaiKhoan ToChucTaiKhoan = _ToChucTaiKhoanRepository.GetByName(model.BenThucHienSoTaiKhoan);
                    if (ToChucTaiKhoan == null)
                    {
                        ToChucTaiKhoan = new ToChucTaiKhoan();
                        ToChucTaiKhoan.Display = model.BenThucHienSoTaiKhoan;
                        ToChucTaiKhoan.Description = model.BenThucHienNganHang;
                        _ToChucTaiKhoanRepository.Add(ToChucTaiKhoan);
                    }
                    model.BenThucHienTaiKhoanID = ToChucTaiKhoan.ID;
                }
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
        public override async Task<DuAnThuChi> SaveAsync(DuAnThuChi model)
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
        public override async Task<int> RemoveAsync(long ID)
        {
            int result = GlobalHelper.InitializationNumber;
            DuAnThuChi model = await _DuAnThuChiRepository.GetByIDAsync(ID);
            result = await _DuAnThuChiRepository.RemoveAsync(ID);
            if (result > 0)
            {
                await Sync(model);
            }
            return result;
        }
        private async Task<int> Sync(DuAnThuChi model)
        {
            int result = GlobalHelper.InitializationNumber;
            if (model != null)
            {
                if (model.ID > 0)
                {
                    string ResultSync = await _DuAnRepository.SyncSQLByIDAsync(model.ParentID.Value);
                }
            }
            return result;
        }
    }
}

