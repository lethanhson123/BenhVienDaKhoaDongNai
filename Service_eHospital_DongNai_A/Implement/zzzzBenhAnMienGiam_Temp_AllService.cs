namespace Service_eHospital_DongNai_A.Implement
{
    public class zzzzBenhAnMienGiam_Temp_AllService : BaseService<zzzzBenhAnMienGiam_Temp_All, IzzzzBenhAnMienGiam_Temp_AllRepository>
    , IzzzzBenhAnMienGiam_Temp_AllService
    {
    private readonly IzzzzBenhAnMienGiam_Temp_AllRepository _zzzzBenhAnMienGiam_Temp_AllRepository;
    public zzzzBenhAnMienGiam_Temp_AllService(IzzzzBenhAnMienGiam_Temp_AllRepository zzzzBenhAnMienGiam_Temp_AllRepository) : base(zzzzBenhAnMienGiam_Temp_AllRepository)
    {
    _zzzzBenhAnMienGiam_Temp_AllRepository = zzzzBenhAnMienGiam_Temp_AllRepository;
    }
    }
    }

