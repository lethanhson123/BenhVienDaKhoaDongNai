namespace Service_eHospital_DongNai_A.Implement
{
    public class ThucHienCheckListChiTietService : BaseService<ThucHienCheckListChiTiet, IThucHienCheckListChiTietRepository>
    , IThucHienCheckListChiTietService
    {
    private readonly IThucHienCheckListChiTietRepository _ThucHienCheckListChiTietRepository;
    public ThucHienCheckListChiTietService(IThucHienCheckListChiTietRepository ThucHienCheckListChiTietRepository) : base(ThucHienCheckListChiTietRepository)
    {
    _ThucHienCheckListChiTietRepository = ThucHienCheckListChiTietRepository;
    }
    }
    }

