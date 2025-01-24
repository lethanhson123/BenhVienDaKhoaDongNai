namespace Service_eHospital_DongNai_A.Implement
{
    public class UserTraKQXNService : BaseService<UserTraKQXN, IUserTraKQXNRepository>
    , IUserTraKQXNService
    {
    private readonly IUserTraKQXNRepository _UserTraKQXNRepository;
    public UserTraKQXNService(IUserTraKQXNRepository UserTraKQXNRepository) : base(UserTraKQXNRepository)
    {
    _UserTraKQXNRepository = UserTraKQXNRepository;
    }
    }
    }

