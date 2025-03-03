namespace Service.Implement
{
    public class DanhMucChucVuService : BaseService<DanhMucChucVu, IDanhMucChucVuRepository>
    , IDanhMucChucVuService
    {
    private readonly IDanhMucChucVuRepository _DanhMucChucVuRepository;
    public DanhMucChucVuService(IDanhMucChucVuRepository DanhMucChucVuRepository) : base(DanhMucChucVuRepository)
    {
    _DanhMucChucVuRepository = DanhMucChucVuRepository;
    }
    }
    }

