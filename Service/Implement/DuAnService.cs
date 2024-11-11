namespace Service.Implement
{
    public class DuAnService : BaseService<DuAn, IDuAnRepository>
    , IDuAnService
    {
        private readonly IDuAnRepository _DuAnRepository;

        private readonly IDuAnTapTinDinhKemService _DuAnTapTinDinhKemService;

        private readonly IDuAnThuChiService _DuAnThuChiService;

        private readonly IDuAnQuyetDinhService _DuAnQuyetDinhService;

        private readonly IDuAnQuyetToanLuyKeService _DuAnQuyetToanLuyKeService;

        private readonly IToChucRepository _ToChucRepository;

        private readonly IToChucTaiKhoanRepository _ToChucTaiKhoanRepository;

        private readonly IThanhVienService _ThanhVienService;

        private readonly IDanhMucTinhTrangRepository _DanhMucTinhTrangRepository;

        private readonly IDanhMucBenhVienRepository _DanhMucBenhVienRepository;

        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DuAnService(IDuAnRepository DuAnRepository

            , IDuAnTapTinDinhKemService DuAnTapTinDinhKemService

            , IDuAnThuChiService DuAnThuChiService

            , IDuAnQuyetDinhService DuAnQuyetDinhService

            , IDuAnQuyetToanLuyKeService DuAnQuyetToanLuyKeService

            , IToChucRepository ToChucRepository

            , IToChucTaiKhoanRepository ToChucTaiKhoanRepository

            , IThanhVienService ThanhVienService

            , IDanhMucTinhTrangRepository DanhMucTinhTrangRepository

            , IDanhMucBenhVienRepository DanhMucBenhVienRepository

            , IWebHostEnvironment WebHostEnvironment

            ) : base(DuAnRepository)
        {
            _DuAnRepository = DuAnRepository;

            _DuAnTapTinDinhKemService = DuAnTapTinDinhKemService;

            _DuAnThuChiService = DuAnThuChiService;

            _DuAnQuyetDinhService = DuAnQuyetDinhService;

            _DuAnQuyetToanLuyKeService = DuAnQuyetToanLuyKeService;

            _ToChucRepository = ToChucRepository;

            _ToChucTaiKhoanRepository = ToChucTaiKhoanRepository;

            _ThanhVienService = ThanhVienService;

            _DanhMucTinhTrangRepository = DanhMucTinhTrangRepository;

            _DanhMucBenhVienRepository = DanhMucBenhVienRepository;

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

            string folderPath = Path.Combine(_WebHostEnvironment.WebRootPath, model.GetType().Name);
            bool isFolderExists = System.IO.Directory.Exists(folderPath);
            if (!isFolderExists)
            {
                System.IO.Directory.CreateDirectory(folderPath);
            }

            model.FileName = GlobalHelper.APISite + "/" + model.GetType().Name + "/" + model.Code + ".html";

            model.FileNameQRCode = GlobalHelper.APISite + "/" + model.GetType().Name + "/" + model.Code + ".png";

            QRCodeHelper.CreateQRCodeURL(model.Code, model.FileName, folderPath);


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
                ThanhVien ThanhVien = _ThanhVienService.GetByID(model.NguoiDauTuID.Value);
                model.NguoiDauTuName = ThanhVien.Name;
                model.NguoiDauTuChucDanh = ThanhVien.DanhMucChucDanhName;
            }
            else
            {
                if (!string.IsNullOrEmpty(model.NguoiDauTuName))
                {
                    ThanhVien ThanhVien = _ThanhVienService.GetByName(model.NguoiDauTuName);
                    if (ThanhVien == null)
                    {
                        ThanhVien = new ThanhVien();
                        ThanhVien.Name = model.NguoiDauTuName;
                        ThanhVien.DanhMucChucDanhName = model.NguoiDauTuChucDanh;
                        _ThanhVienService.Save(ThanhVien);
                    }
                    model.NguoiDauTuID = ThanhVien.ID;
                }
            }

            if (model.NguoiThucHienID > 0)
            {
                ThanhVien ThanhVien = _ThanhVienService.GetByID(model.NguoiThucHienID.Value);
                model.NguoiThucHienName = ThanhVien.Name;
                model.NguoiThucHienChucDanh = ThanhVien.DanhMucChucDanhName;
            }
            else
            {
                if (!string.IsNullOrEmpty(model.NguoiThucHienName))
                {
                    ThanhVien ThanhVien = _ThanhVienService.GetByName(model.NguoiThucHienName);
                    if (ThanhVien == null)
                    {
                        ThanhVien = new ThanhVien();
                        ThanhVien.Name = model.NguoiThucHienName;
                        ThanhVien.DanhMucChucDanhName = model.NguoiThucHienChucDanh;
                        _ThanhVienService.Save(ThanhVien);
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

                    List<DuAnTapTinDinhKem> ListDuAnTapTinDinhKem = await _DuAnTapTinDinhKemService.GetByCodeToListAsync(model.Code);
                    for (int i = 0; i < ListDuAnTapTinDinhKem.Count; i++)
                    {
                        DuAnTapTinDinhKem DuAnTapTinDinhKemItem = ListDuAnTapTinDinhKem[i];
                        DuAnTapTinDinhKemItem.DuAnID = model.ID;
                        DuAnTapTinDinhKemItem.ParentID = model.ID;
                        DuAnTapTinDinhKemItem.ParentName = model.Name;
                        await _DuAnTapTinDinhKemService.SaveAsync(DuAnTapTinDinhKemItem);
                    }

                    List<DuAnThuChi> ListDuAnThuChi = await _DuAnThuChiService.GetByCodeToListAsync(model.Code);
                    for (int i = 0; i < ListDuAnThuChi.Count; i++)
                    {
                        DuAnThuChi DuAnThuChiItem = ListDuAnThuChi[i];
                        DuAnThuChiItem.ParentID = model.ID;
                        DuAnThuChiItem.ParentName = model.Name;
                        await _DuAnThuChiService.SaveAsync(DuAnThuChiItem);
                    }

                    List<DuAnQuyetDinh> ListDuAnQuyetDinh = await _DuAnQuyetDinhService.GetByCodeToListAsync(model.Code);
                    for (int i = 0; i < ListDuAnQuyetDinh.Count; i++)
                    {
                        DuAnQuyetDinh DuAnQuyetDinhItem = ListDuAnQuyetDinh[i];
                        DuAnQuyetDinhItem.ParentID = model.ID;
                        DuAnQuyetDinhItem.ParentName = model.Name;
                        await _DuAnQuyetDinhService.SaveAsync(DuAnQuyetDinhItem);
                    }

                    string ResultSync = await _DuAnRepository.SyncSQLByIDAsync(model.ID);
                    model = await GetByIDAsync(model.ID);
                }
            }
            return result;
        }
        public virtual async Task<DuAn> CreateHTMLByIDAsync(long ID, long ThanhVienID)
        {
            DuAn result = new DuAn();
            try
            {
                DanhMucBenhVien DanhMucBenhVien = await _DanhMucBenhVienRepository.GetByIDAsync(GlobalHelper.DanhMucBenhVienID);
                ThanhVien ThanhVien = await _ThanhVienService.GetByIDAsync(ThanhVienID);
                result = await GetByIDAsync(ID);
                List<DuAnTapTinDinhKem> ListDuAnTapTinDinhKem = await _DuAnTapTinDinhKemService.GetByCodeToListAsync(result.Code);
                List<DuAnThuChi> ListDuAnThuChi = await _DuAnThuChiService.GetSQLByCodeToListAsync(result.Code);
                List<DuAnQuyetDinh> ListDuAnQuyetDinh = await _DuAnQuyetDinhService.GetByCodeToListAsync(result.Code);
                ListDuAnQuyetDinh = ListDuAnQuyetDinh.OrderBy(x => x.NgayKy).ToList();
                List<DuAnQuyetToanLuyKe> ListDuAnQuyetToanLuyKe = await _DuAnQuyetToanLuyKeService.GetByParentIDToListAsync(result.ID);
                string contentHTML = GlobalHelper.InitializationString;
                string physicalPathOpen = Path.Combine(_WebHostEnvironment.WebRootPath, GlobalHelper.Download, result.GetType().Name + ".html");
                using (FileStream fs = new FileStream(physicalPathOpen, FileMode.Open))
                {
                    using (StreamReader r = new StreamReader(fs, Encoding.UTF8))
                    {
                        contentHTML = r.ReadToEnd();
                    }
                }

                contentHTML = contentHTML.Replace("[DanhMucBenhVienName]", DanhMucBenhVien.Name);
                contentHTML = contentHTML.Replace("[DanhMucBenhVienDienThoai]", DanhMucBenhVien.DienThoai);
                contentHTML = contentHTML.Replace("[DanhMucBenhVienDienThoai001]", DanhMucBenhVien.DienThoai001);
                contentHTML = contentHTML.Replace("[DanhMucBenhVienWebsite]", DanhMucBenhVien.Website);
                contentHTML = contentHTML.Replace("[DanhMucBenhVienWebsite001]", DanhMucBenhVien.Website001);
                contentHTML = contentHTML.Replace("[DanhMucBenhVienDiaChi]", DanhMucBenhVien.DiaChi);
                contentHTML = contentHTML.Replace("[DanhMucBenhVienDiaChi001]", DanhMucBenhVien.DiaChi001);

                contentHTML = contentHTML.Replace("[Day]", GlobalHelper.InitializationDateTime.ToString("dd/MM/yyyy hh:mm:ss"));

                contentHTML = contentHTML.Replace("[ThanhVienName]", ThanhVien.Name);

                contentHTML = contentHTML.Replace("[ID]", result.ID.ToString());
                contentHTML = contentHTML.Replace("[Name]", result.Name);
                contentHTML = contentHTML.Replace("[FileNameQRCode]", result.FileNameQRCode);
                try
                {
                    contentHTML = contentHTML.Replace("[NgayBatDau]", result.NgayBatDau.Value.ToString("dd/MM/yyyy"));
                }
                catch (Exception ex)
                {
                    contentHTML = contentHTML.Replace("[NgayBatDau]", "");
                }
                try
                {
                    contentHTML = contentHTML.Replace("[NgayKetThuc]", result.NgayKetThuc.Value.ToString("dd/MM/yyyy"));
                }
                catch (Exception ex)
                {
                    contentHTML = contentHTML.Replace("[NgayKetThuc]", "");
                }
                try
                {
                    contentHTML = contentHTML.Replace("[NgayKy]", result.NgayKy.Value.ToString("dd/MM/yyyy"));
                }
                catch (Exception ex)
                {
                    contentHTML = contentHTML.Replace("[NgayKy]", "");
                }
                contentHTML = contentHTML.Replace("[SoHoSo]", result.SoHoSo);
                contentHTML = contentHTML.Replace("[SoQuyetDinh]", result.SoQuyetDinh);
                contentHTML = contentHTML.Replace("[BenDauTuName]", result.BenDauTuName);
                contentHTML = contentHTML.Replace("[NguoiDauTuName]", result.NguoiDauTuName);
                contentHTML = contentHTML.Replace("[NguoiDauTuChucDanh]", result.NguoiDauTuChucDanh);
                contentHTML = contentHTML.Replace("[BenThucHienName]", result.BenThucHienName);
                contentHTML = contentHTML.Replace("[NguoiThucHienName]", result.NguoiThucHienName);
                contentHTML = contentHTML.Replace("[NguoiThucHienChucDanh]", result.NguoiThucHienChucDanh);
                try
                {
                    contentHTML = contentHTML.Replace("[ThoiHan]", result.ThoiHan.Value.ToString("N0"));
                }
                catch (Exception ex)
                {
                    contentHTML = contentHTML.Replace("[ThoiHan]", "");
                }
                try
                {
                    contentHTML = contentHTML.Replace("[MucDauTu]", result.MucDauTu.Value.ToString("N0"));
                }
                catch (Exception ex)
                {
                    contentHTML = contentHTML.Replace("[MucDauTu]", "");
                }
                try
                {
                    contentHTML = contentHTML.Replace("[GhiCo]", result.GhiCo.Value.ToString("N0"));
                }
                catch (Exception ex)
                {
                    contentHTML = contentHTML.Replace("[GhiCo]", "");
                }
                try
                {
                    contentHTML = contentHTML.Replace("[GhiNo]", result.GhiNo.Value.ToString("N0"));
                }
                catch (Exception ex)
                {
                    contentHTML = contentHTML.Replace("[GhiNo]", "");
                }
                try
                {
                    contentHTML = contentHTML.Replace("[ConLai]", result.ConLai.Value.ToString("N0"));
                }
                catch (Exception ex)
                {
                    contentHTML = contentHTML.Replace("[ConLai]", "");
                }

                StringBuilder DuAnTapTinDinhKemDetail = new StringBuilder();
                int stt = 0;
                foreach (DuAnTapTinDinhKem item in ListDuAnTapTinDinhKem)
                {
                    stt = stt + 1;
                    DuAnTapTinDinhKemDetail.AppendLine(@"<tr>");
                    DuAnTapTinDinhKemDetail.AppendLine(@"<td style='text-align: center;'>" + stt + "</td>");
                    DuAnTapTinDinhKemDetail.AppendLine(@"<td><a href='" + item.FileName + "' title='" + item.FileName + "' target='_blank'>" + item.Name + "</a></td>");
                    DuAnTapTinDinhKemDetail.AppendLine(@"<td><a href='" + item.Display + "' title='" + item.Display + "' target='_blank'>" + item.Display + "</a></td>");
                    DuAnTapTinDinhKemDetail.AppendLine(@"</tr>");
                }
                contentHTML = contentHTML.Replace("[DuAnTapTinDinhKemDetail]", DuAnTapTinDinhKemDetail.ToString());

                StringBuilder DuAnThuChiDetail = new StringBuilder();
                stt = 0;
                foreach (DuAnThuChi item in ListDuAnThuChi)
                {
                    stt = stt + 1;
                    DuAnThuChiDetail.AppendLine(@"<tr>");
                    DuAnThuChiDetail.AppendLine(@"<td style='text-align: center;'>" + stt + "</td>");
                    try
                    {
                        DuAnThuChiDetail.AppendLine(@"<td style='text-align: right;'>" + item.NgayGhiNhan.Value.ToString("dd/MM/yyyy") + "</td>");
                    }
                    catch (Exception ex)
                    {
                        DuAnThuChiDetail.AppendLine(@"<td style='text-align: right;'></td>");
                    }
                    DuAnThuChiDetail.AppendLine(@"<td>" + item.SoChungTu + "</td>");
                    DuAnThuChiDetail.AppendLine(@"<td>" + item.SoButToan + "</td>");
                    DuAnThuChiDetail.AppendLine(@"<td>" + item.DanhMucHinhThucThanhToanName + "</td>");
                    DuAnThuChiDetail.AppendLine(@"<td>" + item.Name + "</td>");
                    DuAnThuChiDetail.AppendLine(@"<td>" + item.DuAnQuyetDinhSoQuyetDinh + "</td>");
                    try
                    {
                        DuAnThuChiDetail.AppendLine(@"<td style='text-align: right; color: green;'><b>" + item.GhiCo.Value.ToString("N0") + "</b></td>");
                    }
                    catch (Exception ex)
                    {
                        DuAnThuChiDetail.AppendLine(@"<td style='text-align: right;'></td>");
                    }
                    try
                    {
                        DuAnThuChiDetail.AppendLine(@"<td style='text-align: right; color: red;'><b>" + item.GhiNo.Value.ToString("N0") + "</b></td>");
                    }
                    catch (Exception ex)
                    {
                        DuAnThuChiDetail.AppendLine(@"<td style='text-align: right;'></td>");
                    }
                    try
                    {
                        if (item.ConLai >= 0)
                        {
                            DuAnThuChiDetail.AppendLine(@"<td style='text-align: right; color: green;'><b>" + item.ConLai.Value.ToString("N0") + "</b></td>");
                        }
                        else
                        {
                            DuAnThuChiDetail.AppendLine(@"<td style='text-align: right; color: red;'><b>" + item.ConLai.Value.ToString("N0") + "</b></td>");
                        }
                    }
                    catch (Exception ex)
                    {
                        DuAnThuChiDetail.AppendLine(@"<td style='text-align: right;'></td>");
                    }
                    try
                    {
                        if (item.Active == true)
                        {
                            DuAnThuChiDetail.AppendLine(@"<td style='text-align: center;'><b>X</b></td>");
                        }
                        else
                        {
                            DuAnThuChiDetail.AppendLine(@"<td style='text-align: center;'></td>");
                        }
                    }
                    catch (Exception ex)
                    {
                        DuAnThuChiDetail.AppendLine(@"<td style='text-align: center;'></td>");
                    }
                    DuAnThuChiDetail.AppendLine(@"</tr>");
                }
                contentHTML = contentHTML.Replace("[DuAnThuChiDetail]", DuAnThuChiDetail.ToString());

                StringBuilder DuAnQuyetDinhDetail = new StringBuilder();
                stt = 0;
                foreach (DuAnQuyetDinh item in ListDuAnQuyetDinh)
                {
                    stt = stt + 1;
                    DuAnQuyetDinhDetail.AppendLine(@"<tr>");
                    DuAnQuyetDinhDetail.AppendLine(@"<td style='text-align: center;'>" + stt + "</td>");
                    try
                    {
                        DuAnQuyetDinhDetail.AppendLine(@"<td style='text-align: right;'>" + item.NgayKy.Value.ToString("dd/MM/yyyy") + "</td>");
                    }
                    catch (Exception ex)
                    {
                        DuAnQuyetDinhDetail.AppendLine(@"<td style='text-align: right;'></td>");
                    }
                    try
                    {
                        DuAnQuyetDinhDetail.AppendLine(@"<td style='text-align: right;'>" + item.NgayHieuLuc.Value.ToString("dd/MM/yyyy") + "</td>");
                    }
                    catch (Exception ex)
                    {
                        DuAnQuyetDinhDetail.AppendLine(@"<td style='text-align: right;'></td>");
                    }
                    DuAnQuyetDinhDetail.AppendLine(@"<td>" + item.Name + "</td>");
                    DuAnQuyetDinhDetail.AppendLine(@"<td>" + item.BenDauTuName + "</td>");
                    DuAnQuyetDinhDetail.AppendLine(@"<td>" + item.SoQuyetDinh + "</td>");
                    try
                    {
                        DuAnQuyetDinhDetail.AppendLine(@"<td style='text-align: right;'><b>" + item.MucDauTu.Value.ToString("N0") + "</b></td>");
                    }
                    catch (Exception ex)
                    {
                        DuAnQuyetDinhDetail.AppendLine(@"<td style='text-align: right;'></td>");
                    }
                    try
                    {
                        DuAnQuyetDinhDetail.AppendLine(@"<td style='text-align: right; color: green;'><b>" + item.GhiCo.Value.ToString("N0") + "</b></td>");
                    }
                    catch (Exception ex)
                    {
                        DuAnQuyetDinhDetail.AppendLine(@"<td style='text-align: right;'></td>");
                    }
                    try
                    {
                        DuAnQuyetDinhDetail.AppendLine(@"<td style='text-align: right; color: red;'><b>" + item.GhiNo.Value.ToString("N0") + "</b></td>");
                    }
                    catch (Exception ex)
                    {
                        DuAnQuyetDinhDetail.AppendLine(@"<td style='text-align: right;'></td>");
                    }
                    try
                    {
                        if (item.ConLai >= 0)
                        {
                            DuAnQuyetDinhDetail.AppendLine(@"<td style='text-align: right; color: green;'><b>" + item.ConLai.Value.ToString("N0") + "</b></td>");
                        }
                        else
                        {
                            DuAnQuyetDinhDetail.AppendLine(@"<td style='text-align: right; color: red;'><b>" + item.ConLai.Value.ToString("N0") + "</b></td>");
                        }
                    }
                    catch (Exception ex)
                    {
                        DuAnQuyetDinhDetail.AppendLine(@"<td style='text-align: right;'></td>");
                    }

                    DuAnQuyetDinhDetail.AppendLine(@"</tr>");
                }
                contentHTML = contentHTML.Replace("[DuAnQuyetDinhDetail]", DuAnQuyetDinhDetail.ToString());

                StringBuilder DuAnQuyetToanLuyKeDetail = new StringBuilder();
                stt = 0;
                foreach (DuAnQuyetToanLuyKe item in ListDuAnQuyetToanLuyKe)
                {
                    if ((item.GhiCo > 0) || (item.GhiNo > 0))
                    {
                        stt = stt + 1;
                        DuAnQuyetToanLuyKeDetail.AppendLine(@"<tr>");
                        DuAnQuyetToanLuyKeDetail.AppendLine(@"<td style='text-align: center;'>" + stt + "</td>");
                        DuAnQuyetToanLuyKeDetail.AppendLine(@"<td>" + item.DuAnQuyetDinhSoQuyetDinh + "</td>");
                        try
                        {
                            DuAnQuyetToanLuyKeDetail.AppendLine(@"<td style='text-align: right;'><b>" + item.Nam + "</b></td>");
                        }
                        catch (Exception ex)
                        {
                            DuAnQuyetToanLuyKeDetail.AppendLine(@"<td style='text-align: right;'></td>");
                        }
                        try
                        {
                            DuAnQuyetToanLuyKeDetail.AppendLine(@"<td style='text-align: right;'><b>" + item.Thang + "</b></td>");
                        }
                        catch (Exception ex)
                        {
                            DuAnQuyetToanLuyKeDetail.AppendLine(@"<td style='text-align: right;'></td>");
                        }
                        try
                        {
                            if (item.DauKy >= 0)
                            {
                                DuAnQuyetToanLuyKeDetail.AppendLine(@"<td style='text-align: right; color: green;'><b>" + item.DauKy.Value.ToString("N0") + "</b></td>");
                            }
                            else
                            {
                                DuAnQuyetToanLuyKeDetail.AppendLine(@"<td style='text-align: right; color: red;'><b>" + item.DauKy.Value.ToString("N0") + "</b></td>");
                            }
                        }
                        catch (Exception ex)
                        {
                            DuAnQuyetToanLuyKeDetail.AppendLine(@"<td style='text-align: right;'></td>");
                        }
                        try
                        {
                            DuAnQuyetToanLuyKeDetail.AppendLine(@"<td style='text-align: right; color: green;'><b>" + item.GhiCo.Value.ToString("N0") + "</b></td>");
                        }
                        catch (Exception ex)
                        {
                            DuAnQuyetToanLuyKeDetail.AppendLine(@"<td style='text-align: right;'></td>");
                        }
                        try
                        {
                            DuAnQuyetToanLuyKeDetail.AppendLine(@"<td style='text-align: right; color: red;'><b>" + item.GhiNo.Value.ToString("N0") + "</b></td>");
                        }
                        catch (Exception ex)
                        {
                            DuAnQuyetToanLuyKeDetail.AppendLine(@"<td style='text-align: right;'></td>");
                        }
                        try
                        {
                            if (item.CuoiKy >= 0)
                            {
                                DuAnQuyetToanLuyKeDetail.AppendLine(@"<td style='text-align: right; color: green;'><b>" + item.CuoiKy.Value.ToString("N0") + "</b></td>");
                            }
                            else
                            {
                                DuAnQuyetToanLuyKeDetail.AppendLine(@"<td style='text-align: right; color: red;'><b>" + item.CuoiKy.Value.ToString("N0") + "</b></td>");
                            }
                        }
                        catch (Exception ex)
                        {
                            DuAnQuyetToanLuyKeDetail.AppendLine(@"<td style='text-align: right;'></td>");
                        }
                        try
                        {
                            if (item.Active == true)
                            {
                                DuAnQuyetToanLuyKeDetail.AppendLine(@"<td style='text-align: center;'><b>X</b></td>");
                            }
                            else
                            {
                                DuAnQuyetToanLuyKeDetail.AppendLine(@"<td style='text-align: center;'></td>");
                            }
                        }
                        catch (Exception ex)
                        {
                            DuAnQuyetToanLuyKeDetail.AppendLine(@"<td style='text-align: center;'></td>");
                        }
                        DuAnQuyetToanLuyKeDetail.AppendLine(@"</tr>");
                    }
                }
                contentHTML = contentHTML.Replace("[DuAnQuyetToanLuyKeDetail]", DuAnQuyetToanLuyKeDetail.ToString());


                string physicalPathCreate = Path.Combine(_WebHostEnvironment.WebRootPath, result.GetType().Name);
                bool isFolderExists = System.IO.Directory.Exists(physicalPathCreate);
                if (!isFolderExists)
                {
                    System.IO.Directory.CreateDirectory(physicalPathCreate);
                }
                string fileName = GlobalHelper.InitializationDateTimeCode + ".html";
                physicalPathCreate = Path.Combine(physicalPathCreate, fileName);
                using (FileStream fs = new FileStream(physicalPathCreate, FileMode.Create))
                {
                    using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                    {
                        w.WriteLine(contentHTML);
                    }
                }
                result.FileName = GlobalHelper.APISite + "/" + result.GetType().Name + "/" + fileName;
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        public virtual async Task<List<DuAn>> GetByBatDau_KetThucToListAsync(DateTime BatDau, DateTime KetThuc)
        {
            List<DuAn> result = new List<DuAn>();
            try
            {
                try
                {
                    BatDau = GlobalHelper.SetBatDau(BatDau);
                    KetThuc = GlobalHelper.SetKetThuc(KetThuc);
                }
                catch (Exception ex)
                {
                    string mes = ex.Message;
                    KetThuc = GlobalHelper.InitializationDateTime;
                    BatDau = new DateTime(KetThuc.Year, KetThuc.Month, 1, 0, 0, 0);
                }
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
        public virtual async Task<List<DuAn>> GetSQLByThanhVienIDAndBatDau_KetThuc_SearchStringToListAsync(long ThanhVienID, DateTime BatDau, DateTime KetThuc, string SearchString)
        {
            List<DuAn> result = new List<DuAn>();
            try
            {
                try
                {
                    BatDau = GlobalHelper.SetBatDau(BatDau);
                    KetThuc = GlobalHelper.SetKetThuc(KetThuc);
                }
                catch (Exception ex)
                {
                    string mes = ex.Message;
                    KetThuc = GlobalHelper.InitializationDateTime;
                    BatDau = new DateTime(KetThuc.Year, KetThuc.Month, 1, 0, 0, 0);
                }
                SqlParameter[] parameters =
                    {
                        new SqlParameter("@ThanhVienID",ThanhVienID),
                        new SqlParameter("@BatDau",BatDau),
                        new SqlParameter("@KetThuc",KetThuc),
                        new SqlParameter("@SearchString",SearchString),
                };
                result = await GetByStoredProcedureToListAsync("sp_DuAnSelectItemsByThanhVienIDAndBatDau_KetThuc_SearchString", parameters);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        public virtual async Task<List<DuAn>> GetSQLByThanhVienIDToListAsync(long ThanhVienID)
        {
            List<DuAn> result = new List<DuAn>();
            try
            {
                SqlParameter[] parameters =
                {
                        new SqlParameter("@ThanhVienID",ThanhVienID),
                };
                result = await GetByStoredProcedureToListAsync("sp_DuAnSelectItemsByThanhVienID", parameters);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
    }
}

