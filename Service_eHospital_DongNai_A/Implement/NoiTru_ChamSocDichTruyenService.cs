namespace Service_eHospital_DongNai_A.Implement
{
    public class NoiTru_ChamSocDichTruyenService : BaseService<NoiTru_ChamSocDichTruyen, INoiTru_ChamSocDichTruyenRepository>
    , INoiTru_ChamSocDichTruyenService
    {
    private readonly INoiTru_ChamSocDichTruyenRepository _NoiTru_ChamSocDichTruyenRepository;
    public NoiTru_ChamSocDichTruyenService(INoiTru_ChamSocDichTruyenRepository NoiTru_ChamSocDichTruyenRepository) : base(NoiTru_ChamSocDichTruyenRepository)
    {
    _NoiTru_ChamSocDichTruyenRepository = NoiTru_ChamSocDichTruyenRepository;
    }
    }
    }

