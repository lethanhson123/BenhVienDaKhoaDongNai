namespace Repository_eHospital_DongNai_A.Implement
{
    public class me_MAC_MappingRepository : BaseRepository<me_MAC_Mapping>
    , Ime_MAC_MappingRepository
    {
    private readonly Context _context;
    public me_MAC_MappingRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

