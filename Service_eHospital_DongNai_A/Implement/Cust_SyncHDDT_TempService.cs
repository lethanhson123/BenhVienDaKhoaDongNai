namespace Service_eHospital_DongNai_A.Implement
{
    public class Cust_SyncHDDT_TempService : BaseService<Cust_SyncHDDT_Temp, ICust_SyncHDDT_TempRepository>
    , ICust_SyncHDDT_TempService
    {
    private readonly ICust_SyncHDDT_TempRepository _Cust_SyncHDDT_TempRepository;
    public Cust_SyncHDDT_TempService(ICust_SyncHDDT_TempRepository Cust_SyncHDDT_TempRepository) : base(Cust_SyncHDDT_TempRepository)
    {
    _Cust_SyncHDDT_TempRepository = Cust_SyncHDDT_TempRepository;
    }
    }
    }

