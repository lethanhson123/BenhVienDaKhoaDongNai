namespace Service_eHospital_DongNai_A.Implement
{
    public class NoiTru_DichVuService : BaseService<NoiTru_DichVu, INoiTru_DichVuRepository>
    , INoiTru_DichVuService
    {
    private readonly INoiTru_DichVuRepository _NoiTru_DichVuRepository;
    public NoiTru_DichVuService(INoiTru_DichVuRepository NoiTru_DichVuRepository) : base(NoiTru_DichVuRepository)
    {
    _NoiTru_DichVuRepository = NoiTru_DichVuRepository;
    }
    }
    }

