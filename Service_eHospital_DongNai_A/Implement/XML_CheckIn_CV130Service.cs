namespace Service_eHospital_DongNai_A.Implement
{
    public class XML_CheckIn_CV130Service : BaseService<XML_CheckIn_CV130, IXML_CheckIn_CV130Repository>
    , IXML_CheckIn_CV130Service
    {
    private readonly IXML_CheckIn_CV130Repository _XML_CheckIn_CV130Repository;
    public XML_CheckIn_CV130Service(IXML_CheckIn_CV130Repository XML_CheckIn_CV130Repository) : base(XML_CheckIn_CV130Repository)
    {
    _XML_CheckIn_CV130Repository = XML_CheckIn_CV130Repository;
    }
    }
    }

