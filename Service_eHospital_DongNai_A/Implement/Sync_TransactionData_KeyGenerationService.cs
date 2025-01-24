namespace Service_eHospital_DongNai_A.Implement
{
    public class Sync_TransactionData_KeyGenerationService : BaseService<Sync_TransactionData_KeyGeneration, ISync_TransactionData_KeyGenerationRepository>
    , ISync_TransactionData_KeyGenerationService
    {
    private readonly ISync_TransactionData_KeyGenerationRepository _Sync_TransactionData_KeyGenerationRepository;
    public Sync_TransactionData_KeyGenerationService(ISync_TransactionData_KeyGenerationRepository Sync_TransactionData_KeyGenerationRepository) : base(Sync_TransactionData_KeyGenerationRepository)
    {
    _Sync_TransactionData_KeyGenerationRepository = Sync_TransactionData_KeyGenerationRepository;
    }
    }
    }

