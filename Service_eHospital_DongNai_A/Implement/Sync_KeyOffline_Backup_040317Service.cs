namespace Service_eHospital_DongNai_A.Implement
{
    public class Sync_KeyOffline_Backup_040317Service : BaseService<Sync_KeyOffline_Backup_040317, ISync_KeyOffline_Backup_040317Repository>
    , ISync_KeyOffline_Backup_040317Service
    {
    private readonly ISync_KeyOffline_Backup_040317Repository _Sync_KeyOffline_Backup_040317Repository;
    public Sync_KeyOffline_Backup_040317Service(ISync_KeyOffline_Backup_040317Repository Sync_KeyOffline_Backup_040317Repository) : base(Sync_KeyOffline_Backup_040317Repository)
    {
    _Sync_KeyOffline_Backup_040317Repository = Sync_KeyOffline_Backup_040317Repository;
    }
    }
    }

