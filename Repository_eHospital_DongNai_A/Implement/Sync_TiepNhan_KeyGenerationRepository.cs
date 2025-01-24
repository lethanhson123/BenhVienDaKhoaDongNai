namespace Repository_eHospital_DongNai_A.Implement
{
    public class Sync_TiepNhan_KeyGenerationRepository : BaseRepository<Sync_TiepNhan_KeyGeneration>
    , ISync_TiepNhan_KeyGenerationRepository
    {
    private readonly Context _context;
    public Sync_TiepNhan_KeyGenerationRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

