namespace Repository_eHospital_DongNai_A.Implement
{
    public class me_GoiSoRepository : BaseRepository<me_GoiSo>
    , Ime_GoiSoRepository
    {
    private readonly Context _context;
    public me_GoiSoRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

