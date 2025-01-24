namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnSanKhoaService : BaseService<BenhAnSanKhoa, IBenhAnSanKhoaRepository>
    , IBenhAnSanKhoaService
    {
    private readonly IBenhAnSanKhoaRepository _BenhAnSanKhoaRepository;
    public BenhAnSanKhoaService(IBenhAnSanKhoaRepository BenhAnSanKhoaRepository) : base(BenhAnSanKhoaRepository)
    {
    _BenhAnSanKhoaRepository = BenhAnSanKhoaRepository;
    }
    }
    }

