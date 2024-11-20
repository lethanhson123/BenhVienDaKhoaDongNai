namespace Service.Implement
{
    public class ThanhVienPhongKhamService : BaseService<ThanhVienPhongKham, IThanhVienPhongKhamRepository>
    , IThanhVienPhongKhamService
    {
        private readonly IThanhVienPhongKhamRepository _ThanhVienPhongKhamRepository;
        public ThanhVienPhongKhamService(IThanhVienPhongKhamRepository ThanhVienPhongKhamRepository) : base(ThanhVienPhongKhamRepository)
        {
            _ThanhVienPhongKhamRepository = ThanhVienPhongKhamRepository;
        }
        public virtual async Task<List<ThanhVienPhongKham>> GetSQLByParentIDToListAsync(long ParentID)
        {
            List<ThanhVienPhongKham> result = new List<ThanhVienPhongKham>();
            SqlParameter[] parameters =
            {
                    new SqlParameter("@ParentID",ParentID),
            };
            result = await GetByStoredProcedureToListAsync("sp_ThanhVienPhongKhamSelectItemsByParentID", parameters);
            return result;
        }
    }
}

