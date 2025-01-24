namespace Service_eHospital_DongNai_A.Implement
{
    public class MienGiamNoiTruChiTietService : BaseService<MienGiamNoiTruChiTiet, IMienGiamNoiTruChiTietRepository>
    , IMienGiamNoiTruChiTietService
    {
    private readonly IMienGiamNoiTruChiTietRepository _MienGiamNoiTruChiTietRepository;
    public MienGiamNoiTruChiTietService(IMienGiamNoiTruChiTietRepository MienGiamNoiTruChiTietRepository) : base(MienGiamNoiTruChiTietRepository)
    {
    _MienGiamNoiTruChiTietRepository = MienGiamNoiTruChiTietRepository;
    }
    }
    }

