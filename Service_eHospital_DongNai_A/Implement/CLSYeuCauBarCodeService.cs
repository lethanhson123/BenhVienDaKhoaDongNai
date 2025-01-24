namespace Service_eHospital_DongNai_A.Implement
{
    public class CLSYeuCauBarCodeService : BaseService<CLSYeuCauBarCode, ICLSYeuCauBarCodeRepository>
    , ICLSYeuCauBarCodeService
    {
    private readonly ICLSYeuCauBarCodeRepository _CLSYeuCauBarCodeRepository;
    public CLSYeuCauBarCodeService(ICLSYeuCauBarCodeRepository CLSYeuCauBarCodeRepository) : base(CLSYeuCauBarCodeRepository)
    {
    _CLSYeuCauBarCodeRepository = CLSYeuCauBarCodeRepository;
    }
    }
    }

