namespace Service.Implement
{
    public class DanhMucBacLuongService : BaseService<DanhMucBacLuong, IDanhMucBacLuongRepository>
    , IDanhMucBacLuongService
    {
    private readonly IDanhMucBacLuongRepository _DanhMucBacLuongRepository;
    public DanhMucBacLuongService(IDanhMucBacLuongRepository DanhMucBacLuongRepository) : base(DanhMucBacLuongRepository)
    {
    _DanhMucBacLuongRepository = DanhMucBacLuongRepository;
    }
    }
    }

