namespace Service_eHospital_DongNai_A.Implement
{
    public class CLSBenhPhamService : BaseService<CLSBenhPham, ICLSBenhPhamRepository>
    , ICLSBenhPhamService
    {
    private readonly ICLSBenhPhamRepository _CLSBenhPhamRepository;
    public CLSBenhPhamService(ICLSBenhPhamRepository CLSBenhPhamRepository) : base(CLSBenhPhamRepository)
    {
    _CLSBenhPhamRepository = CLSBenhPhamRepository;
    }
    }
    }

