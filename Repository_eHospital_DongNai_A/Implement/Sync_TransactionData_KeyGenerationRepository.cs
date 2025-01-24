namespace Repository_eHospital_DongNai_A.Implement
{
    public class Sync_TransactionData_KeyGenerationRepository : BaseRepository<Sync_TransactionData_KeyGeneration>
    , ISync_TransactionData_KeyGenerationRepository
    {
    private readonly Context _context;
    public Sync_TransactionData_KeyGenerationRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

