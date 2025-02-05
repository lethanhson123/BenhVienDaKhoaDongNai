namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_CONGTAC_UVService : BaseService<NS_CONGTAC_UV, INS_CONGTAC_UVRepository>
    , INS_CONGTAC_UVService
    {
    private readonly INS_CONGTAC_UVRepository _NS_CONGTAC_UVRepository;
    public NS_CONGTAC_UVService(INS_CONGTAC_UVRepository NS_CONGTAC_UVRepository) : base(NS_CONGTAC_UVRepository)
    {
    _NS_CONGTAC_UVRepository = NS_CONGTAC_UVRepository;
    }
    }
    }

