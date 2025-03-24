namespace Service_eHospital_DongNai_A.Implement
{
    public class KhamBenh_VaoVien_SanKhoaService : BaseService<KhamBenh_VaoVien_SanKhoa, IKhamBenh_VaoVien_SanKhoaRepository>
    , IKhamBenh_VaoVien_SanKhoaService
    {
        private readonly IKhamBenh_VaoVien_SanKhoaRepository _KhamBenh_VaoVien_SanKhoaRepository;
        public KhamBenh_VaoVien_SanKhoaService(IKhamBenh_VaoVien_SanKhoaRepository KhamBenh_VaoVien_SanKhoaRepository) : base(KhamBenh_VaoVien_SanKhoaRepository)
        {
            _KhamBenh_VaoVien_SanKhoaRepository = KhamBenh_VaoVien_SanKhoaRepository;
        }
        public virtual async Task<List<KhamBenh_VaoVien_SanKhoa>> GetByListIDToListAsync(List<int?> ListID)
        {
            List<KhamBenh_VaoVien_SanKhoa> result = new List<KhamBenh_VaoVien_SanKhoa>();
            if (ListID.Count > 0)
            {
                result = await GetByCondition(item => EF.Constant(ListID).Contains(item.KhamBenhVaoVien_Id.Value)).ToListAsync();
            }
            if (result == null)
            {
                result = new List<KhamBenh_VaoVien_SanKhoa>();
            }
            return result;
        }
    }
}

