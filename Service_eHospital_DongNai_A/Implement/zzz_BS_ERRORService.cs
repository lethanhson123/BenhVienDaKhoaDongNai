namespace Service_eHospital_DongNai_A.Implement
{
    public class zzz_BS_ERRORService : BaseService<zzz_BS_ERROR, Izzz_BS_ERRORRepository>
    , Izzz_BS_ERRORService
    {
    private readonly Izzz_BS_ERRORRepository _zzz_BS_ERRORRepository;
    public zzz_BS_ERRORService(Izzz_BS_ERRORRepository zzz_BS_ERRORRepository) : base(zzz_BS_ERRORRepository)
    {
    _zzz_BS_ERRORRepository = zzz_BS_ERRORRepository;
    }
    }
    }

