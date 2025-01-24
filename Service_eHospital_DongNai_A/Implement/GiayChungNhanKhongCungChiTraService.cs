namespace Service_eHospital_DongNai_A.Implement
{
    public class GiayChungNhanKhongCungChiTraService : BaseService<GiayChungNhanKhongCungChiTra, IGiayChungNhanKhongCungChiTraRepository>
    , IGiayChungNhanKhongCungChiTraService
    {
    private readonly IGiayChungNhanKhongCungChiTraRepository _GiayChungNhanKhongCungChiTraRepository;
    public GiayChungNhanKhongCungChiTraService(IGiayChungNhanKhongCungChiTraRepository GiayChungNhanKhongCungChiTraRepository) : base(GiayChungNhanKhongCungChiTraRepository)
    {
    _GiayChungNhanKhongCungChiTraRepository = GiayChungNhanKhongCungChiTraRepository;
    }
    }
    }

