namespace Service_eHospital_DongNai_A_Dictionary.Implement
{
    public class Lst_Dictionary_TypeService : BaseService<Lst_Dictionary_Type, ILst_Dictionary_TypeRepository>
    , ILst_Dictionary_TypeService
    {
        private readonly ILst_Dictionary_TypeRepository _Lst_Dictionary_TypeRepository;
        public Lst_Dictionary_TypeService(ILst_Dictionary_TypeRepository Lst_Dictionary_TypeRepository) : base(Lst_Dictionary_TypeRepository)
        {
            _Lst_Dictionary_TypeRepository = Lst_Dictionary_TypeRepository;
        }
        public override async Task<Lst_Dictionary_Type> SaveAsync(Lst_Dictionary_Type model)
        {
            if (model.Dictionary_Type_Id > 0)
            {
                await UpdateAsync(model);
            }
            else
            {
                await AddAsync(model);
            }
            return model;
        }
    }
}

