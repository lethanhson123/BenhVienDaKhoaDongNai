namespace Service.Implement
{
    public class DanhMucMauSacService : BaseService<DanhMucMauSac, IDanhMucMauSacRepository>
    , IDanhMucMauSacService
    {
    private readonly IDanhMucMauSacRepository _DanhMucMauSacRepository;
    public DanhMucMauSacService(IDanhMucMauSacRepository DanhMucMauSacRepository) : base(DanhMucMauSacRepository)
    {
    _DanhMucMauSacRepository = DanhMucMauSacRepository;
    }
    }
    }

