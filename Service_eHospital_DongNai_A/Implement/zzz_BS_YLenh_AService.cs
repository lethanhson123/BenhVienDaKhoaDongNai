namespace Service_eHospital_DongNai_A.Implement
{
    public class zzz_BS_YLenh_AService : BaseService<zzz_BS_YLenh_A, Izzz_BS_YLenh_ARepository>
    , Izzz_BS_YLenh_AService
    {
    private readonly Izzz_BS_YLenh_ARepository _zzz_BS_YLenh_ARepository;
    public zzz_BS_YLenh_AService(Izzz_BS_YLenh_ARepository zzz_BS_YLenh_ARepository) : base(zzz_BS_YLenh_ARepository)
    {
    _zzz_BS_YLenh_ARepository = zzz_BS_YLenh_ARepository;
    }
    }
    }

