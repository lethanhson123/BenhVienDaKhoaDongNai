namespace Service_eHospital_DongNai_A.Implement
{
    public class zzzzBenhAnMienGiam_AllService : BaseService<zzzzBenhAnMienGiam_All, IzzzzBenhAnMienGiam_AllRepository>
    , IzzzzBenhAnMienGiam_AllService
    {
    private readonly IzzzzBenhAnMienGiam_AllRepository _zzzzBenhAnMienGiam_AllRepository;
    public zzzzBenhAnMienGiam_AllService(IzzzzBenhAnMienGiam_AllRepository zzzzBenhAnMienGiam_AllRepository) : base(zzzzBenhAnMienGiam_AllRepository)
    {
    _zzzzBenhAnMienGiam_AllRepository = zzzzBenhAnMienGiam_AllRepository;
    }
    }
    }

