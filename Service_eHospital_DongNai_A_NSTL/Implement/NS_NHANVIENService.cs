namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_NHANVIENService : BaseService<NS_NHANVIEN, INS_NHANVIENRepository>
    , INS_NHANVIENService
    {
    private readonly INS_NHANVIENRepository _NS_NHANVIENRepository;
    public NS_NHANVIENService(INS_NHANVIENRepository NS_NHANVIENRepository) : base(NS_NHANVIENRepository)
    {
    _NS_NHANVIENRepository = NS_NHANVIENRepository;
    }
    }
    }

