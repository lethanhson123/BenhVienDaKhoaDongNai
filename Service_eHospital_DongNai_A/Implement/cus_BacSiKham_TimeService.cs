namespace Service_eHospital_DongNai_A.Implement
{
    public class cus_BacSiKham_TimeService : BaseService<cus_BacSiKham_Time, Icus_BacSiKham_TimeRepository>
    , Icus_BacSiKham_TimeService
    {
    private readonly Icus_BacSiKham_TimeRepository _cus_BacSiKham_TimeRepository;
    public cus_BacSiKham_TimeService(Icus_BacSiKham_TimeRepository cus_BacSiKham_TimeRepository) : base(cus_BacSiKham_TimeRepository)
    {
    _cus_BacSiKham_TimeRepository = cus_BacSiKham_TimeRepository;
    }
    }
    }

