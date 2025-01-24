namespace Service_eHospital_DongNai_A.Implement
{
    public class Eclaim_Header2348Service : BaseService<Eclaim_Header2348, IEclaim_Header2348Repository>
    , IEclaim_Header2348Service
    {
    private readonly IEclaim_Header2348Repository _Eclaim_Header2348Repository;
    public Eclaim_Header2348Service(IEclaim_Header2348Repository Eclaim_Header2348Repository) : base(Eclaim_Header2348Repository)
    {
    _Eclaim_Header2348Repository = Eclaim_Header2348Repository;
    }
    }
    }

