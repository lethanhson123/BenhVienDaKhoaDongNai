namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_BacLuongService : BaseService<NS_DM_BacLuong, INS_DM_BacLuongRepository>
    , INS_DM_BacLuongService
    {
    private readonly INS_DM_BacLuongRepository _NS_DM_BacLuongRepository;
    public NS_DM_BacLuongService(INS_DM_BacLuongRepository NS_DM_BacLuongRepository) : base(NS_DM_BacLuongRepository)
    {
    _NS_DM_BacLuongRepository = NS_DM_BacLuongRepository;
    }
    }
    }

