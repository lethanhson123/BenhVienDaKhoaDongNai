namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAn_SaiGioRepository : BaseRepository<BenhAn_SaiGio>
    , IBenhAn_SaiGioRepository
    {
    private readonly Context _context;
    public BenhAn_SaiGioRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

