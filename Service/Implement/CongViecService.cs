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
    }
}

