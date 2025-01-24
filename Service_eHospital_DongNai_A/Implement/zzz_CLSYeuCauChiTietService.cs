namespace Service_eHospital_DongNai_A.Implement
{
    public class zzz_CLSYeuCauChiTietService : BaseService<zzz_CLSYeuCauChiTiet, Izzz_CLSYeuCauChiTietRepository>
    , Izzz_CLSYeuCauChiTietService
    {
    private readonly Izzz_CLSYeuCauChiTietRepository _zzz_CLSYeuCauChiTietRepository;
    public zzz_CLSYeuCauChiTietService(Izzz_CLSYeuCauChiTietRepository zzz_CLSYeuCauChiTietRepository) : base(zzz_CLSYeuCauChiTietRepository)
    {
    _zzz_CLSYeuCauChiTietRepository = zzz_CLSYeuCauChiTietRepository;
    }
    }
    }

