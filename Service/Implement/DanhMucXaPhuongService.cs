namespace Service.Implement
{
    public class DanhMucXaPhuongService : BaseService<DanhMucXaPhuong, IDanhMucXaPhuongRepository>
    , IDanhMucXaPhuongService
    {
        private readonly IDanhMucXaPhuongRepository _DanhMucXaPhuongRepository;

        private readonly IDanhMucQuanHuyenRepository _DanhMucQuanHuyenRepository;

        private readonly IDanhMucTinhThanhRepository _DanhMucTinhThanhRepository;
        public DanhMucXaPhuongService(IDanhMucXaPhuongRepository DanhMucXaPhuongRepository

            , IDanhMucQuanHuyenRepository DanhMucQuanHuyenRepository
            , IDanhMucTinhThanhRepository danhMucTinhThanhRepository

            ) : base(DanhMucXaPhuongRepository)
        {
            _DanhMucXaPhuongRepository = DanhMucXaPhuongRepository;

            _DanhMucQuanHuyenRepository = DanhMucQuanHuyenRepository;
            _DanhMucTinhThanhRepository = danhMucTinhThanhRepository;
        }

        public override void Initialization(DanhMucXaPhuong model)
        {
            BaseInitialization(model);

            if (model.ParentID > 0)
            {
                DanhMucQuanHuyen DanhMucQuanHuyen = _DanhMucQuanHuyenRepository.GetByID(model.ParentID.Value);
                model.Display = DanhMucQuanHuyen.Display;
                model.ParentName = DanhMucQuanHuyen.Name;
                if (DanhMucQuanHuyen.ParentID > 0)
                {
                    DanhMucTinhThanh DanhMucTinhThanh = _DanhMucTinhThanhRepository.GetByID(DanhMucQuanHuyen.ParentID.Value);
                    model.TypeName = DanhMucTinhThanh.TypeName;
                }
            }
        }
    }
}

