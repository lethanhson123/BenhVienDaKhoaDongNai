namespace Service.Implement
{
    public class DanhMucChamCongService : BaseService<DanhMucChamCong, IDanhMucChamCongRepository>
    , IDanhMucChamCongService
    {
    private readonly IDanhMucChamCongRepository _DanhMucChamCongRepository;
    public DanhMucChamCongService(IDanhMucChamCongRepository DanhMucChamCongRepository) : base(DanhMucChamCongRepository)
    {
    _DanhMucChamCongRepository = DanhMucChamCongRepository;
    }
    }
    }

