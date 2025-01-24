namespace Repository_eHospital_DongNai_A.Implement
{
    public class zzzzBenhAnMienGiam_AllRepository : BaseRepository<zzzzBenhAnMienGiam_All>
    , IzzzzBenhAnMienGiam_AllRepository
    {
    private readonly Context _context;
    public zzzzBenhAnMienGiam_AllRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

