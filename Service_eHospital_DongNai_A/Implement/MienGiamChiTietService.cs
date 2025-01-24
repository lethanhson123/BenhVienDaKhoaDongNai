namespace Service_eHospital_DongNai_A.Implement
{
    public class MienGiamChiTietService : BaseService<MienGiamChiTiet, IMienGiamChiTietRepository>
    , IMienGiamChiTietService
    {
    private readonly IMienGiamChiTietRepository _MienGiamChiTietRepository;
    public MienGiamChiTietService(IMienGiamChiTietRepository MienGiamChiTietRepository) : base(MienGiamChiTietRepository)
    {
    _MienGiamChiTietRepository = MienGiamChiTietRepository;
    }
    }
    }

