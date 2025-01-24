namespace Repository_eHospital_DongNai_A.Implement
{
    public class PhieuLinhDuocChiTietRepository : BaseRepository<PhieuLinhDuocChiTiet>
    , IPhieuLinhDuocChiTietRepository
    {
    private readonly Context _context;
    public PhieuLinhDuocChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

