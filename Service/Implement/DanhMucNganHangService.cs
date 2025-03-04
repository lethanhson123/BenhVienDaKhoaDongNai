namespace Service.Implement
{
    public class DanhMucNganHangService : BaseService<DanhMucNganHang, IDanhMucNganHangRepository>
    , IDanhMucNganHangService
    {
    private readonly IDanhMucNganHangRepository _DanhMucNganHangRepository;
    public DanhMucNganHangService(IDanhMucNganHangRepository DanhMucNganHangRepository) : base(DanhMucNganHangRepository)
    {
    _DanhMucNganHangRepository = DanhMucNganHangRepository;
    }
    }
    }

