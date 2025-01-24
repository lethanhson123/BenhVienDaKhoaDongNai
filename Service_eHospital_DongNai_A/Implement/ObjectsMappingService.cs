namespace Service_eHospital_DongNai_A.Implement
{
    public class ObjectsMappingService : BaseService<ObjectsMapping, IObjectsMappingRepository>
    , IObjectsMappingService
    {
    private readonly IObjectsMappingRepository _ObjectsMappingRepository;
    public ObjectsMappingService(IObjectsMappingRepository ObjectsMappingRepository) : base(ObjectsMappingRepository)
    {
    _ObjectsMappingRepository = ObjectsMappingRepository;
    }
    }
    }

