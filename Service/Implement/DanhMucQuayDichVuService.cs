using Service.Interface;

namespace Service.Implement
{
    public class DanhMucQuayDichVuService : BaseService<DanhMucQuayDichVu, IDanhMucQuayDichVuRepository>
    , IDanhMucQuayDichVuService
    {
        private readonly IDanhMucQuayDichVuRepository _DanhMucQuayDichVuRepository;

        private readonly IDanhMucKhuVucRepository _DanhMucKhuVucRepository;
        public DanhMucQuayDichVuService(IDanhMucQuayDichVuRepository DanhMucQuayDichVuRepository
            
            , IDanhMucKhuVucRepository danhMucKhuVucRepository
            
            ) : base(DanhMucQuayDichVuRepository)
        {
            _DanhMucQuayDichVuRepository = DanhMucQuayDichVuRepository;
            _DanhMucKhuVucRepository = danhMucKhuVucRepository;
        }
        public override void Initialization(DanhMucQuayDichVu model)
        {
            BaseInitialization(model);    
            
            if (model.ParentID > 0)
            {
                model.ParentName = _DanhMucKhuVucRepository.GetByID(model.ParentID.Value).Name;
            }            
        }
    }
}

