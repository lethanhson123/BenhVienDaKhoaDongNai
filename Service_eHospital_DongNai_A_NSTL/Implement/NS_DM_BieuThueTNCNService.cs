namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_BieuThueTNCNService : BaseService<NS_DM_BieuThueTNCN, INS_DM_BieuThueTNCNRepository>
    , INS_DM_BieuThueTNCNService
    {
    private readonly INS_DM_BieuThueTNCNRepository _NS_DM_BieuThueTNCNRepository;
    public NS_DM_BieuThueTNCNService(INS_DM_BieuThueTNCNRepository NS_DM_BieuThueTNCNRepository) : base(NS_DM_BieuThueTNCNRepository)
    {
    _NS_DM_BieuThueTNCNRepository = NS_DM_BieuThueTNCNRepository;
    }
    }
    }

