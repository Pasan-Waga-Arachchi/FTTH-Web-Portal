namespace Test_FTTH_web.Models
{
    public class FTTH_RPRO_LEA_NEW
    {
        public string ZONE { get; set; }
        public string REGION { get; set; }
        public string PROVINCE { get; set; }
        public string RTOM { get; set; }
        public string RTOM_NAME { get; set; }
        public string OPMC { get; set; }
        public string MINI_OPMC { get; set; }
        public string MINI_OPMC_NAME { get; set; }
        public string LEA { get; set; }
        public string LEA_NAME { get;set; } = string.Empty;



        public FTTH_RPRO_LEA_NEW(string zone, string region, string province, string rtom, string rtomName, string opmc, string miniOpmc, string miniOpmcName, string lea)
        {
            ZONE = zone;
            REGION = region;
            PROVINCE = province;
            RTOM = rtom;
            RTOM_NAME = rtomName;
            OPMC = opmc;
            MINI_OPMC = miniOpmc;
            MINI_OPMC_NAME = miniOpmcName;
            LEA = lea;
            LEA_NAME = string.Empty; 
        }
    }
}
