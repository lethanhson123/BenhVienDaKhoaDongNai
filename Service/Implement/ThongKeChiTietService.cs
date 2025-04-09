namespace Service.Implement
{
    public class ThongKeChiTietService : BaseService<ThongKeChiTiet, IThongKeChiTietRepository>
    , IThongKeChiTietService
    {
        private readonly IThongKeChiTietRepository _ThongKeChiTietRepository;
        public ThongKeChiTietService(IThongKeChiTietRepository ThongKeChiTietRepository) : base(ThongKeChiTietRepository)
        {
            _ThongKeChiTietRepository = ThongKeChiTietRepository;
        }
        public virtual async Task<List<ThongKeChiTiet>> ReportAToaThuoc_MinhToListAsync(DateTime BatDau, DateTime KetThuc, string MaDuoc)
        {
            List<ThongKeChiTiet> result = new List<ThongKeChiTiet>();
            if (!string.IsNullOrEmpty(MaDuoc))
            {
                SqlParameter[] parameters =
                             {
                            new SqlParameter("@BatDau", BatDau),
                            new SqlParameter("@KetThuc", KetThuc),
                            new SqlParameter("@MaDuoc", MaDuoc),
                             };
                result = await GetByStoredProcedureToListAsync(GlobalHelper.SQLServerConectionString_eHospital_DongNai_A, "sp_ReportAToaThuoc_Minh", parameters);
            }
            
            return result;
        }
    }
}

