namespace Repository_eHospital_DongNai_A.Implement
{
    public class zzzzBenhAnMienGiamRepository : BaseRepository<zzzzBenhAnMienGiam>
    , IzzzzBenhAnMienGiamRepository
    {
    private readonly Context _context;
    public zzzzBenhAnMienGiamRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

