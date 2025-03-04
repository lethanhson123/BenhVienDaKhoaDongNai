namespace Service.Implement
{
    public class DanhMucLuongCoBanService : BaseService<DanhMucLuongCoBan, IDanhMucLuongCoBanRepository>
    , IDanhMucLuongCoBanService
    {
    private readonly IDanhMucLuongCoBanRepository _DanhMucLuongCoBanRepository;
    public DanhMucLuongCoBanService(IDanhMucLuongCoBanRepository DanhMucLuongCoBanRepository) : base(DanhMucLuongCoBanRepository)
    {
    _DanhMucLuongCoBanRepository = DanhMucLuongCoBanRepository;
    }
    }
    }

