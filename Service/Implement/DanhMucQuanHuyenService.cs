namespace Service.Implement
{
    public class DanhMucQuanHuyenService : BaseService<DanhMucQuanHuyen, IDanhMucQuanHuyenRepository>
    , IDanhMucQuanHuyenService
    {
        private readonly IDanhMucQuanHuyenRepository _DanhMucQuanHuyenRepository;

        private readonly IDanhMucTinhThanhRepository _DanhMucTinhThanhRepository;

        public DanhMucQuanHuyenService(IDanhMucQuanHuyenRepository DanhMucQuanHuyenRepository
            , IDanhMucTinhThanhRepository danhMucTinhThanhRepository

            ) : base(DanhMucQuanHuyenRepository)
        {
            _DanhMucQuanHuyenRepository = DanhMucQuanHuyenRepository;
            _DanhMucTinhThanhRepository = danhMucTinhThanhRepository;
        }
        public override void Initialization(DanhMucQuanHuyen model)
        {
            BaseInitialization(model);

            if (model.ParentID > 0)
            {
                DanhMucTinhThanh DanhMucTinhThanh = _DanhMucTinhThanhRepository.GetByID(model.ParentID.Value);
                model.TypeName = DanhMucTinhThanh.TypeName;
                model.ParentName = DanhMucTinhThanh.Name;
            }
        }
    }
}

