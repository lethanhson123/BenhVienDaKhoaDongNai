namespace Service_eHospital_DongNai_A_Config.Implement
{
    public class Sys_List_SourceFileService : BaseService<Sys_List_SourceFile, ISys_List_SourceFileRepository>
    , ISys_List_SourceFileService
    {
    private readonly ISys_List_SourceFileRepository _Sys_List_SourceFileRepository;
    public Sys_List_SourceFileService(ISys_List_SourceFileRepository Sys_List_SourceFileRepository) : base(Sys_List_SourceFileRepository)
    {
    _Sys_List_SourceFileRepository = Sys_List_SourceFileRepository;
    }
    }
    }

