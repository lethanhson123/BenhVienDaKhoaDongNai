namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_THONGTINUNGVIENService : BaseService<NS_THONGTINUNGVIEN, INS_THONGTINUNGVIENRepository>
    , INS_THONGTINUNGVIENService
    {
    private readonly INS_THONGTINUNGVIENRepository _NS_THONGTINUNGVIENRepository;
    public NS_THONGTINUNGVIENService(INS_THONGTINUNGVIENRepository NS_THONGTINUNGVIENRepository) : base(NS_THONGTINUNGVIENRepository)
    {
    _NS_THONGTINUNGVIENRepository = NS_THONGTINUNGVIENRepository;
    }
    }
    }

