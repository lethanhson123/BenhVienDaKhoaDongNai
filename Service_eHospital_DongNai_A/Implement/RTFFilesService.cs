namespace Service_eHospital_DongNai_A.Implement
{
    public class RTFFilesService : BaseService<RTFFiles, IRTFFilesRepository>
    , IRTFFilesService
    {
    private readonly IRTFFilesRepository _RTFFilesRepository;
    public RTFFilesService(IRTFFilesRepository RTFFilesRepository) : base(RTFFilesRepository)
    {
    _RTFFilesRepository = RTFFilesRepository;
    }
    }
    }

