namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_KHENTHUONGKYLUATService : BaseService<NS_KHENTHUONGKYLUAT, INS_KHENTHUONGKYLUATRepository>
    , INS_KHENTHUONGKYLUATService
    {
    private readonly INS_KHENTHUONGKYLUATRepository _NS_KHENTHUONGKYLUATRepository;
    public NS_KHENTHUONGKYLUATService(INS_KHENTHUONGKYLUATRepository NS_KHENTHUONGKYLUATRepository) : base(NS_KHENTHUONGKYLUATRepository)
    {
    _NS_KHENTHUONGKYLUATRepository = NS_KHENTHUONGKYLUATRepository;
    }
    }
    }

