namespace Service_eHospital_DongNai_A.Implement
{
    public class zzz_Cust_ThamSoService : BaseService<zzz_Cust_ThamSo, Izzz_Cust_ThamSoRepository>
    , Izzz_Cust_ThamSoService
    {
    private readonly Izzz_Cust_ThamSoRepository _zzz_Cust_ThamSoRepository;
    public zzz_Cust_ThamSoService(Izzz_Cust_ThamSoRepository zzz_Cust_ThamSoRepository) : base(zzz_Cust_ThamSoRepository)
    {
    _zzz_Cust_ThamSoRepository = zzz_Cust_ThamSoRepository;
    }
    }
    }

