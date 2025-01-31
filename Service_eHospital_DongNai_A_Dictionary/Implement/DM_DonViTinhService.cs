namespace Service_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_DonViTinhService : BaseService<DM_DonViTinh, IDM_DonViTinhRepository>
    , IDM_DonViTinhService
    {
    private readonly IDM_DonViTinhRepository _DM_DonViTinhRepository;
    public DM_DonViTinhService(IDM_DonViTinhRepository DM_DonViTinhRepository) : base(DM_DonViTinhRepository)
    {
    _DM_DonViTinhRepository = DM_DonViTinhRepository;
    }
    }
    }

