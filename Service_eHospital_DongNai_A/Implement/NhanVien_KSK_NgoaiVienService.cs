namespace Service_eHospital_DongNai_A.Implement
{
    public class NhanVien_KSK_NgoaiVienService : BaseService<NhanVien_KSK_NgoaiVien, INhanVien_KSK_NgoaiVienRepository>
    , INhanVien_KSK_NgoaiVienService
    {
    private readonly INhanVien_KSK_NgoaiVienRepository _NhanVien_KSK_NgoaiVienRepository;
    public NhanVien_KSK_NgoaiVienService(INhanVien_KSK_NgoaiVienRepository NhanVien_KSK_NgoaiVienRepository) : base(NhanVien_KSK_NgoaiVienRepository)
    {
    _NhanVien_KSK_NgoaiVienRepository = NhanVien_KSK_NgoaiVienRepository;
    }
    }
    }

