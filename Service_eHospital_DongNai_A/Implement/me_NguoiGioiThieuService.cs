namespace Service_eHospital_DongNai_A.Implement
{
    public class me_NguoiGioiThieuService : BaseService<me_NguoiGioiThieu, Ime_NguoiGioiThieuRepository>
    , Ime_NguoiGioiThieuService
    {
    private readonly Ime_NguoiGioiThieuRepository _me_NguoiGioiThieuRepository;
    public me_NguoiGioiThieuService(Ime_NguoiGioiThieuRepository me_NguoiGioiThieuRepository) : base(me_NguoiGioiThieuRepository)
    {
    _me_NguoiGioiThieuRepository = me_NguoiGioiThieuRepository;
    }
    }
    }

