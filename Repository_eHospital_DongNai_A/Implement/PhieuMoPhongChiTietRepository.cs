namespace Repository_eHospital_DongNai_A.Implement
{
    public class PhieuMoPhongChiTietRepository : BaseRepository<PhieuMoPhongChiTiet>
    , IPhieuMoPhongChiTietRepository
    {
    private readonly Context _context;
    public PhieuMoPhongChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

