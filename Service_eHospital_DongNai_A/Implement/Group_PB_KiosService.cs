namespace Service_eHospital_DongNai_A.Implement
{
    public class Group_PB_KiosService : BaseService<Group_PB_Kios, IGroup_PB_KiosRepository>
    , IGroup_PB_KiosService
    {
    private readonly IGroup_PB_KiosRepository _Group_PB_KiosRepository;
    public Group_PB_KiosService(IGroup_PB_KiosRepository Group_PB_KiosRepository) : base(Group_PB_KiosRepository)
    {
    _Group_PB_KiosRepository = Group_PB_KiosRepository;
    }
    }
    }

