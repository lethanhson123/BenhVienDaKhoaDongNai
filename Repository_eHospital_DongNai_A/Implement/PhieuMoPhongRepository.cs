namespace Repository_eHospital_DongNai_A.Implement
{
    public class PhieuMoPhongRepository : BaseRepository<PhieuMoPhong>
    , IPhieuMoPhongRepository
    {
    private readonly Context _context;
    public PhieuMoPhongRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

