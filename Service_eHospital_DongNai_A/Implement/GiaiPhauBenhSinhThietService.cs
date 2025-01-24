namespace Service_eHospital_DongNai_A.Implement
{
    public class GiaiPhauBenhSinhThietService : BaseService<GiaiPhauBenhSinhThiet, IGiaiPhauBenhSinhThietRepository>
    , IGiaiPhauBenhSinhThietService
    {
    private readonly IGiaiPhauBenhSinhThietRepository _GiaiPhauBenhSinhThietRepository;
    public GiaiPhauBenhSinhThietService(IGiaiPhauBenhSinhThietRepository GiaiPhauBenhSinhThietRepository) : base(GiaiPhauBenhSinhThietRepository)
    {
    _GiaiPhauBenhSinhThietRepository = GiaiPhauBenhSinhThietRepository;
    }
    }
    }

