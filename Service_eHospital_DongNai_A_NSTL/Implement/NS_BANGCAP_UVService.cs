namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_BANGCAP_UVService : BaseService<NS_BANGCAP_UV, INS_BANGCAP_UVRepository>
    , INS_BANGCAP_UVService
    {
    private readonly INS_BANGCAP_UVRepository _NS_BANGCAP_UVRepository;
    public NS_BANGCAP_UVService(INS_BANGCAP_UVRepository NS_BANGCAP_UVRepository) : base(NS_BANGCAP_UVRepository)
    {
    _NS_BANGCAP_UVRepository = NS_BANGCAP_UVRepository;
    }
    }
    }

