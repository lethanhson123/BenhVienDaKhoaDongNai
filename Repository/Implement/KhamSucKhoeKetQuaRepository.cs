namespace Repository.Implement
{
    public class KhamSucKhoeKetQuaRepository : BaseRepository<KhamSucKhoeKetQua>
    , IKhamSucKhoeKetQuaRepository
    {
    private readonly Data.Context.Context _context;
    public KhamSucKhoeKetQuaRepository(Data.Context.Context context) : base(context)
    {
    _context = context;
    }
    }
    }

