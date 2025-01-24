namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_MauBenh_ColumnService : BaseService<DM_MauBenh_Column, IDM_MauBenh_ColumnRepository>
    , IDM_MauBenh_ColumnService
    {
    private readonly IDM_MauBenh_ColumnRepository _DM_MauBenh_ColumnRepository;
    public DM_MauBenh_ColumnService(IDM_MauBenh_ColumnRepository DM_MauBenh_ColumnRepository) : base(DM_MauBenh_ColumnRepository)
    {
    _DM_MauBenh_ColumnRepository = DM_MauBenh_ColumnRepository;
    }
    }
    }

