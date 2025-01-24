namespace Repository_eHospital_DongNai_A.Implement
{
    public class zzzzBangKe_TuChiTra_AllRepository : BaseRepository<zzzzBangKe_TuChiTra_All>
    , IzzzzBangKe_TuChiTra_AllRepository
    {
    private readonly Context _context;
    public zzzzBangKe_TuChiTra_AllRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

