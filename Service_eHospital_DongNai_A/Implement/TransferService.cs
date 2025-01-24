namespace Service_eHospital_DongNai_A.Implement
{
    public class TransferService : BaseService<Transfer, ITransferRepository>
    , ITransferService
    {
    private readonly ITransferRepository _TransferRepository;
    public TransferService(ITransferRepository TransferRepository) : base(TransferRepository)
    {
    _TransferRepository = TransferRepository;
    }
    }
    }

