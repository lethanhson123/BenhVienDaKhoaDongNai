namespace Service.Implement
{
    public class DanhMucDichVuService : BaseService<DanhMucDichVu, IDanhMucDichVuRepository>
    , IDanhMucDichVuService
    {
    private readonly IDanhMucDichVuRepository _DanhMucDichVuRepository;
    public DanhMucDichVuService(IDanhMucDichVuRepository DanhMucDichVuRepository) : base(DanhMucDichVuRepository)
    {
    _DanhMucDichVuRepository = DanhMucDichVuRepository;
    }
    }
    }

