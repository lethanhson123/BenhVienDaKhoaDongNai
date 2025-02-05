namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_MucHuongDocHaiService : BaseService<NS_DM_MucHuongDocHai, INS_DM_MucHuongDocHaiRepository>
    , INS_DM_MucHuongDocHaiService
    {
    private readonly INS_DM_MucHuongDocHaiRepository _NS_DM_MucHuongDocHaiRepository;
    public NS_DM_MucHuongDocHaiService(INS_DM_MucHuongDocHaiRepository NS_DM_MucHuongDocHaiRepository) : base(NS_DM_MucHuongDocHaiRepository)
    {
    _NS_DM_MucHuongDocHaiRepository = NS_DM_MucHuongDocHaiRepository;
    }
    }
    }

