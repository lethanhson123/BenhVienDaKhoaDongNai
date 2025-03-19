namespace Service.Implement
{
    public class GoiSoService : BaseService<GoiSo, IGoiSoRepository>
    , IGoiSoService
    {
        private readonly IGoiSoRepository _GoiSoRepository;

        private readonly IDanhMucDichVuRepository _DanhMucDichVuRepository;

        private readonly IDanhMucQuayDichVuRepository _DanhMucQuayDichVuRepository;

        private readonly IGoiSoChiTietService _GoiSoChiTietService;

        private readonly IGoiSoChiTietPhongKhamService _GoiSoChiTietPhongKhamService;

        private readonly IGoiSoThamSoRepository _GoiSoThamSoRepository;

        private readonly IZaloTokenService _ZaloTokenService;

        private readonly ICLSYeuCauService _CLSYeuCauService;

        private readonly IWebHostEnvironment _WebHostEnvironment;
        public GoiSoService(IGoiSoRepository GoiSoRepository

            , IDanhMucDichVuRepository danhMucDichVuRepository

            , IDanhMucQuayDichVuRepository DanhMucQuayDichVuRepository

            , IGoiSoChiTietService GoiSoChiTietService

            , IGoiSoChiTietPhongKhamService GoiSoChiTietPhongKhamService

            , IGoiSoThamSoRepository GoiSoThamSoRepository

            , IZaloTokenService ZaloTokenService

            , ICLSYeuCauService ICLSYeuCauService

            , IWebHostEnvironment WebHostEnvironment

            ) : base(GoiSoRepository)
        {
            _GoiSoRepository = GoiSoRepository;

            _DanhMucDichVuRepository = danhMucDichVuRepository;

            _DanhMucQuayDichVuRepository = DanhMucQuayDichVuRepository;

            _GoiSoChiTietService = GoiSoChiTietService;

            _GoiSoChiTietPhongKhamService = GoiSoChiTietPhongKhamService;

            _GoiSoThamSoRepository = GoiSoThamSoRepository;

            _ZaloTokenService = ZaloTokenService;

            _CLSYeuCauService = ICLSYeuCauService;

            _WebHostEnvironment = WebHostEnvironment;
        }
        public override void Initialization(GoiSo model)
        {
            BaseInitialization(model);

            model.NgayGhiNhan = GlobalHelper.InitializationDateTime;

            if (model.DanhMucDichVuID == null)
            {
                model.DanhMucDichVuID = GlobalHelper.DanhMucDichVuID;
            }

            if (model.DanhMucDichVuID > 0)
            {
                DanhMucDichVu DanhMucDichVu = _DanhMucDichVuRepository.GetByID(model.DanhMucDichVuID.Value);
                model.DanhMucDichVuName = DanhMucDichVu.Name;
                model.Note = DanhMucDichVu.Note;
            }

            if (model.DanhMucQuayDichVuID > 0)
            {
                DanhMucQuayDichVu DanhMucQuayDichVu = _DanhMucQuayDichVuRepository.GetByID(model.DanhMucQuayDichVuID.Value);
                model.DanhMucQuayDichVuName = DanhMucQuayDichVu.Name;
                model.DanhMucQuayDichVuCode = DanhMucQuayDichVu.Code;
                model.DanhMucQuayDichVuDisplay = DanhMucQuayDichVu.Display;
                model.Note = DanhMucQuayDichVu.Note;
            }

            if (!string.IsNullOrEmpty(model.Code))
            {
                string folderPath = Path.Combine(_WebHostEnvironment.WebRootPath, model.GetType().Name);
                bool isFolderExists = System.IO.Directory.Exists(folderPath);
                if (!isFolderExists)
                {
                    System.IO.Directory.CreateDirectory(folderPath);
                }

                GlobalHelper.CreateBarcode128(folderPath, model.Code);
                model.TypeName = GlobalHelper.APISite + "/" + model.GetType().Name + "/" + model.Code + ".png";
            }

            if (model.TongCong > 0)
            {
                if (!string.IsNullOrEmpty(model.DanhMucQuayDichVuDisplay))
                {
                    model.TongCongString = model.TongCong.ToString();
                    if (model.TongCong < 10)
                    {
                        model.TongCongString = model.DanhMucQuayDichVuDisplay + "00" + model.TongCongString;
                    }
                    else
                    {
                        if (model.TongCong < 100)
                        {
                            model.TongCongString = model.DanhMucQuayDichVuDisplay + "0" + model.TongCongString;
                        }
                        else
                        {
                            if (model.TongCong < 1000)
                            {
                                model.TongCongString = model.DanhMucQuayDichVuDisplay + "" + model.TongCongString;
                            }
                        }
                    }
                }
                else
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
            }
            if (model.SoHienTai > 0)
            {
                if (!string.IsNullOrEmpty(model.DanhMucQuayDichVuDisplay))
                {
                    model.SoHienTaiString = model.SoHienTai.ToString();
                    if (model.SoHienTai < 10)
                    {
                        model.SoHienTaiString = model.DanhMucQuayDichVuDisplay + "00" + model.SoHienTaiString;
                    }
                    else
                    {
                        if (model.SoHienTai < 100)
                        {
                            model.SoHienTaiString = model.DanhMucQuayDichVuDisplay + "0" + model.SoHienTaiString;
                        }
                        else
                        {
                            if (model.SoHienTai < 1000)
                            {
                                model.SoHienTaiString = model.DanhMucQuayDichVuDisplay + "" + model.SoHienTaiString;
                            }
                        }
                    }
                }
                else
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
            model = await Sync(model);
            return model;
        }
        public virtual async Task<GoiSo> SaveAsync(GoiSo model, GoiSoChiTiet GoiSoChiTiet)
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
            await Sync(model, GoiSoChiTiet);
            return model;
        }
        public virtual async Task<GoiSo> Sync(GoiSo model)
        {
            if (model.ID > 0)
            {
                if (model.DanhMucDichVuID > 0)
                {
                    if (model.TongCong > 0)
                    {
                        GoiSoThamSo GoiSoThamSo = await _GoiSoThamSoRepository.GetByIDAsync(GlobalHelper.GoiSoThamSoID);
                        DanhMucDichVu DanhMucDichVu = await _DanhMucDichVuRepository.GetByIDAsync(model.DanhMucDichVuID.Value);
                        if (DanhMucDichVu.IsHangDoiPhanNhanh == true)
                        {
                            if (model.DanhMucQuayDichVuID > 0)
                            {
                                await SaveGoiSoChiTietAsync(model);
                            }
                            else
                            {
                                List<DanhMucQuayDichVu> ListDanhMucQuayDichVu = await _DanhMucQuayDichVuRepository.GetByCondition(item => item.DanhMucDichVuID == model.DanhMucDichVuID && item.Active == true && item.IsTiepNhan == true).OrderBy(item => item.SortOrder).ToListAsync();
                                if (ListDanhMucQuayDichVu == null)
                                {
                                    ListDanhMucQuayDichVu = new List<DanhMucQuayDichVu>();
                                }
                                if (ListDanhMucQuayDichVu.Count > 0)
                                {
                                    int SoDu = model.TongCong.Value % ListDanhMucQuayDichVu.Count;
                                    if (SoDu == 0)
                                    {
                                        SoDu = ListDanhMucQuayDichVu.Count;
                                    }
                                    int Index = SoDu - 1;
                                    if (Index < 0)
                                    {
                                        Index = 0;
                                    }
                                    if (Index >= ListDanhMucQuayDichVu.Count)
                                    {
                                        Index = ListDanhMucQuayDichVu.Count - 1;
                                    }
                                    DanhMucQuayDichVu DanhMucQuayDichVu = new DanhMucQuayDichVu();
                                    if (GoiSoThamSo.HTMLContent.Contains(model.NgayGhiNhan.Value.DayOfWeek.ToString()))
                                    {
                                        DanhMucQuayDichVu = ListDanhMucQuayDichVu[Index];
                                    }
                                    else
                                    {
                                        if (model.TongCong > GoiSoThamSo.KichThuocChu008 * 2)
                                        {
                                            DanhMucQuayDichVu = ListDanhMucQuayDichVu[Index];
                                        }
                                        else
                                        {
                                            if (model.TongCong % 2 == 0)
                                            {
                                                try
                                                {
                                                    DanhMucQuayDichVu = ListDanhMucQuayDichVu[0];
                                                }
                                                catch (Exception ex)
                                                {
                                                    string msg = ex.Message;
                                                    DanhMucQuayDichVu = ListDanhMucQuayDichVu[Index];
                                                }
                                            }
                                            else
                                            {
                                                try
                                                {
                                                    DanhMucQuayDichVu = ListDanhMucQuayDichVu[1];
                                                }
                                                catch (Exception ex)
                                                {
                                                    string msg = ex.Message;
                                                    DanhMucQuayDichVu = ListDanhMucQuayDichVu[Index];
                                                }
                                            }
                                        }
                                    }
                                    GoiSo GoiSo = await GetByCondition(item => item.DanhMucDichVuID == model.DanhMucDichVuID && item.DanhMucQuayDichVuID == DanhMucQuayDichVu.ID && item.NgayGhiNhan.Value.Year == model.NgayGhiNhan.Value.Year && item.NgayGhiNhan.Value.Month == model.NgayGhiNhan.Value.Month && item.NgayGhiNhan.Value.Day == model.NgayGhiNhan.Value.Day).AsNoTracking().FirstOrDefaultAsync();
                                    if (GoiSo == null)
                                    {
                                        GoiSo = new GoiSo();
                                        GoiSo.Code = model.Code;
                                        GoiSo.Display = model.Display;
                                        GoiSo.NgayGhiNhan = model.NgayGhiNhan;
                                        GoiSo.DanhMucDichVuID = model.DanhMucDichVuID;
                                        GoiSo.DanhMucQuayDichVuID = DanhMucQuayDichVu.ID;
                                        GoiSo.TongCong = 0;
                                        GoiSo.SoHienTai = 0;
                                    }
                                    GoiSo.TongCong = GoiSo.TongCong + 1;
                                    await SaveAsync(GoiSo);
                                    if (GoiSo.ID > 0)
                                    {
                                        model = GoiSo;
                                    }
                                }
                            }
                        }
                        else
                        {
                            await SaveGoiSoChiTietAsync(model);
                        }
                    }
                }
            }
            return model;
        }
        public virtual async Task<GoiSo> Sync(GoiSo model, GoiSoChiTiet GoiSoChiTiet)
        {
            if (model.ID > 0)
            {
                if (model.DanhMucDichVuID > 0)
                {
                    if (model.TongCong > 0)
                    {
                        GoiSoThamSo GoiSoThamSo = await _GoiSoThamSoRepository.GetByIDAsync(GlobalHelper.GoiSoThamSoID);
                        DanhMucDichVu DanhMucDichVu = await _DanhMucDichVuRepository.GetByIDAsync(model.DanhMucDichVuID.Value);
                        if (DanhMucDichVu.IsHangDoiPhanNhanh == true)
                        {
                            if (model.DanhMucQuayDichVuID > 0)
                            {
                                await SaveGoiSoChiTietAsync(model, GoiSoChiTiet);
                            }
                            else
                            {
                                List<DanhMucQuayDichVu> ListDanhMucQuayDichVu = await _DanhMucQuayDichVuRepository.GetByCondition(item => item.DanhMucDichVuID == model.DanhMucDichVuID && item.Active == true && item.IsTiepNhan == true).OrderBy(item => item.SortOrder).ToListAsync();
                                if (ListDanhMucQuayDichVu == null)
                                {
                                    ListDanhMucQuayDichVu = new List<DanhMucQuayDichVu>();
                                }
                                if (ListDanhMucQuayDichVu.Count > 0)
                                {
                                    int SoDu = model.TongCong.Value % ListDanhMucQuayDichVu.Count;
                                    if (SoDu == 0)
                                    {
                                        SoDu = ListDanhMucQuayDichVu.Count;
                                    }
                                    int Index = SoDu - 1;
                                    if (Index < 0)
                                    {
                                        Index = 0;
                                    }
                                    if (Index >= ListDanhMucQuayDichVu.Count)
                                    {
                                        Index = ListDanhMucQuayDichVu.Count - 1;
                                    }
                                    DanhMucQuayDichVu DanhMucQuayDichVu = new DanhMucQuayDichVu();
                                    if (GoiSoThamSo.HTMLContent.Contains(model.NgayGhiNhan.Value.DayOfWeek.ToString()))
                                    {
                                        DanhMucQuayDichVu = ListDanhMucQuayDichVu[Index];
                                    }
                                    else
                                    {
                                        if (model.TongCong > GoiSoThamSo.KichThuocChu008 * 2)
                                        {
                                            DanhMucQuayDichVu = ListDanhMucQuayDichVu[Index];
                                        }
                                        else
                                        {
                                            if (model.TongCong % 2 == 0)
                                            {
                                                try
                                                {
                                                    DanhMucQuayDichVu = ListDanhMucQuayDichVu[0];
                                                }
                                                catch (Exception ex)
                                                {
                                                    string msg = ex.Message;
                                                    DanhMucQuayDichVu = ListDanhMucQuayDichVu[Index];
                                                }
                                            }
                                            else
                                            {
                                                try
                                                {
                                                    DanhMucQuayDichVu = ListDanhMucQuayDichVu[1];
                                                }
                                                catch (Exception ex)
                                                {
                                                    string msg = ex.Message;
                                                    DanhMucQuayDichVu = ListDanhMucQuayDichVu[Index];
                                                }
                                            }
                                        }
                                    }
                                    GoiSo GoiSo = await GetByCondition(item => item.DanhMucDichVuID == model.DanhMucDichVuID && item.DanhMucQuayDichVuID == DanhMucQuayDichVu.ID && item.NgayGhiNhan.Value.Year == model.NgayGhiNhan.Value.Year && item.NgayGhiNhan.Value.Month == model.NgayGhiNhan.Value.Month && item.NgayGhiNhan.Value.Day == model.NgayGhiNhan.Value.Day).AsNoTracking().FirstOrDefaultAsync();
                                    if (GoiSo == null)
                                    {
                                        GoiSo = new GoiSo();
                                        GoiSo.Code = model.Code;
                                        GoiSo.Display = model.Display;
                                        GoiSo.NgayGhiNhan = model.NgayGhiNhan;
                                        GoiSo.DanhMucDichVuID = model.DanhMucDichVuID;
                                        GoiSo.DanhMucQuayDichVuID = DanhMucQuayDichVu.ID;
                                        GoiSo.TongCong = 0;
                                        GoiSo.SoHienTai = 0;
                                    }
                                    GoiSo.TongCong = GoiSo.TongCong + 1;
                                    await SaveAsync(GoiSo, GoiSoChiTiet);
                                    if (GoiSo.ID > 0)
                                    {
                                        model = GoiSo;
                                    }
                                }
                            }
                        }
                        else
                        {
                            await SaveGoiSoChiTietAsync(model, GoiSoChiTiet);
                        }
                    }
                }
            }
            return model;
        }
        private async Task<GoiSoChiTiet> SaveGoiSoChiTietAsync(GoiSo model)
        {
            GoiSoChiTiet GoiSoChiTiet = new GoiSoChiTiet();
            GoiSoChiTiet.ParentID = model.ID;
            GoiSoChiTiet.DanhMucDichVuID = model.DanhMucDichVuID;
            GoiSoChiTiet.DanhMucQuayDichVuID = model.DanhMucQuayDichVuID;
            GoiSoChiTiet.Code = model.Code;
            GoiSoChiTiet.Display = model.Display;
            GoiSoChiTiet.NgayCapSoSoThuTu = model.TongCong;

            await _GoiSoChiTietService.SaveAsync(GoiSoChiTiet);
            return GoiSoChiTiet;
        }
        private async Task<GoiSoChiTiet> SaveGoiSoChiTietAsync(GoiSo model, GoiSoChiTiet GoiSoChiTietSub)
        {
            GoiSoChiTiet GoiSoChiTiet = new GoiSoChiTiet();
            if (GoiSoChiTietSub.DanhMucNgonNguID > 0)
            {
                GoiSoChiTiet = GoiSoChiTietSub;
                GoiSoChiTiet.ParentID = model.ID;
                GoiSoChiTiet.NgayCapSoSoThuTu = model.TongCong;
            }

            await _GoiSoChiTietService.SaveAsync(GoiSoChiTiet);
            return GoiSoChiTiet;
        }
        public override async Task<int> RemoveAsync(long ID)
        {
            List<GoiSoChiTiet> ListGoiSoChiTiet = await _GoiSoChiTietService.GetByParentIDToListAsync(ID);
            if (ListGoiSoChiTiet.Count > 0)
            {
                await _GoiSoChiTietService.RemoveRangeAsync(ListGoiSoChiTiet);
            }
            return await _GoiSoRepository.RemoveAsync(ID);
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
                    GoiSoChiTiet.NgayTiepNhanSoThuTu = result.SoHienTai;
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
                    GoiSoChiTiet.NgayTiepNhanSoThuTu = result.SoHienTai;
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
        public virtual async Task<GoiSo> GoiSoTiepTheoByDanhMucDichVuID_DanhMucQuayDichVuIDAsync(long DanhMucDichVuID, long DanhMucQuayDichVuID)
        {
            GoiSo result = new GoiSo();
            DanhMucDichVu DanhMucDichVu = await _DanhMucDichVuRepository.GetByIDAsync(DanhMucDichVuID);
            try
            {
                DateTime Now = GlobalHelper.InitializationDateTime;
                if (DanhMucDichVu.IsHangDoiPhanNhanh == true)
                {
                    result = await GetByCondition(item => item.DanhMucDichVuID == DanhMucDichVuID && item.DanhMucQuayDichVuID == DanhMucQuayDichVuID && item.NgayGhiNhan.Value.Year == Now.Year && item.NgayGhiNhan.Value.Month == Now.Month && item.NgayGhiNhan.Value.Day == Now.Day).FirstOrDefaultAsync();
                }
                else
                {
                    result = await GetByCondition(item => item.DanhMucDichVuID == DanhMucDichVuID && item.NgayGhiNhan.Value.Year == Now.Year && item.NgayGhiNhan.Value.Month == Now.Month && item.NgayGhiNhan.Value.Day == Now.Day).FirstOrDefaultAsync();
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
        public virtual async Task<GoiSo> GoiSoTiepTheoByDanhMucDichVuID_DanhMucQuayDichVuID_SoHienTai_CodeAsync(long DanhMucDichVuID, long DanhMucQuayDichVuID, int SoHienTai, string Code)
        {
            GoiSo result = new GoiSo();
            DanhMucDichVu DanhMucDichVu = await _DanhMucDichVuRepository.GetByIDAsync(DanhMucDichVuID);
            DateTime Now = GlobalHelper.InitializationDateTime;
            if (DanhMucDichVu.BuocNhay == null)
            {
                DanhMucDichVu.BuocNhay = GlobalHelper.CapSoBuocNhay;
            }
            try
            {

                if (DanhMucDichVu.IsHangDoiPhanNhanh == true)
                {
                    result = await GetByCondition(item => item.DanhMucDichVuID == DanhMucDichVuID && item.DanhMucQuayDichVuID == DanhMucQuayDichVuID && item.NgayGhiNhan.Value.Year == Now.Year && item.NgayGhiNhan.Value.Month == Now.Month && item.NgayGhiNhan.Value.Day == Now.Day).FirstOrDefaultAsync();
                }
                else
                {
                    result = await GetByCondition(item => item.DanhMucDichVuID == DanhMucDichVuID && item.NgayGhiNhan.Value.Year == Now.Year && item.NgayGhiNhan.Value.Month == Now.Month && item.NgayGhiNhan.Value.Day == Now.Day).FirstOrDefaultAsync();
                }
                if (result != null)
                {
                    if (SoHienTai > 0)
                    {
                        if (result.SoHienTai != SoHienTai)
                        {
                            result.SoHienTai = SoHienTai;
                        }
                    }
                    else
                    {
                        SoHienTai = result.SoHienTai.Value;
                    }
                    if (result.SoHienTai < result.TongCong)
                    {
                        result.SoHienTai = result.SoHienTai + DanhMucDichVu.BuocNhay;
                        if (result.SoHienTai > result.TongCong)
                        {
                            result.SoHienTai = result.TongCong;
                        }
                        await UpdateAsync(result);
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
            int BatDau = SoHienTai + 1;
            int KetThuc = SoHienTai + DanhMucDichVu.BuocNhay.Value;
            for (int i = BatDau; i <= KetThuc; i++)
            {
                if (i > 0)
                {
                    if (i <= result.TongCong)
                    {
                        GoiSoChiTiet GoiSoChiTiet = new GoiSoChiTiet();
                        try
                        {
                            if (DanhMucDichVu.IsHangDoiPhanNhanh == true)
                            {
                                GoiSoChiTiet = await _GoiSoChiTietService.GetByCondition(item => item.NgayCapSo.Value.Year == Now.Year && item.NgayCapSo.Value.Month == Now.Month && item.NgayCapSo.Value.Day == Now.Day && item.DanhMucDichVuID == DanhMucDichVuID && item.DanhMucQuayDichVuID == DanhMucQuayDichVuID && item.NgayCapSoSoThuTu == i).FirstOrDefaultAsync();
                            }
                            else
                            {
                                GoiSoChiTiet = await _GoiSoChiTietService.GetByCondition(item => item.NgayCapSo.Value.Year == Now.Year && item.NgayCapSo.Value.Month == Now.Month && item.NgayCapSo.Value.Day == Now.Day && item.DanhMucDichVuID == DanhMucDichVuID && item.NgayCapSoSoThuTu == i).FirstOrDefaultAsync();
                            }
                            if (GoiSoChiTiet != null)
                            {
                                if (string.IsNullOrEmpty(GoiSoChiTiet.Code))
                                {
                                    GoiSoChiTiet.Code = Code;
                                }
                                GoiSoChiTiet.DanhMucQuayDichVuID = DanhMucQuayDichVuID;
                                GoiSoChiTiet.NgayTiepNhanSoThuTu = i;
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
        public virtual async Task<GoiSo> SaveByDanhMucDichVuID_CodeAsync(long DanhMucDichVuID, string Code)
        {
            GoiSo result = new GoiSo();
            try
            {
                if (DanhMucDichVuID > 0)
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
                    if (!string.IsNullOrEmpty(Code))
                    {
                        Code = Code.Split('|')[0];
                    }
                    result.Code = Code;
                    result.TongCong = result.TongCong + 1;
                    result = await SaveAsync(result);
                    if (result.ID > 0)
                    {
                        result = await CreateHTML002ByModelAsync(result);
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
            return result;
        }
        public virtual async Task<GoiSo> SaveByGoiSoChiTietAsync(GoiSoChiTiet GoiSoChiTiet)
        {
            GoiSo result = new GoiSo();
            try
            {
                if (GoiSoChiTiet.DanhMucDichVuID > 0)
                {
                    if (GoiSoChiTiet.DanhMucQuayDichVuID > 0)
                    {
                        DateTime Now = GlobalHelper.InitializationDateTime;
                        result = await GetByCondition(item => item.DanhMucDichVuID == GoiSoChiTiet.DanhMucDichVuID && item.DanhMucQuayDichVuID == GoiSoChiTiet.DanhMucQuayDichVuID && item.NgayGhiNhan.Value.Year == Now.Year && item.NgayGhiNhan.Value.Month == Now.Month && item.NgayGhiNhan.Value.Day == Now.Day).AsNoTracking().FirstOrDefaultAsync();
                        if (result == null)
                        {
                            result = new GoiSo();
                            result.DanhMucDichVuID = GoiSoChiTiet.DanhMucDichVuID;
                            result.DanhMucQuayDichVuID = GoiSoChiTiet.DanhMucQuayDichVuID;
                            result.NgayGhiNhan = Now;
                            result.TongCong = 0;
                            result.SoHienTai = 0;
                        }
                        result.TongCong = result.TongCong + 1;
                        await SaveAsync(result, GoiSoChiTiet);
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
            return result;
        }
        public virtual async Task<GoiSo> SaveByDanhMucDichVuID_Code_DisplayAsync(long DanhMucDichVuID, string Code, string Display)
        {
            GoiSo result = new GoiSo();
            try
            {
                if (DanhMucDichVuID > 0)
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
                    if (!string.IsNullOrEmpty(Code))
                    {
                        Code = Code.Split('|')[0];
                    }
                    result.Code = Code;
                    result.Display = Display;
                    result.TongCong = result.TongCong + 1;
                    result = await SaveAsync(result);
                    if (result.ID > 0)
                    {
                        await ZaloZNSSendAsync(result);
                        result = await CreateHTML002ByModelAsync(result);
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
            return result;
        }
        public virtual async Task<GoiSo> SaveByDanhMucDichVuID_Code_Display_IsInPhieu_IsGuiZaloAsync(long DanhMucDichVuID, string Code, string Display, bool IsInPhieu, bool IsGuiZalo)
        {
            GoiSo result = new GoiSo();
            try
            {
                if (DanhMucDichVuID > 0)
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
                    if (!string.IsNullOrEmpty(Code))
                    {
                        Code = Code.Split('|')[0];
                    }
                    result.Code = Code;
                    result.Display = Display;
                    result.TongCong = result.TongCong + 1;
                    result = await SaveAsync(result);
                    if (result.ID > 0)
                    {
                        if (IsGuiZalo == true)
                        {
                            await ZaloZNSSendAsync(result);
                        }
                        if (IsInPhieu == true)
                        {
                            result = await CreateHTML002ByModelAsync(result);
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
        public virtual async Task<GoiSo> CreateHTML002ByModelAsync(GoiSo result)
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

                //int PhieuDangKyFontSize = GlobalHelper.PhieuDangKyKichThuoc;
                //GoiSoThamSo GoiSoThamSo = await _GoiSoThamSoRepository.GetByIDAsync(GlobalHelper.GoiSoThamSoID);
                //if (GoiSoThamSo.ID > 0)
                //{
                //    if (GoiSoThamSo.KichThuocChu006 != null)
                //    {
                //        PhieuDangKyFontSize = GoiSoThamSo.KichThuocChu006.Value;
                //    }
                //}
                //if (PhieuDangKyFontSize == null)
                //{
                //    PhieuDangKyFontSize = GlobalHelper.PhieuDangKyKichThuoc;
                //}
                //int PhieuDangKyLineHeight = PhieuDangKyFontSize - 30;
                //contentHTML = contentHTML.Replace("[PhieuDangKyFontSize]", PhieuDangKyFontSize.ToString());
                //contentHTML = contentHTML.Replace("[PhieuDangKyLineHeight]", PhieuDangKyLineHeight.ToString());

                contentHTML = contentHTML.Replace("[NgayIn]", NgayIn.ToString("dd/MM/yyyy HH:mm:ss"));

                contentHTML = contentHTML.Replace("[APISite]", GlobalHelper.APISite);

                contentHTML = contentHTML.Replace("[DanhMucDichVuName]", result.DanhMucDichVuName);
                contentHTML = contentHTML.Replace("[Note]", result.Note);
                contentHTML = contentHTML.Replace("[TongCongString]", result.TongCongString);

                if (!string.IsNullOrEmpty(result.Code))
                {
                    string Barcode = @"<img src=""" + result.TypeName + @""" width=""194"" height=""50"" />";
                    contentHTML = contentHTML.Replace("[Barcode]", Barcode);
                    contentHTML = contentHTML.Replace("[Code]", result.Code);
                }
                else
                {
                    contentHTML = contentHTML.Replace("[Barcode]", GlobalHelper.InitializationString);
                    contentHTML = contentHTML.Replace("[Code]", GlobalHelper.InitializationString);
                }

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

                //await UpdateAsync(result);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        public virtual async Task<GoiSo> ZaloZNSSendAsync(GoiSo result)
        {
            try
            {
                if (!string.IsNullOrEmpty(result.Display))
                {
                    ZaloToken ZaloToken = await _ZaloTokenService.GetLatestAsync();
                    if (!string.IsNullOrEmpty(ZaloToken.OAAccessToken))
                    {
                        ZaloZNSDataRequest ZaloZNSDataRequest = new ZaloZNSDataRequest();
                        if (result.Display.Length == 10)
                        {
                            ZaloZNSDataRequest.phone = "84" + result.Display.Substring(1);
                        }
                        if (result.Display.Length == 9)
                        {
                            ZaloZNSDataRequest.phone = "84" + result.Display;
                        }
                        if (!string.IsNullOrEmpty(ZaloZNSDataRequest.phone))
                        {
                            ZaloZNSDataRequest.template_id = GlobalHelper.ZaloTemplateID;
                            ZaloZNSDataRequest.tracking_id = GlobalHelper.InitializationGUICode;
                            template_data template_data = new template_data();
                            template_data.TongCongString = result.TongCongString;
                            template_data.DanhMucDichVuName = result.DanhMucDichVuName;
                            template_data.Note = result.Note;
                            template_data.Code = result.Code;
                            template_data.NgayGhiNhan = result.NgayGhiNhan.Value.ToString("HH:mm:ss dd/MM/yyyy");
                            ZaloZNSDataRequest.template_data = template_data;
                            await ZaloHelper.ZNSSendAsync(ZaloToken.OAAccessToken, ZaloZNSDataRequest);
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
        public virtual async Task<List<GoiSo>> GetByYear_Month_DayToListAsync(int Year, int Month, int Day)
        {
            List<GoiSo> result = new List<GoiSo>();
            try
            {
                result = await GetByCondition(item => item.NgayGhiNhan.Value.Year == Year && item.NgayGhiNhan.Value.Month == Month && item.NgayGhiNhan.Value.Day == Day).ToListAsync();

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
        public virtual async Task<int> Sync_eHospital_DongNai_AAsync()
        {
            int result = GlobalHelper.InitializationNumber;
            DanhMucDichVu DanhMucDichVu = await _DanhMucDichVuRepository.GetByCondition(item => item.DanhMucUngDungID == GlobalHelper.eH_PhongBan_Id).FirstOrDefaultAsync();
            if (DanhMucDichVu != null)
            {
                if (DanhMucDichVu.ID > 0)
                {
                    DateTime Now = GlobalHelper.InitializationDateTime;
                    int eH_PhongBan_Id = (int)DanhMucDichVu.DanhMucUngDungID;
                    List<Data_eHospital_DongNai_A.Model.CLSYeuCau> ListCLSYeuCau = await _CLSYeuCauService.ReportACLSYeuCau0004ToListAsync(GlobalHelper.eH_NhomDichVu_Id, eH_PhongBan_Id, Now.Year, Now.Month, Now.Day);

                    List<DanhMucQuayDichVu> ListDanhMucQuayDichVu = await _DanhMucQuayDichVuRepository.GetByCondition(item => item.DanhMucDichVuID == DanhMucDichVu.ID).OrderBy(item => item.SortOrder).ToListAsync();

                    foreach (DanhMucQuayDichVu DanhMucQuayDichVu in ListDanhMucQuayDichVu)
                    {
                        List<Data_eHospital_DongNai_A.Model.CLSYeuCau> ListCLSYeuCauSub = ListCLSYeuCau.Where(item => item.NoiThucHien_Id == DanhMucQuayDichVu.DanhMucUngDungID).OrderBy(item => item.ThoiGianYeuCau).ToList();
                        if (ListCLSYeuCauSub.Count > 0)
                        {
                            foreach (Data_eHospital_DongNai_A.Model.CLSYeuCau CLSYeuCau in ListCLSYeuCauSub)
                            {
                                GoiSoChiTiet GoiSoChiTiet = new GoiSoChiTiet();
                                GoiSoChiTiet.DanhMucDichVuID = DanhMucDichVu.ID;
                                GoiSoChiTiet.DanhMucDichVuName = DanhMucDichVu.Name;
                                GoiSoChiTiet.DanhMucQuayDichVuID = DanhMucQuayDichVu.ID;
                                GoiSoChiTiet.DanhMucQuayDichVuName = DanhMucQuayDichVu.Name;
                                GoiSoChiTiet.DanhMucNgonNguID = CLSYeuCau.CLSYeuCau_Id;
                                GoiSoChiTiet.DanhMucUngDungID = CLSYeuCau.TiepNhan_Id;
                                GoiSoChiTiet.KhachHangID = CLSYeuCau.BenhNhan_Id;
                                GoiSoChiTiet.HoTen = CLSYeuCau.ChanDoan;
                                GoiSoChiTiet.NamSinh = CLSYeuCau.NamYeuCau;
                                GoiSoChiTiet.Code = CLSYeuCau.GhiChu;
                                GoiSoChiTiet.NgayCapSo = CLSYeuCau.ThoiGianYeuCau;

                                if (GoiSoChiTiet.DanhMucNgonNguID > 0)
                                {
                                    GoiSoChiTiet GoiSoChiTietCheck = await _GoiSoChiTietService.GetByCondition(item => item.DanhMucNgonNguID == GoiSoChiTiet.DanhMucNgonNguID).FirstOrDefaultAsync();
                                    if (GoiSoChiTietCheck != null)
                                    {
                                        if (GoiSoChiTietCheck.ID > 0)
                                        {                                           
                                        }
                                        else
                                        {
                                            await SaveByGoiSoChiTietAsync(GoiSoChiTiet);
                                        }
                                    }
                                }
                                
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}

