namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_NhanVien_Lich_CaTrucService : BaseService<NS_NhanVien_Lich_CaTruc, INS_NhanVien_Lich_CaTrucRepository>
    , INS_NhanVien_Lich_CaTrucService
    {
    private readonly INS_NhanVien_Lich_CaTrucRepository _NS_NhanVien_Lich_CaTrucRepository;
    public NS_NhanVien_Lich_CaTrucService(INS_NhanVien_Lich_CaTrucRepository NS_NhanVien_Lich_CaTrucRepository) : base(NS_NhanVien_Lich_CaTrucRepository)
    {
    _NS_NhanVien_Lich_CaTrucRepository = NS_NhanVien_Lich_CaTrucRepository;
    }
    }
    }

