namespace Service_eHospital_DongNai_A.Implement
{
    public class zzz_DM_Duoc_SQDService : BaseService<zzz_DM_Duoc_SQD, Izzz_DM_Duoc_SQDRepository>
    , Izzz_DM_Duoc_SQDService
    {
    private readonly Izzz_DM_Duoc_SQDRepository _zzz_DM_Duoc_SQDRepository;
    public zzz_DM_Duoc_SQDService(Izzz_DM_Duoc_SQDRepository zzz_DM_Duoc_SQDRepository) : base(zzz_DM_Duoc_SQDRepository)
    {
    _zzz_DM_Duoc_SQDRepository = zzz_DM_Duoc_SQDRepository;
    }
    }
    }

