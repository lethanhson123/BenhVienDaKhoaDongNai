namespace Service_eHospital_DongNai_A.Implement
{
    public class Cust_Backup_BsCCHNService : BaseService<Cust_Backup_BsCCHN, ICust_Backup_BsCCHNRepository>
    , ICust_Backup_BsCCHNService
    {
    private readonly ICust_Backup_BsCCHNRepository _Cust_Backup_BsCCHNRepository;
    public Cust_Backup_BsCCHNService(ICust_Backup_BsCCHNRepository Cust_Backup_BsCCHNRepository) : base(Cust_Backup_BsCCHNRepository)
    {
    _Cust_Backup_BsCCHNRepository = Cust_Backup_BsCCHNRepository;
    }
    }
    }

