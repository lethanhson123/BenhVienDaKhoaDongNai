namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_BacSi_DichVuService : BaseService<DM_BacSi_DichVu, IDM_BacSi_DichVuRepository>
    , IDM_BacSi_DichVuService
    {
    private readonly IDM_BacSi_DichVuRepository _DM_BacSi_DichVuRepository;
    public DM_BacSi_DichVuService(IDM_BacSi_DichVuRepository DM_BacSi_DichVuRepository) : base(DM_BacSi_DichVuRepository)
    {
    _DM_BacSi_DichVuRepository = DM_BacSi_DichVuRepository;
    }
    }
    }

