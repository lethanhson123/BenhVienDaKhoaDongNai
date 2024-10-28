namespace Service.Implement
{
    public class CongViecService : BaseService<CongViec, ICongViecRepository>
    , ICongViecService
    {
        private readonly ICongViecRepository _CongViecRepository;

        private readonly IThanhVienRepository _ThanhVienRepository;

        private readonly IDanhMucTinhTrangRepository _DanhMucTinhTrangRepository;

        public CongViecService(ICongViecRepository CongViecRepository

            , IThanhVienRepository ThanhVienRepository

            , IDanhMucTinhTrangRepository DanhMucTinhTrangRepository

            ) : base(CongViecRepository)
        {
            _CongViecRepository = CongViecRepository;

            _ThanhVienRepository = ThanhVienRepository;

            _DanhMucTinhTrangRepository = DanhMucTinhTrangRepository;
        }
        public override void Initialization(CongViec model)
        {
            BaseInitialization(model);

            if (model.NgayYeuCau == null)
            {
                model.NgayYeuCau = GlobalHelper.InitializationDateTime;
            }

            if (model.DanhMucTinhTrangID == null)
            {
                model.DanhMucTinhTrangID = GlobalHelper.DanhMucThanhVienID;
            }

            if (model.DanhMucTinhTrangID > 0)
            {
                if (string.IsNullOrEmpty(model.DanhMucTinhTrangName))
                {
                    model.DanhMucTinhTrangName = _DanhMucTinhTrangRepository.GetByID(model.DanhMucTinhTrangID.Value).Name;
                }
            }

            if (model.ThanhVienYeuCauID > 0)
            {
                ThanhVien ThanhVien = _ThanhVienRepository.GetByID(model.ThanhVienYeuCauID.Value);
                model.ThanhVienYeuCauName = ThanhVien.Name;
                model.ThanhVienYeuCauDienThoai = ThanhVien.DienThoai;
                model.ThanhVienYeuCauEmail = ThanhVien.Email;

                model.DanhMucPhongBanYeuCauID = ThanhVien.ParentID;
                model.DanhMucPhongBanYeuCauName = ThanhVien.ParentName;
            }

            if (model.ThanhVienGiaiQuyetID > 0)
            {
                ThanhVien ThanhVien = _ThanhVienRepository.GetByID(model.ThanhVienGiaiQuyetID.Value);
                model.ThanhVienGiaiQuyetName = ThanhVien.Name;
                model.ThanhVienGiaiQuyetDienThoai = ThanhVien.DienThoai;
                model.ThanhVienGiaiQuyetEmail = ThanhVien.Email;

                model.DanhMucPhongBanGiaiQuyetID = ThanhVien.ParentID;
                model.DanhMucPhongBanGiaiQuyetName = ThanhVien.ParentName;
            }
        }

        public virtual async Task<List<CongViec>> GetByBatDau_KetThucToListAsync(DateTime BatDau, DateTime KetThuc)
        {
            List<CongViec> result = new List<CongViec>();
            try
            {
                BatDau = new DateTime(BatDau.Year, BatDau.Month, BatDau.Day, 0, 0, 0);
                KetThuc = new DateTime(KetThuc.Year, KetThuc.Month, KetThuc.Day, 23, 59, 59);
                result = await GetByCondition(item => item.NgayYeuCau >= BatDau && item.NgayYeuCau <= KetThuc).ToListAsync();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        public virtual async Task<List<CongViec>> GetBySearchString_BatDau_KetThucToListAsync(string SearchString, DateTime BatDau, DateTime KetThuc)
        {
            List<CongViec> result = new List<CongViec>();
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
        public override async Task<List<CongViec>> GetBySearchStringToListAsync(string SearchString)
        {
            List<CongViec> result = new List<CongViec>();
            try
            {
                if (!string.IsNullOrEmpty(SearchString))
                {
                    result = await GetByCondition(item => item.Name.Contains(SearchString)

                    || item.ThanhVienYeuCauName.Contains(SearchString)

                    || item.ThanhVienYeuCauDienThoai.Contains(SearchString)

                    || item.ThanhVienYeuCauEmail.Contains(SearchString)

                    || item.ThanhVienGiaiQuyetName.Contains(SearchString)

                    || item.ThanhVienGiaiQuyetDienThoai.Contains(SearchString)

                    || item.ThanhVienGiaiQuyetEmail.Contains(SearchString)

                    || item.DanhMucPhongBanYeuCauName.Contains(SearchString)

                    || item.DanhMucPhongBanGiaiQuyetName.Contains(SearchString)

                    ).ToListAsync();
                }
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        public virtual async Task<List<CongViec>> GetByThanhVienIDToListAsync(long ThanhVienID)
        {
            List<CongViec> result = new List<CongViec>();
            try
            {               
                    result = await GetByCondition(item => item.ThanhVienYeuCauID == ThanhVienID

                    || item.ThanhVienGiaiQuyetID == ThanhVienID
                    
                    ).ToListAsync();                
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
    }
}

