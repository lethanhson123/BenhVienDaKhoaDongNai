namespace Service_eHospital_DongNai_A.Implement
{
    public class Map_PB_Group_KiosService : BaseService<Map_PB_Group_Kios, IMap_PB_Group_KiosRepository>
    , IMap_PB_Group_KiosService
    {
    private readonly IMap_PB_Group_KiosRepository _Map_PB_Group_KiosRepository;
    public Map_PB_Group_KiosService(IMap_PB_Group_KiosRepository Map_PB_Group_KiosRepository) : base(Map_PB_Group_KiosRepository)
    {
    _Map_PB_Group_KiosRepository = Map_PB_Group_KiosRepository;
    }
    }
    }

