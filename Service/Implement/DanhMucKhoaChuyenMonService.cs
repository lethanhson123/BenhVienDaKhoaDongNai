namespace Service.Implement
{
    public class DanhMucKhoaChuyenMonService : BaseService<DanhMucKhoaChuyenMon, IDanhMucKhoaChuyenMonRepository>
    , IDanhMucKhoaChuyenMonService
    {
        private readonly IDanhMucKhoaChuyenMonRepository _DanhMucKhoaChuyenMonRepository;
        public DanhMucKhoaChuyenMonService(IDanhMucKhoaChuyenMonRepository DanhMucKhoaChuyenMonRepository) : base(DanhMucKhoaChuyenMonRepository)
        {
            _DanhMucKhoaChuyenMonRepository = DanhMucKhoaChuyenMonRepository;
        }
    }
}

