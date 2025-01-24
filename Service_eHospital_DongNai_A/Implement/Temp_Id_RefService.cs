namespace Service_eHospital_DongNai_A.Implement
{
    public class Temp_Id_RefService : BaseService<Temp_Id_Ref, ITemp_Id_RefRepository>
    , ITemp_Id_RefService
    {
    private readonly ITemp_Id_RefRepository _Temp_Id_RefRepository;
    public Temp_Id_RefService(ITemp_Id_RefRepository Temp_Id_RefRepository) : base(Temp_Id_RefRepository)
    {
    _Temp_Id_RefRepository = Temp_Id_RefRepository;
    }
    }
    }

