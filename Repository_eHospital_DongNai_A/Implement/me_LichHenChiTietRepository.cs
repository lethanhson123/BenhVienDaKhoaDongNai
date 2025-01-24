namespace Repository_eHospital_DongNai_A.Implement
{
    public class me_LichHenChiTietRepository : BaseRepository<me_LichHenChiTiet>
    , Ime_LichHenChiTietRepository
    {
    private readonly Context _context;
    public me_LichHenChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

