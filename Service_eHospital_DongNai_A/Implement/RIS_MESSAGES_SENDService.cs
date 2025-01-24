namespace Service_eHospital_DongNai_A.Implement
{
    public class RIS_MESSAGES_SENDService : BaseService<RIS_MESSAGES_SEND, IRIS_MESSAGES_SENDRepository>
    , IRIS_MESSAGES_SENDService
    {
    private readonly IRIS_MESSAGES_SENDRepository _RIS_MESSAGES_SENDRepository;
    public RIS_MESSAGES_SENDService(IRIS_MESSAGES_SENDRepository RIS_MESSAGES_SENDRepository) : base(RIS_MESSAGES_SENDRepository)
    {
    _RIS_MESSAGES_SENDRepository = RIS_MESSAGES_SENDRepository;
    }
    }
    }

