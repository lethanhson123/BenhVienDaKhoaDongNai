namespace Service_eHospital_DongNai_A.Implement
{
    public class zzzzBenhAnMienGiam_tempService : BaseService<zzzzBenhAnMienGiam_temp, IzzzzBenhAnMienGiam_tempRepository>
    , IzzzzBenhAnMienGiam_tempService
    {
    private readonly IzzzzBenhAnMienGiam_tempRepository _zzzzBenhAnMienGiam_tempRepository;
    public zzzzBenhAnMienGiam_tempService(IzzzzBenhAnMienGiam_tempRepository zzzzBenhAnMienGiam_tempRepository) : base(zzzzBenhAnMienGiam_tempRepository)
    {
    _zzzzBenhAnMienGiam_tempRepository = zzzzBenhAnMienGiam_tempRepository;
    }
    }
    }

