namespace Service_eHospital_DongNai_A.Implement
{
    public class NoiTru_ChamSocService : BaseService<NoiTru_ChamSoc, INoiTru_ChamSocRepository>
    , INoiTru_ChamSocService
    {
    private readonly INoiTru_ChamSocRepository _NoiTru_ChamSocRepository;
    public NoiTru_ChamSocService(INoiTru_ChamSocRepository NoiTru_ChamSocRepository) : base(NoiTru_ChamSocRepository)
    {
    _NoiTru_ChamSocRepository = NoiTru_ChamSocRepository;
    }
    }
    }

