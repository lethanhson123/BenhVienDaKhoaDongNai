namespace Service.Implement
{
    public class DanhMucThongKeService : BaseService<DanhMucThongKe, IDanhMucThongKeRepository>
    , IDanhMucThongKeService
    {
    private readonly IDanhMucThongKeRepository _DanhMucThongKeRepository;
    public DanhMucThongKeService(IDanhMucThongKeRepository DanhMucThongKeRepository) : base(DanhMucThongKeRepository)
    {
    _DanhMucThongKeRepository = DanhMucThongKeRepository;
    }
    }
    }

