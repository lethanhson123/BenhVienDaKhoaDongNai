namespace Service.Implement
{
    public class DanhMucChuyenNganhService : BaseService<DanhMucChuyenNganh, IDanhMucChuyenNganhRepository>
    , IDanhMucChuyenNganhService
    {
    private readonly IDanhMucChuyenNganhRepository _DanhMucChuyenNganhRepository;
    public DanhMucChuyenNganhService(IDanhMucChuyenNganhRepository DanhMucChuyenNganhRepository) : base(DanhMucChuyenNganhRepository)
    {
    _DanhMucChuyenNganhRepository = DanhMucChuyenNganhRepository;
    }
    }
    }

