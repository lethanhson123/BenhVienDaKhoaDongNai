namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAn_ChiTietRepository : BaseRepository<BenhAn_ChiTiet>
    , IBenhAn_ChiTietRepository
    {
    private readonly Context _context;
    public BenhAn_ChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

