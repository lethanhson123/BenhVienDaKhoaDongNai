namespace Service_eHospital_DongNai_A.Implement
{
    public class BENHNHAN_IMAGESService : BaseService<BENHNHAN_IMAGES, IBENHNHAN_IMAGESRepository>
    , IBENHNHAN_IMAGESService
    {
    private readonly IBENHNHAN_IMAGESRepository _BENHNHAN_IMAGESRepository;
    public BENHNHAN_IMAGESService(IBENHNHAN_IMAGESRepository BENHNHAN_IMAGESRepository) : base(BENHNHAN_IMAGESRepository)
    {
    _BENHNHAN_IMAGESRepository = BENHNHAN_IMAGESRepository;
    }
    }
    }

