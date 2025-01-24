namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnSanKhoa_ChiTietService : BaseService<BenhAnSanKhoa_ChiTiet, IBenhAnSanKhoa_ChiTietRepository>
    , IBenhAnSanKhoa_ChiTietService
    {
    private readonly IBenhAnSanKhoa_ChiTietRepository _BenhAnSanKhoa_ChiTietRepository;
    public BenhAnSanKhoa_ChiTietService(IBenhAnSanKhoa_ChiTietRepository BenhAnSanKhoa_ChiTietRepository) : base(BenhAnSanKhoa_ChiTietRepository)
    {
    _BenhAnSanKhoa_ChiTietRepository = BenhAnSanKhoa_ChiTietRepository;
    }
    }
    }

