namespace Service_eHospital_DongNai_A.Implement
{
    public class NoiTru_GiuongBenhService : BaseService<NoiTru_GiuongBenh, INoiTru_GiuongBenhRepository>
    , INoiTru_GiuongBenhService
    {
    private readonly INoiTru_GiuongBenhRepository _NoiTru_GiuongBenhRepository;
    public NoiTru_GiuongBenhService(INoiTru_GiuongBenhRepository NoiTru_GiuongBenhRepository) : base(NoiTru_GiuongBenhRepository)
    {
    _NoiTru_GiuongBenhRepository = NoiTru_GiuongBenhRepository;
    }
    }
    }

