namespace Repository_eHospital_DongNai_A.Implement
{
    public class Sync_TableName_KeyGenerationRepository : BaseRepository<Sync_TableName_KeyGeneration>
    , ISync_TableName_KeyGenerationRepository
    {
    private readonly Context _context;
    public Sync_TableName_KeyGenerationRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

