namespace Service_eHospital_DongNai_A.Implement
{
    public class zzz_DM_BS_BHYTService : BaseService<zzz_DM_BS_BHYT, Izzz_DM_BS_BHYTRepository>
    , Izzz_DM_BS_BHYTService
    {
    private readonly Izzz_DM_BS_BHYTRepository _zzz_DM_BS_BHYTRepository;
    public zzz_DM_BS_BHYTService(Izzz_DM_BS_BHYTRepository zzz_DM_BS_BHYTRepository) : base(zzz_DM_BS_BHYTRepository)
    {
    _zzz_DM_BS_BHYTRepository = zzz_DM_BS_BHYTRepository;
    }
    }
    }

