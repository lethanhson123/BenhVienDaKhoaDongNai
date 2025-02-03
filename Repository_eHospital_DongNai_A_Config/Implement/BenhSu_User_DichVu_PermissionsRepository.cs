namespace Repository_eHospital_DongNai_A_Config.Implement
{
    public class BenhSu_User_DichVu_PermissionsRepository : BaseRepository<BenhSu_User_DichVu_Permissions>
    , IBenhSu_User_DichVu_PermissionsRepository
    {
    private readonly Context _context;
    public BenhSu_User_DichVu_PermissionsRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

