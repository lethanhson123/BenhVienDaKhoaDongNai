namespace Service_eHospital_DongNai_A.Implement
{
    public class zzz_BS_YLenh_BService : BaseService<zzz_BS_YLenh_B, Izzz_BS_YLenh_BRepository>
    , Izzz_BS_YLenh_BService
    {
    private readonly Izzz_BS_YLenh_BRepository _zzz_BS_YLenh_BRepository;
    public zzz_BS_YLenh_BService(Izzz_BS_YLenh_BRepository zzz_BS_YLenh_BRepository) : base(zzz_BS_YLenh_BRepository)
    {
    _zzz_BS_YLenh_BRepository = zzz_BS_YLenh_BRepository;
    }
    }
    }

