namespace Repository_eHospital_DongNai_A.Implement
{
    public class zzzzBangKe_TuChiTraRepository : BaseRepository<zzzzBangKe_TuChiTra>
    , IzzzzBangKe_TuChiTraRepository
    {
    private readonly Context _context;
    public zzzzBangKe_TuChiTraRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

