namespace Repository_eHospital_DongNai_A.Implement
{
    public class ObjectsMappingRepository : BaseRepository<ObjectsMapping>
    , IObjectsMappingRepository
    {
    private readonly Context _context;
    public ObjectsMappingRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

