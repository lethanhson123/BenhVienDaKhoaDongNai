namespace Repository_eHospital_DongNai_A.Implement
{
    public class zzzPhongBanRepository : BaseRepository<zzzPhongBan>
    , IzzzPhongBanRepository
    {
    private readonly Context _context;
    public zzzPhongBanRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

