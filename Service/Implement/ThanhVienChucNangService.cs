namespace Service.Implement
{
    public class ThanhVienChucNangService : BaseService<ThanhVienChucNang, IThanhVienChucNangRepository>
    , IThanhVienChucNangService
    {
        private readonly IThanhVienChucNangRepository _ThanhVienChucNangRepository;
        public ThanhVienChucNangService(IThanhVienChucNangRepository ThanhVienChucNangRepository) : base(ThanhVienChucNangRepository)
        {
            _ThanhVienChucNangRepository = ThanhVienChucNangRepository;
        }
        public virtual async Task<List<ThanhVienChucNang>> GetSQLByParentIDToListAsync(long ParentID)
        {
            List<ThanhVienChucNang> result = new List<ThanhVienChucNang>();
            SqlParameter[] parameters =
            {
                    new SqlParameter("@ParentID",ParentID),
            };
            result = await GetByStoredProcedureToListAsync("sp_ThanhVienChucNangSelectItemsByParentID", parameters);
            return result;
        }
    }
}

