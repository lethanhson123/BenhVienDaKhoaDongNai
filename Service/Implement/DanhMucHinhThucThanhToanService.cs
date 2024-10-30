namespace Service.Implement
{
    public class DanhMucHinhThucThanhToanService : BaseService<DanhMucHinhThucThanhToan, IDanhMucHinhThucThanhToanRepository>
    , IDanhMucHinhThucThanhToanService
    {
    private readonly IDanhMucHinhThucThanhToanRepository _DanhMucHinhThucThanhToanRepository;
    public DanhMucHinhThucThanhToanService(IDanhMucHinhThucThanhToanRepository DanhMucHinhThucThanhToanRepository) : base(DanhMucHinhThucThanhToanRepository)
    {
    _DanhMucHinhThucThanhToanRepository = DanhMucHinhThucThanhToanRepository;
    }
    }
    }

