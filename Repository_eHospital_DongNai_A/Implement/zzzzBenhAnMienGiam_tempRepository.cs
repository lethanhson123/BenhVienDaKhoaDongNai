namespace Repository_eHospital_DongNai_A.Implement
{
    public class zzzzBenhAnMienGiam_tempRepository : BaseRepository<zzzzBenhAnMienGiam_temp>
    , IzzzzBenhAnMienGiam_tempRepository
    {
    private readonly Context _context;
    public zzzzBenhAnMienGiam_tempRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

