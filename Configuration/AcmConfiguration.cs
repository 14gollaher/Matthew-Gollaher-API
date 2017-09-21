namespace Configuration
{
    public class AcmConfiguration
    {
        public static IConfigurationRoot Configuration;

        public AcmConfiguration()
        {
            Configuration = builder.Build();
        }
        public string AcmDbConnectionString { get; set; }
    }
}
