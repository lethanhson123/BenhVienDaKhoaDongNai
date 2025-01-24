namespace Service_eHospital_DongNai_A.Implement
{
    public class VTB_NAPRUTTIENService : BaseService<VTB_NAPRUTTIEN, IVTB_NAPRUTTIENRepository>
    , IVTB_NAPRUTTIENService
    {
    private readonly IVTB_NAPRUTTIENRepository _VTB_NAPRUTTIENRepository;
    public VTB_NAPRUTTIENService(IVTB_NAPRUTTIENRepository VTB_NAPRUTTIENRepository) : base(VTB_NAPRUTTIENRepository)
    {
    _VTB_NAPRUTTIENRepository = VTB_NAPRUTTIENRepository;
    }
    }
    }

