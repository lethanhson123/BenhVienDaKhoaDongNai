namespace Service.Implement
{
    public class DanhMucBieuMauService : BaseService<DanhMucBieuMau, IDanhMucBieuMauRepository>
    , IDanhMucBieuMauService
    {
    private readonly IDanhMucBieuMauRepository _DanhMucBieuMauRepository;
    public DanhMucBieuMauService(IDanhMucBieuMauRepository DanhMucBieuMauRepository) : base(DanhMucBieuMauRepository)
    {
    _DanhMucBieuMauRepository = DanhMucBieuMauRepository;
    }
    }
    }

