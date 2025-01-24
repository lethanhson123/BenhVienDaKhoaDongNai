namespace Service_eHospital_DongNai_A.Implement
{
    public class zzz_CLSYeuCauService : BaseService<zzz_CLSYeuCau, Izzz_CLSYeuCauRepository>
    , Izzz_CLSYeuCauService
    {
    private readonly Izzz_CLSYeuCauRepository _zzz_CLSYeuCauRepository;
    public zzz_CLSYeuCauService(Izzz_CLSYeuCauRepository zzz_CLSYeuCauRepository) : base(zzz_CLSYeuCauRepository)
    {
    _zzz_CLSYeuCauRepository = zzz_CLSYeuCauRepository;
    }
    }
    }

