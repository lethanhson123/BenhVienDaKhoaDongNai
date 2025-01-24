namespace Service_eHospital_DongNai_A.Implement
{
    public class Sync_KeyOffline_full_04032017Service : BaseService<Sync_KeyOffline_full_04032017, ISync_KeyOffline_full_04032017Repository>
    , ISync_KeyOffline_full_04032017Service
    {
    private readonly ISync_KeyOffline_full_04032017Repository _Sync_KeyOffline_full_04032017Repository;
    public Sync_KeyOffline_full_04032017Service(ISync_KeyOffline_full_04032017Repository Sync_KeyOffline_full_04032017Repository) : base(Sync_KeyOffline_full_04032017Repository)
    {
    _Sync_KeyOffline_full_04032017Repository = Sync_KeyOffline_full_04032017Repository;
    }
    }
    }

