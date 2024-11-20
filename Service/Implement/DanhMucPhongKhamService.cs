namespace Service.Implement
{
    public class DanhMucPhongKhamService : BaseService<DanhMucPhongKham, IDanhMucPhongKhamRepository>
    , IDanhMucPhongKhamService
    {
        private readonly IDanhMucPhongKhamRepository _DanhMucPhongKhamRepository;

        private readonly IDanhMucKhoaChuyenMonRepository _DanhMucKhoaChuyenMonRepository;
        public DanhMucPhongKhamService(IDanhMucPhongKhamRepository DanhMucPhongKhamRepository
            
            , IDanhMucKhoaChuyenMonRepository danhMucKhoaChuyenMonRepository
            
            ) : base(DanhMucPhongKhamRepository)
        {
            _DanhMucPhongKhamRepository = DanhMucPhongKhamRepository;
            _DanhMucKhoaChuyenMonRepository = danhMucKhoaChuyenMonRepository;
        }

        public override void Initialization(DanhMucPhongKham model)
        {
            BaseInitialization(model);

            if (model.ParentID > 0)
            {
                model.ParentName = _DanhMucKhoaChuyenMonRepository.GetByID(model.ParentID.Value).Name;
            }
        }
    }
}

