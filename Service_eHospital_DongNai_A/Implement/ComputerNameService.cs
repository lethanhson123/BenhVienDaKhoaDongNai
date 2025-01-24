namespace Service_eHospital_DongNai_A.Implement
{
    public class ComputerNameService : BaseService<ComputerName, IComputerNameRepository>
    , IComputerNameService
    {
    private readonly IComputerNameRepository _ComputerNameRepository;
    public ComputerNameService(IComputerNameRepository ComputerNameRepository) : base(ComputerNameRepository)
    {
    _ComputerNameRepository = ComputerNameRepository;
    }
    }
    }

