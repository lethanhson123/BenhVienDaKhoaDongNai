namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_RP_FORMULARSService : BaseService<NS_RP_FORMULARS, INS_RP_FORMULARSRepository>
    , INS_RP_FORMULARSService
    {
    private readonly INS_RP_FORMULARSRepository _NS_RP_FORMULARSRepository;
    public NS_RP_FORMULARSService(INS_RP_FORMULARSRepository NS_RP_FORMULARSRepository) : base(NS_RP_FORMULARSRepository)
    {
    _NS_RP_FORMULARSRepository = NS_RP_FORMULARSRepository;
    }
    }
    }

