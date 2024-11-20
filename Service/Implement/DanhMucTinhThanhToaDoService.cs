namespace Service.Implement
{
    public class DanhMucTinhThanhToaDoService : BaseService<DanhMucTinhThanhToaDo, IDanhMucTinhThanhToaDoRepository>
    , IDanhMucTinhThanhToaDoService
    {
    private readonly IDanhMucTinhThanhToaDoRepository _DanhMucTinhThanhToaDoRepository;
    public DanhMucTinhThanhToaDoService(IDanhMucTinhThanhToaDoRepository DanhMucTinhThanhToaDoRepository) : base(DanhMucTinhThanhToaDoRepository)
    {
    _DanhMucTinhThanhToaDoRepository = DanhMucTinhThanhToaDoRepository;
    }
    }
    }

