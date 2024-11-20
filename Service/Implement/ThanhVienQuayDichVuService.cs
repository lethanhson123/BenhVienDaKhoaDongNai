namespace Service.Implement
{
    public class ThanhVienQuayDichVuService : BaseService<ThanhVienQuayDichVu, IThanhVienQuayDichVuRepository>
    , IThanhVienQuayDichVuService
    {
        private readonly IThanhVienQuayDichVuRepository _ThanhVienQuayDichVuRepository;
        public ThanhVienQuayDichVuService(IThanhVienQuayDichVuRepository ThanhVienQuayDichVuRepository) : base(ThanhVienQuayDichVuRepository)
        {
            _ThanhVienQuayDichVuRepository = ThanhVienQuayDichVuRepository;
        }
        public virtual async Task<List<ThanhVienQuayDichVu>> GetSQLByParentIDToListAsync(long ParentID)
        {
            List<ThanhVienQuayDichVu> result = new List<ThanhVienQuayDichVu>();
            SqlParameter[] parameters =
            {
                    new SqlParameter("@ParentID",ParentID),
            };
            result = await GetByStoredProcedureToListAsync("sp_ThanhVienQuayDichVuSelectItemsByParentID", parameters);
            return result;
        }
    }
}

