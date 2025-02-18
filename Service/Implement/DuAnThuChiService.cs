namespace Service.Implement
{
    public class DuAnThuChiService : BaseService<DuAnThuChi, IDuAnThuChiRepository>
    , IDuAnThuChiService
    {
        private readonly IDuAnThuChiRepository _DuAnThuChiRepository;

        private readonly IDuAnTapTinDinhKemService _DuAnTapTinDinhKemService;

        private readonly IDuAnRepository _DuAnRepository;

        private readonly IDuAnQuyetDinhRepository _DuAnQuyetDinhRepository;

        private readonly IToChucRepository _ToChucRepository;

        private readonly IToChucTaiKhoanRepository _ToChucTaiKhoanRepository;

        private readonly IThanhVienRepository _ThanhVienRepository;

        private readonly IDanhMucTinhTrangRepository _DanhMucTinhTrangRepository;

        private readonly IDanhMucBieuMauRepository _DanhMucBieuMauRepository;

        private readonly IDanhMucHinhThucThanhToanRepository _DanhMucHinhThucThanhToanRepository;

        public DuAnThuChiService(IDuAnThuChiRepository DuAnThuChiRepository

            , IDuAnTapTinDinhKemService DuAnTapTinDinhKemService

            , IDuAnRepository DuAnRepository

            , IDuAnQuyetDinhRepository DuAnQuyetDinhRepository

            , IToChucRepository ToChucRepository

            , IToChucTaiKhoanRepository ToChucTaiKhoanRepository

            , IThanhVienRepository ThanhVienRepository

            , IDanhMucTinhTrangRepository DanhMucTinhTrangRepository

            , IDanhMucBieuMauRepository DanhMucBieuMauRepository

            , IDanhMucHinhThucThanhToanRepository DanhMucHinhThucThanhToanRepository

            ) : base(DuAnThuChiRepository)
        {
            _DuAnThuChiRepository = DuAnThuChiRepository;

            _DuAnTapTinDinhKemService = DuAnTapTinDinhKemService;

            _DuAnRepository = DuAnRepository;

            _DuAnQuyetDinhRepository = DuAnQuyetDinhRepository;

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

            if (model.TypeName == null)
            {
                model.TypeName = GlobalHelper.InitializationGUICode;
            }

            if (model.NgayGhiNhan == null)
            {
                model.NgayGhiNhan = GlobalHelper.InitializationDateTime;
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
            if (model.DuAnThuChiID > 0)
            {
                DuAnThuChi DuAnThuChi = _DuAnThuChiRepository.GetByID(model.DuAnThuChiID.Value);
                model.DuAnThuChiName = DuAnThuChi.Name;
                model.DuAnThuChiSoButToan = DuAnThuChi.SoButToan;
                if (model.HeSo == DuAnThuChi.HeSo)
                {
                    model.GhiCo = 0;
                    model.GhiNo = 0;
                }
                else
                {
                    if (model.ThanhTien > 0)
                    {
                        model.GhiCo = model.DonGia;
                    }
                    else
                    {
                        model.GhiNo = model.DonGia;
                    }
                }
            }
            else
            {
                if (model.ThanhTien > 0)
                {
                    model.GhiCo = model.DonGia;
                }
                else
                {
                    model.GhiNo = model.DonGia;
                }
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
            if (model.DuAnQuyetDinhID > 0)
            {
                DuAnQuyetDinh DuAnQuyetDinh = _DuAnQuyetDinhRepository.GetByID(model.DuAnQuyetDinhID.Value);
                model.DuAnQuyetDinhSoQuyetDinh = DuAnQuyetDinh.SoQuyetDinh;
            }
            else
            {
            }
        }
        public override async Task<DuAnThuChi> SaveAsync(DuAnThuChi model)
        {
            int result = GlobalHelper.InitializationNumber;
            if (model.ID > 0)
            {
                DuAnThuChi modelExist = await GetByIDAsync(model.ID);
                if (modelExist.Active == true)
                {
                }
                else
                {
                    result = await UpdateAsync(model);
                }
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
                    List<DuAnTapTinDinhKem> ListDuAnTapTinDinhKem = await _DuAnTapTinDinhKemService.GetByTypeNameToListAsync(model.TypeName);
                    for (int i = 0; i < ListDuAnTapTinDinhKem.Count; i++)
                    {
                        DuAnTapTinDinhKem DuAnTapTinDinhKemItem = ListDuAnTapTinDinhKem[i];
                        DuAnTapTinDinhKemItem.DuAnThuChiID = model.ID;
                        DuAnTapTinDinhKemItem.ParentID = model.ParentID;
                        DuAnTapTinDinhKemItem.ParentName = model.ParentName;
                        await _DuAnTapTinDinhKemService.SaveAsync(DuAnTapTinDinhKemItem);
                    }

                    string ResultSync = await _DuAnRepository.SyncSQLByIDAsync(model.ParentID.Value);

                    if (model.DanhMucBieuMauID > 0)
                    {
                        DanhMucBieuMau DanhMucBieuMau = await _DanhMucBieuMauRepository.GetByIDAsync(model.DanhMucBieuMauID.Value);
                        if (DanhMucBieuMau.IsTamUng == true)
                        {
                            await Sync001(model);
                        }
                    }

                    if (model.DuAnThuChiID > 0)
                    {
                        await Sync001(model);
                    }
                }
            }
            return result;
        }
        private async Task<int> Sync001(DuAnThuChi model)
        {
            int result = GlobalHelper.InitializationNumber;
            List<DanhMucBieuMau> ListDanhMucBieuMau = await _DanhMucBieuMauRepository.GetByCondition(item => item.IsTamUng == true).ToListAsync();
            if (ListDanhMucBieuMau == null)
            {
                ListDanhMucBieuMau = new List<DanhMucBieuMau>();
            }
            if (ListDanhMucBieuMau.Count > 0)
            {
                List<long> ListDanhMucBieuMauID = ListDanhMucBieuMau.Select(item => item.ID).ToList();

                if (model.DuAnQuyetDinhID > 0)
                {
                    DuAnQuyetDinh DuAnQuyetDinh = await _DuAnQuyetDinhRepository.GetByIDAsync(model.DuAnQuyetDinhID.Value);
                    if (DuAnQuyetDinh.ID > 0)
                    {
                        List<DuAnThuChi> ListDuAnThuChiDuAnQuyetDinh = await GetByCondition(item => item.DuAnQuyetDinhID == model.DuAnQuyetDinhID && ListDanhMucBieuMauID.Contains(item.DanhMucBieuMauID.Value)).ToListAsync();
                        if (ListDuAnThuChiDuAnQuyetDinh == null)
                        {
                            ListDuAnThuChiDuAnQuyetDinh = new List<DuAnThuChi>();
                        }
                        if (ListDuAnThuChiDuAnQuyetDinh.Count > 0)
                        {
                            DuAnQuyetDinh.TamUngGhiCo = GlobalHelper.InitializationNumber;
                            DuAnQuyetDinh.TamUngGhiNo = GlobalHelper.InitializationNumber;
                            DuAnQuyetDinh.TamUngConLai = GlobalHelper.InitializationNumber;
                            foreach (DuAnThuChi DuAnThuChi in ListDuAnThuChiDuAnQuyetDinh)
                            {
                                try
                                {
                                    DuAnQuyetDinh.TamUngGhiCo = DuAnQuyetDinh.TamUngGhiCo + DuAnThuChi.GhiNo.Value;
                                }
                                catch (Exception ex)
                                {
                                    string mes = ex.Message;
                                }
                            }
                            List<long> ListDuAnThuChiDuAnQuyetDinhID = ListDuAnThuChiDuAnQuyetDinh.Select(item => item.ID).ToList();
                            List<DuAnThuChi> ListDuAnThuChiDuAnQuyetDinhSub = await GetByCondition(item => ListDuAnThuChiDuAnQuyetDinhID.Contains(item.DuAnThuChiID.Value)).ToListAsync();
                            foreach (DuAnThuChi DuAnThuChi in ListDuAnThuChiDuAnQuyetDinhSub)
                            {
                                try
                                {
                                    DuAnQuyetDinh.TamUngGhiNo = DuAnQuyetDinh.TamUngGhiNo + DuAnThuChi.DonGia.Value;
                                }
                                catch (Exception ex)
                                {
                                    string mes = ex.Message;
                                }
                            }
                            DuAnQuyetDinh.TamUngConLai = DuAnQuyetDinh.TamUngGhiCo - DuAnQuyetDinh.TamUngGhiNo;
                            await _DuAnQuyetDinhRepository.UpdateAsync(DuAnQuyetDinh);
                        }
                    }
                }

                if (model.ParentID > 0)
                {
                    DuAn DuAn = await _DuAnRepository.GetByIDAsync(model.ParentID.Value);
                    if (DuAn.ID > 0)
                    {
                        List<DuAnThuChi> ListDuAnThuChiDuAn = await GetByCondition(item => item.ParentID == model.ParentID && ListDanhMucBieuMauID.Contains(item.DanhMucBieuMauID.Value)).ToListAsync();
                        if (ListDuAnThuChiDuAn == null)
                        {
                            ListDuAnThuChiDuAn = new List<DuAnThuChi>();
                        }
                        if (ListDuAnThuChiDuAn.Count > 0)
                        {
                            DuAn.TamUngGhiCo = GlobalHelper.InitializationNumber;
                            DuAn.TamUngGhiNo = GlobalHelper.InitializationNumber;
                            DuAn.TamUngConLai = GlobalHelper.InitializationNumber;
                            foreach (DuAnThuChi DuAnThuChi in ListDuAnThuChiDuAn)
                            {
                                try
                                {
                                    DuAn.TamUngGhiCo = DuAn.TamUngGhiCo + DuAnThuChi.GhiNo.Value;
                                }
                                catch (Exception ex)
                                {
                                    string mes = ex.Message;
                                }
                            }
                            List<long> ListDuAnThuChiDuAnID = ListDuAnThuChiDuAn.Select(item => item.ID).ToList();
                            List<DuAnThuChi> ListDuAnThuChiDuAnSub = await GetByCondition(item => ListDuAnThuChiDuAnID.Contains(item.DuAnThuChiID.Value)).ToListAsync();
                            foreach (DuAnThuChi DuAnThuChi in ListDuAnThuChiDuAnSub)
                            {
                                try
                                {
                                    DuAn.TamUngGhiNo = DuAn.TamUngGhiNo + DuAnThuChi.DonGia.Value;
                                }
                                catch (Exception ex)
                                {
                                    string mes = ex.Message;
                                }
                            }
                            DuAn.TamUngConLai = DuAn.TamUngGhiCo - DuAn.TamUngGhiNo;
                            await _DuAnRepository.UpdateAsync(DuAn);
                        }
                    }
                }
            }
            return result;
        }
        public virtual async Task<List<DuAnThuChi>> GetSQLByCodeToListAsync(string Code)
        {
            List<DuAnThuChi> result = new List<DuAnThuChi>();
            if (!string.IsNullOrEmpty(Code))
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@Code",Code),
                };
                result = await GetByStoredProcedureToListAsync("sp_DuAnThuChiSelectItemsByCode", parameters);
            }
            return result;
        }
        public virtual async Task<List<DuAnThuChi>> GetBySoQuyetDinhToListAsync(string SoQuyetDinh)
        {
            List<DuAnThuChi> result = new List<DuAnThuChi>();
            try
            {
                if (!string.IsNullOrEmpty(SoQuyetDinh))
                {
                    result = await GetByCondition(item => item.DuAnQuyetDinhSoQuyetDinh == SoQuyetDinh).ToListAsync();
                }
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        public virtual async Task<List<DuAnThuChi>> GetByDuAnQuyetDinhIDToListAsync(long DuAnQuyetDinhID)
        {
            List<DuAnThuChi> result = new List<DuAnThuChi>();
            try
            {
                if (DuAnQuyetDinhID > 0)
                {
                    result = await GetByCondition(item => item.DuAnQuyetDinhID == DuAnQuyetDinhID).ToListAsync();
                }
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        public virtual async Task<List<DuAnThuChi>> GetSQLByThanhVienIDToListAsync(long ThanhVienID)
        {
            List<DuAnThuChi> result = new List<DuAnThuChi>();
            try
            {
                SqlParameter[] parameters =
                {
                        new SqlParameter("@ThanhVienID",ThanhVienID),
                };
                result = await GetByStoredProcedureToListAsync("sp_DuAnThuChiSelectItemsByThanhVienID", parameters);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
    }
}

