namespace Service.Implement
{
    public class DanhMucPhuCapService : BaseService<DanhMucPhuCap, IDanhMucPhuCapRepository>
    , IDanhMucPhuCapService
    {
    private readonly IDanhMucPhuCapRepository _DanhMucPhuCapRepository;
    public DanhMucPhuCapService(IDanhMucPhuCapRepository DanhMucPhuCapRepository) : base(DanhMucPhuCapRepository)
    {
    _DanhMucPhuCapRepository = DanhMucPhuCapRepository;
    }
    }
    }

