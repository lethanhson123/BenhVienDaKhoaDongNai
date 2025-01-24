namespace Service_eHospital_DongNai_A.Implement
{
    public class VienPhiNoiTru_Loai_IDRefService : BaseService<VienPhiNoiTru_Loai_IDRef, IVienPhiNoiTru_Loai_IDRefRepository>
    , IVienPhiNoiTru_Loai_IDRefService
    {
    private readonly IVienPhiNoiTru_Loai_IDRefRepository _VienPhiNoiTru_Loai_IDRefRepository;
    public VienPhiNoiTru_Loai_IDRefService(IVienPhiNoiTru_Loai_IDRefRepository VienPhiNoiTru_Loai_IDRefRepository) : base(VienPhiNoiTru_Loai_IDRefRepository)
    {
    _VienPhiNoiTru_Loai_IDRefRepository = VienPhiNoiTru_Loai_IDRefRepository;
    }
    }
    }

