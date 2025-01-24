namespace Repository_eHospital_DongNai_A.Implement
{
    public class VienPhiNoiTruChiTietRepository : BaseRepository<VienPhiNoiTruChiTiet>
    , IVienPhiNoiTruChiTietRepository
    {
    private readonly Context _context;
    public VienPhiNoiTruChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

