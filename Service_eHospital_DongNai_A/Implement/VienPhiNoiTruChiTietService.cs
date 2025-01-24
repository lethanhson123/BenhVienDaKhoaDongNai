namespace Service_eHospital_DongNai_A.Implement
{
    public class VienPhiNoiTruChiTietService : BaseService<VienPhiNoiTruChiTiet, IVienPhiNoiTruChiTietRepository>
    , IVienPhiNoiTruChiTietService
    {
    private readonly IVienPhiNoiTruChiTietRepository _VienPhiNoiTruChiTietRepository;
    public VienPhiNoiTruChiTietService(IVienPhiNoiTruChiTietRepository VienPhiNoiTruChiTietRepository) : base(VienPhiNoiTruChiTietRepository)
    {
    _VienPhiNoiTruChiTietRepository = VienPhiNoiTruChiTietRepository;
    }
    }
    }

