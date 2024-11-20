namespace Service.Implement
{
    public class KhachHangService : BaseService<KhachHang, IKhachHangRepository>
    , IKhachHangService
    {
    private readonly IKhachHangRepository _KhachHangRepository;
    public KhachHangService(IKhachHangRepository KhachHangRepository) : base(KhachHangRepository)
    {
    _KhachHangRepository = KhachHangRepository;
    }
    }
    }

