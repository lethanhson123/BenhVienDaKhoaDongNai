namespace Service_eHospital_DongNai_A.Implement
{
    public class Lst_KeyData_Backup20240805Service : BaseService<Lst_KeyData_Backup20240805, ILst_KeyData_Backup20240805Repository>
    , ILst_KeyData_Backup20240805Service
    {
    private readonly ILst_KeyData_Backup20240805Repository _Lst_KeyData_Backup20240805Repository;
    public Lst_KeyData_Backup20240805Service(ILst_KeyData_Backup20240805Repository Lst_KeyData_Backup20240805Repository) : base(Lst_KeyData_Backup20240805Repository)
    {
    _Lst_KeyData_Backup20240805Repository = Lst_KeyData_Backup20240805Repository;
    }
    }
    }

