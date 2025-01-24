namespace Service_eHospital_DongNai_A.Implement
{
    public class me_UserService : BaseService<me_User, Ime_UserRepository>
    , Ime_UserService
    {
    private readonly Ime_UserRepository _me_UserRepository;
    public me_UserService(Ime_UserRepository me_UserRepository) : base(me_UserRepository)
    {
    _me_UserRepository = me_UserRepository;
    }
    }
    }

