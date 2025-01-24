namespace Repository_eHospital_DongNai_A.Implement
{
    public class BienLaiChiTietRepository : BaseRepository<BienLaiChiTiet>
    , IBienLaiChiTietRepository
    {
    private readonly Context _context;
    public BienLaiChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

