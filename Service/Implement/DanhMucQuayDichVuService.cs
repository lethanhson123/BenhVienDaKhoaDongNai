namespace Service.Implement
{
    public class DanhMucQuayDichVuService : BaseService<DanhMucQuayDichVu, IDanhMucQuayDichVuRepository>
    , IDanhMucQuayDichVuService
    {
    private readonly IDanhMucQuayDichVuRepository _DanhMucQuayDichVuRepository;
    public DanhMucQuayDichVuService(IDanhMucQuayDichVuRepository DanhMucQuayDichVuRepository) : base(DanhMucQuayDichVuRepository)
    {
    _DanhMucQuayDichVuRepository = DanhMucQuayDichVuRepository;
    }
    }
    }

