namespace Service.Implement
{
    public class DanhMucKhuVucService : BaseService<DanhMucKhuVuc, IDanhMucKhuVucRepository>
    , IDanhMucKhuVucService
    {
    private readonly IDanhMucKhuVucRepository _DanhMucKhuVucRepository;
    public DanhMucKhuVucService(IDanhMucKhuVucRepository DanhMucKhuVucRepository) : base(DanhMucKhuVucRepository)
    {
    _DanhMucKhuVucRepository = DanhMucKhuVucRepository;
    }
    }
    }

