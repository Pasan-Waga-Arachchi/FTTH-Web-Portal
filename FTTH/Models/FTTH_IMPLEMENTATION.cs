namespace Test_FTTH_web.Models
{
    public class FTTH_IMPLEMENTATION
    {
        public int SERIALNO { get; set; }
        public string RTOM { get; set; } = string.Empty;
        public string PROVINCE { get; set; } = string.Empty;
        public string REGION { get; set; } = string.Empty;
        public string LEA { get; set; } = string.Empty;
        public string CONTRACTOR_SURVEY { get; set; } = string.Empty;
        public string CONTRACTOR_LOI { get; set; } = string.Empty;
        public string CLUSTER_REFNO { get; set; } = string.Empty;
        public string CLUSTER_NAME { get; set; } = string.Empty;
        public string CABINET_NAME { get; set; } = string.Empty;
        public string CABINET_NO { get; set; } = string.Empty;
        public int NO_FINALIZED_FDP { get; set; }
        public int NO_FINALIZED_STUMPS { get; set; }
        public DateTime? LOI_DATE { get; set; }
        public string MATRLAVLB_PONPRIMARY { get; set; } = string.Empty;
        public string MATRLAVLB_PONENHACMNT { get; set; } = string.Empty;
        public string INSTALTN_ODF { get; set; } = string.Empty;
        public string INSTALTN_PON_PRIMARY { get; set; } = string.Empty;
        public string INSTALTN_PON_SECND { get; set; } = string.Empty;
        public string INSTALTN_FTC { get; set; } = string.Empty;
        public string ODF_CONNECTED_FTC { get; set; } = string.Empty;
        public string PRIMARY_TRMNTD_CABINET { get; set; } = string.Empty;
        public string REQST_LIVEJOINT { get; set; } = string.Empty;
        public DateTime? REQST_LIVEJOINT_DATE { get; set; }
        public string LIVEJOINT_SPLICED { get; set; } = string.Empty;
        public DateTime? LIVEJOINT_SPLICED_DATE { get; set; }
        public string CONNECT_GPON_NW { get; set; } = string.Empty;
        public string PAT_FOR_FTC { get; set; } = string.Empty;
        public DateTime? PAT_FOR_FTC_DATE { get; set; }
        public string PATCMPLTD_PONPRMRY { get; set; } = string.Empty;
        public DateTime? PATCMPLTD_PONPRMRY_DATE { get; set; }
        public string PATCMPLTD_PONSECND { get; set; } = string.Empty;
        public DateTime? PATCMPLTD_PONSECND_DATE { get; set; }
        public DateTime? EXPECTED_COMSN_DATE { get; set; }
        public string DELAY_MHCA { get; set; } = string.Empty;
        public string DELAY_DUCTBLOCK { get; set; } = string.Empty;
        public string DELAY_RAISERBLOCK { get; set; } = string.Empty;
        public string DELAY_PERMISSIONISSUE { get; set; } = string.Empty;
        public string DELAY_MATERIALISSUE { get; set; } = string.Empty;
        public string DELAY_NA { get; set; } = string.Empty;
        public string OVERALL_COMMENTS { get; set; } = string.Empty;
        public string LAST_UPDATE_USER { get; set; } = string.Empty;
        public DateTime? LAST_UPDATE_DATETIME { get; set; }
        public string ADD_USER { get; set; } = string.Empty;
        public DateTime? ADD_DATETIME { get; set; }
        public string IMPLEMENTATION_STG { get; set; } = string.Empty;
        public string SITE_STATUS { get; set; } = string.Empty;
        public string BOQ_TYPE { get; set; } = string.Empty;
        public string CATEGORY { get; set; } = string.Empty;
        public DateTime? NOTICE_DATE { get; set; }
        public string PAT_READY { get; set; } = string.Empty;
        public DateTime? PAT_READY_DATE { get; set; }
        public DateTime? PAT_READY_TDATE { get; set; }
        public DateTime? EXPECTED_COMSN_TD { get; set; }
        public DateTime? SITE_STATUS_TD { get; set; }
        public string PLANNING_REF_NO { get; set; } = string.Empty;
        public string ZONE { get; set; } = string.Empty;
    }
}
