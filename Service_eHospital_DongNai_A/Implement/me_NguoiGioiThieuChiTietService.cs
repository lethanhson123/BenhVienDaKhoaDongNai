namespace Service_eHospital_DongNai_A.Implement
{
    public class me_NguoiGioiThieuChiTietService : BaseService<me_NguoiGioiThieuChiTiet, Ime_NguoiGioiThieuChiTietRepository>
    , Ime_NguoiGioiThieuChiTietService
    {
    private readonly Ime_NguoiGioiThieuChiTietRepository _me_NguoiGioiThieuChiTietRepository;
    public me_NguoiGioiThieuChiTietService(Ime_NguoiGioiThieuChiTietRepository me_NguoiGioiThieuChiTietRepository) : base(me_NguoiGioiThieuChiTietRepository)
    {
    _me_NguoiGioiThieuChiTietRepository = me_NguoiGioiThieuChiTietRepository;
    }
    }
    }

