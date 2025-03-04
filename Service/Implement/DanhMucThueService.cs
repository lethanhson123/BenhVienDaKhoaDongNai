namespace Service.Implement
{
    public class DanhMucThueService : BaseService<DanhMucThue, IDanhMucThueRepository>
    , IDanhMucThueService
    {
    private readonly IDanhMucThueRepository _DanhMucThueRepository;
    public DanhMucThueService(IDanhMucThueRepository DanhMucThueRepository) : base(DanhMucThueRepository)
    {
    _DanhMucThueRepository = DanhMucThueRepository;
    }
    }
    }

