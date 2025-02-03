namespace Service_eHospital_DongNai_A_Config.Implement
{
    public class BenhSu_User_DichVu_PermissionsService : BaseService<BenhSu_User_DichVu_Permissions, IBenhSu_User_DichVu_PermissionsRepository>
    , IBenhSu_User_DichVu_PermissionsService
    {
    private readonly IBenhSu_User_DichVu_PermissionsRepository _BenhSu_User_DichVu_PermissionsRepository;
    public BenhSu_User_DichVu_PermissionsService(IBenhSu_User_DichVu_PermissionsRepository BenhSu_User_DichVu_PermissionsRepository) : base(BenhSu_User_DichVu_PermissionsRepository)
    {
    _BenhSu_User_DichVu_PermissionsRepository = BenhSu_User_DichVu_PermissionsRepository;
    }
    }
    }

