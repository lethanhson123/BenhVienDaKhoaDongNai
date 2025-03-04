namespace Service.Implement
{
    public class DanhMucHopDongService : BaseService<DanhMucHopDong, IDanhMucHopDongRepository>
    , IDanhMucHopDongService
    {
    private readonly IDanhMucHopDongRepository _DanhMucHopDongRepository;
    public DanhMucHopDongService(IDanhMucHopDongRepository DanhMucHopDongRepository) : base(DanhMucHopDongRepository)
    {
    _DanhMucHopDongRepository = DanhMucHopDongRepository;
    }
    }
    }

