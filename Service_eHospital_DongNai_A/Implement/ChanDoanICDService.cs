namespace Service_eHospital_DongNai_A.Implement
{
    public class ChanDoanICDService : BaseService<ChanDoanICD, IChanDoanICDRepository>
    , IChanDoanICDService
    {
    private readonly IChanDoanICDRepository _ChanDoanICDRepository;
    public ChanDoanICDService(IChanDoanICDRepository ChanDoanICDRepository) : base(ChanDoanICDRepository)
    {
    _ChanDoanICDRepository = ChanDoanICDRepository;
    }
    }
    }

