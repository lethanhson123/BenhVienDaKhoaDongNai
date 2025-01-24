namespace Service_eHospital_DongNai_A.Implement
{
    public class HoaDonVienPhiChiTietService : BaseService<HoaDonVienPhiChiTiet, IHoaDonVienPhiChiTietRepository>
    , IHoaDonVienPhiChiTietService
    {
    private readonly IHoaDonVienPhiChiTietRepository _HoaDonVienPhiChiTietRepository;
    public HoaDonVienPhiChiTietService(IHoaDonVienPhiChiTietRepository HoaDonVienPhiChiTietRepository) : base(HoaDonVienPhiChiTietRepository)
    {
    _HoaDonVienPhiChiTietRepository = HoaDonVienPhiChiTietRepository;
    }
    }
    }

