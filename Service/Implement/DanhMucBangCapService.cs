namespace Service.Implement
{
    public class DanhMucBangCapService : BaseService<DanhMucBangCap, IDanhMucBangCapRepository>
    , IDanhMucBangCapService
    {
    private readonly IDanhMucBangCapRepository _DanhMucBangCapRepository;
    public DanhMucBangCapService(IDanhMucBangCapRepository DanhMucBangCapRepository) : base(DanhMucBangCapRepository)
    {
    _DanhMucBangCapRepository = DanhMucBangCapRepository;
    }
    }
    }

