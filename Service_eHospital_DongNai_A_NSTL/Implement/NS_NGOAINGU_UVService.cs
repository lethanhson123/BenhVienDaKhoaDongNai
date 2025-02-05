namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_NGOAINGU_UVService : BaseService<NS_NGOAINGU_UV, INS_NGOAINGU_UVRepository>
    , INS_NGOAINGU_UVService
    {
    private readonly INS_NGOAINGU_UVRepository _NS_NGOAINGU_UVRepository;
    public NS_NGOAINGU_UVService(INS_NGOAINGU_UVRepository NS_NGOAINGU_UVRepository) : base(NS_NGOAINGU_UVRepository)
    {
    _NS_NGOAINGU_UVRepository = NS_NGOAINGU_UVRepository;
    }
    }
    }

