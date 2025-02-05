namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_NhanVien_NhanVienService : BaseService<NS_NhanVien_NhanVien, INS_NhanVien_NhanVienRepository>
    , INS_NhanVien_NhanVienService
    {
    private readonly INS_NhanVien_NhanVienRepository _NS_NhanVien_NhanVienRepository;
    public NS_NhanVien_NhanVienService(INS_NhanVien_NhanVienRepository NS_NhanVien_NhanVienRepository) : base(NS_NhanVien_NhanVienRepository)
    {
    _NS_NhanVien_NhanVienRepository = NS_NhanVien_NhanVienRepository;
    }
    }
    }

