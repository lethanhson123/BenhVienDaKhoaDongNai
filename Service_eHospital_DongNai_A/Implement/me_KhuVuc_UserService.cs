namespace Service_eHospital_DongNai_A.Implement
{
    public class me_KhuVuc_UserService : BaseService<me_KhuVuc_User, Ime_KhuVuc_UserRepository>
    , Ime_KhuVuc_UserService
    {
    private readonly Ime_KhuVuc_UserRepository _me_KhuVuc_UserRepository;
    public me_KhuVuc_UserService(Ime_KhuVuc_UserRepository me_KhuVuc_UserRepository) : base(me_KhuVuc_UserRepository)
    {
    _me_KhuVuc_UserRepository = me_KhuVuc_UserRepository;
    }
    }
    }

