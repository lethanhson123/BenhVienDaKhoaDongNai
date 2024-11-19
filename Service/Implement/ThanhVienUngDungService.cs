namespace Service.Implement
{
    public class ThanhVienUngDungService : BaseService<ThanhVienUngDung, IThanhVienUngDungRepository>
    , IThanhVienUngDungService
    {
        private readonly IThanhVienUngDungRepository _ThanhVienUngDungRepository;
        public ThanhVienUngDungService(IThanhVienUngDungRepository ThanhVienUngDungRepository) : base(ThanhVienUngDungRepository)
        {
            _ThanhVienUngDungRepository = ThanhVienUngDungRepository;
        }
        public virtual async Task<List<ThanhVienUngDung>> GetSQLByParentIDToListAsync(long ParentID)
        {
            List<ThanhVienUngDung> result = new List<ThanhVienUngDung>();
            SqlParameter[] parameters =
            {
                    new SqlParameter("@ParentID",ParentID),
            };
            result = await GetByStoredProcedureToListAsync("sp_ThanhVienUngDungSelectItemsByParentID", parameters);
            return result;
        }
    }
}

