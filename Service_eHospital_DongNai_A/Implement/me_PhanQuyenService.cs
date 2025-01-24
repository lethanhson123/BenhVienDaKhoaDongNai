namespace Service_eHospital_DongNai_A.Implement
{
    public class me_PhanQuyenService : BaseService<me_PhanQuyen, Ime_PhanQuyenRepository>
    , Ime_PhanQuyenService
    {
    private readonly Ime_PhanQuyenRepository _me_PhanQuyenRepository;
    public me_PhanQuyenService(Ime_PhanQuyenRepository me_PhanQuyenRepository) : base(me_PhanQuyenRepository)
    {
    _me_PhanQuyenRepository = me_PhanQuyenRepository;
    }
    }
    }

