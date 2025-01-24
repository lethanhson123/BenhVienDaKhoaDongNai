namespace Repository_eHospital_DongNai_A.Implement
{
    public class me_CapSoRepository : BaseRepository<me_CapSo>
    , Ime_CapSoRepository
    {
    private readonly Context _context;
    public me_CapSoRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

