namespace Service_eHospital_DongNai_A.Implement
{
    public class me_LichHenChiTietService : BaseService<me_LichHenChiTiet, Ime_LichHenChiTietRepository>
    , Ime_LichHenChiTietService
    {
    private readonly Ime_LichHenChiTietRepository _me_LichHenChiTietRepository;
    public me_LichHenChiTietService(Ime_LichHenChiTietRepository me_LichHenChiTietRepository) : base(me_LichHenChiTietRepository)
    {
    _me_LichHenChiTietRepository = me_LichHenChiTietRepository;
    }
    }
    }

