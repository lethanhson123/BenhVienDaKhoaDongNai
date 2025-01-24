namespace Repository_eHospital_DongNai_A.Implement
{
    public class VTB_NAPRUTTIENRepository : BaseRepository<VTB_NAPRUTTIEN>
    , IVTB_NAPRUTTIENRepository
    {
    private readonly Context _context;
    public VTB_NAPRUTTIENRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

