namespace Repository_eHospital_DongNai_A.Implement
{
    public class zzzzBenhAnMienGiam_Temp_AllRepository : BaseRepository<zzzzBenhAnMienGiam_Temp_All>
    , IzzzzBenhAnMienGiam_Temp_AllRepository
    {
    private readonly Context _context;
    public zzzzBenhAnMienGiam_Temp_AllRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

