namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class zTemp_NV_excelService : BaseService<zTemp_NV_excel, IzTemp_NV_excelRepository>
    , IzTemp_NV_excelService
    {
    private readonly IzTemp_NV_excelRepository _zTemp_NV_excelRepository;
    public zTemp_NV_excelService(IzTemp_NV_excelRepository zTemp_NV_excelRepository) : base(zTemp_NV_excelRepository)
    {
    _zTemp_NV_excelRepository = zTemp_NV_excelRepository;
    }
    }
    }

