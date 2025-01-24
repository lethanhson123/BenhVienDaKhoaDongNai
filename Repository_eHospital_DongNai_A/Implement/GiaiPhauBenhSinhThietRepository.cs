namespace Repository_eHospital_DongNai_A.Implement
{
    public class GiaiPhauBenhSinhThietRepository : BaseRepository<GiaiPhauBenhSinhThiet>
    , IGiaiPhauBenhSinhThietRepository
    {
    private readonly Context _context;
    public GiaiPhauBenhSinhThietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

