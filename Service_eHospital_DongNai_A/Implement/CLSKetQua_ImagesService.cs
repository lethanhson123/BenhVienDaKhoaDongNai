namespace Service_eHospital_DongNai_A.Implement
{
    public class CLSKetQua_ImagesService : BaseService<CLSKetQua_Images, ICLSKetQua_ImagesRepository>
    , ICLSKetQua_ImagesService
    {
        private readonly ICLSKetQua_ImagesRepository _CLSKetQua_ImagesRepository;
        public CLSKetQua_ImagesService(ICLSKetQua_ImagesRepository CLSKetQua_ImagesRepository) : base(CLSKetQua_ImagesRepository)
        {
            _CLSKetQua_ImagesRepository = CLSKetQua_ImagesRepository;
        }
        public virtual async Task<List<CLSKetQua_Images>> GetByListIDToListAsync(List<int?> ListID)
        {
            List<CLSKetQua_Images> result = new List<CLSKetQua_Images>();
            try
            {
                if (ListID.Count > 0)
                {
                    result = await GetByCondition(item => EF.Constant(ListID).Contains(item.CLSKetQua_Id.Value)).ToListAsync();
                }
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            if (result == null)
            {
                result = new List<CLSKetQua_Images>();
            }
            return result;
        }
    }
}

