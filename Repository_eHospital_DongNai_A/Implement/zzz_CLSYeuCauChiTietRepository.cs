namespace Repository_eHospital_DongNai_A.Implement
{
    public class zzz_CLSYeuCauChiTietRepository : BaseRepository<zzz_CLSYeuCauChiTiet>
    , Izzz_CLSYeuCauChiTietRepository
    {
    private readonly Context _context;
    public zzz_CLSYeuCauChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

