namespace Service_eHospital_DongNai_A.Implement
{
    public class HoSoSucKhoe_DinhKy_ChitietService : BaseService<HoSoSucKhoe_DinhKy_Chitiet, IHoSoSucKhoe_DinhKy_ChitietRepository>
    , IHoSoSucKhoe_DinhKy_ChitietService
    {
    private readonly IHoSoSucKhoe_DinhKy_ChitietRepository _HoSoSucKhoe_DinhKy_ChitietRepository;
    public HoSoSucKhoe_DinhKy_ChitietService(IHoSoSucKhoe_DinhKy_ChitietRepository HoSoSucKhoe_DinhKy_ChitietRepository) : base(HoSoSucKhoe_DinhKy_ChitietRepository)
    {
    _HoSoSucKhoe_DinhKy_ChitietRepository = HoSoSucKhoe_DinhKy_ChitietRepository;
    }
    }
    }

