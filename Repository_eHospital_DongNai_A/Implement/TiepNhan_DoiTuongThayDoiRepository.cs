namespace Repository_eHospital_DongNai_A.Implement
{
    public class TiepNhan_DoiTuongThayDoiRepository : BaseRepository<TiepNhan_DoiTuongThayDoi>
    , ITiepNhan_DoiTuongThayDoiRepository
    {
    private readonly Context _context;
    public TiepNhan_DoiTuongThayDoiRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

