namespace Repository_eHospital_DongNai_A.Implement
{
    public class PhieuGhiNhanUngThuRepository : BaseRepository<PhieuGhiNhanUngThu>
    , IPhieuGhiNhanUngThuRepository
    {
    private readonly Context _context;
    public PhieuGhiNhanUngThuRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

