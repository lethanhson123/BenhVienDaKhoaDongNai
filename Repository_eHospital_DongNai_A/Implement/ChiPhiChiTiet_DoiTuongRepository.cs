namespace Repository_eHospital_DongNai_A.Implement
{
    public class ChiPhiChiTiet_DoiTuongRepository : BaseRepository<ChiPhiChiTiet_DoiTuong>
    , IChiPhiChiTiet_DoiTuongRepository
    {
    private readonly Context _context;
    public ChiPhiChiTiet_DoiTuongRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

