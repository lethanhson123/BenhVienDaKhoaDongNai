namespace Service_eHospital_DongNai_A.Implement
{
    public class NoiTru_ChuyenKhuService : BaseService<NoiTru_ChuyenKhu, INoiTru_ChuyenKhuRepository>
    , INoiTru_ChuyenKhuService
    {
    private readonly INoiTru_ChuyenKhuRepository _NoiTru_ChuyenKhuRepository;
    public NoiTru_ChuyenKhuService(INoiTru_ChuyenKhuRepository NoiTru_ChuyenKhuRepository) : base(NoiTru_ChuyenKhuRepository)
    {
    _NoiTru_ChuyenKhuRepository = NoiTru_ChuyenKhuRepository;
    }
    }
    }

