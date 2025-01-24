namespace Repository_eHospital_DongNai_A.Implement
{
    public class me_DM_MACAddressRepository : BaseRepository<me_DM_MACAddress>
    , Ime_DM_MACAddressRepository
    {
    private readonly Context _context;
    public me_DM_MACAddressRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

