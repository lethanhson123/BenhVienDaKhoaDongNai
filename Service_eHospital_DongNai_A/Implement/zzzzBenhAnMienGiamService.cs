namespace Service_eHospital_DongNai_A.Implement
{
    public class zzzzBenhAnMienGiamService : BaseService<zzzzBenhAnMienGiam, IzzzzBenhAnMienGiamRepository>
    , IzzzzBenhAnMienGiamService
    {
    private readonly IzzzzBenhAnMienGiamRepository _zzzzBenhAnMienGiamRepository;
    public zzzzBenhAnMienGiamService(IzzzzBenhAnMienGiamRepository zzzzBenhAnMienGiamRepository) : base(zzzzBenhAnMienGiamRepository)
    {
    _zzzzBenhAnMienGiamRepository = zzzzBenhAnMienGiamRepository;
    }
    }
    }

