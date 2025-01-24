namespace Repository_eHospital_DongNai_A.Implement
{
    public class me_PhongBanRepository : BaseRepository<me_PhongBan>
    , Ime_PhongBanRepository
    {
    private readonly Context _context;
    public me_PhongBanRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

