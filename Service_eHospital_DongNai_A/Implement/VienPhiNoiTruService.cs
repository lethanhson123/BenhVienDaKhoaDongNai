namespace Service_eHospital_DongNai_A.Implement
{
    public class VienPhiNoiTruService : BaseService<VienPhiNoiTru, IVienPhiNoiTruRepository>
    , IVienPhiNoiTruService
    {
    private readonly IVienPhiNoiTruRepository _VienPhiNoiTruRepository;
    public VienPhiNoiTruService(IVienPhiNoiTruRepository VienPhiNoiTruRepository) : base(VienPhiNoiTruRepository)
    {
    _VienPhiNoiTruRepository = VienPhiNoiTruRepository;
    }
    }
    }

