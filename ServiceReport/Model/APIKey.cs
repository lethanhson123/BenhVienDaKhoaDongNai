namespace ServiceReport.Model
{
	public class APIKey : ServiceReport.Model.BaseModel
    {
       
        public string? access_token { get; set; }
        public string? id_token { get; set; }
        public string? token_type { get; set; }
        public string? username { get; set; }
        public DateTime? expires_in { get; set; }

        public APIKey()
		{              
        }
	}
}
