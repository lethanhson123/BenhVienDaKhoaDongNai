namespace Service_eHospital_DongNai_A.Implement
{
    public class me_MAC_MappingService : BaseService<me_MAC_Mapping, Ime_MAC_MappingRepository>
    , Ime_MAC_MappingService
    {
    private readonly Ime_MAC_MappingRepository _me_MAC_MappingRepository;
    public me_MAC_MappingService(Ime_MAC_MappingRepository me_MAC_MappingRepository) : base(me_MAC_MappingRepository)
    {
    _me_MAC_MappingRepository = me_MAC_MappingRepository;
    }
    }
    }

