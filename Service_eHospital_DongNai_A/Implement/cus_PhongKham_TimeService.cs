namespace Service_eHospital_DongNai_A.Implement
{
    public class cus_PhongKham_TimeService : BaseService<cus_PhongKham_Time, Icus_PhongKham_TimeRepository>
    , Icus_PhongKham_TimeService
    {
    private readonly Icus_PhongKham_TimeRepository _cus_PhongKham_TimeRepository;
    public cus_PhongKham_TimeService(Icus_PhongKham_TimeRepository cus_PhongKham_TimeRepository) : base(cus_PhongKham_TimeRepository)
    {
    _cus_PhongKham_TimeRepository = cus_PhongKham_TimeRepository;
    }
    }
    }

