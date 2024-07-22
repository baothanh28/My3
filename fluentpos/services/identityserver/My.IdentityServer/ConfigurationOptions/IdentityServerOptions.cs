using CryptographyHelper.Certificates;

namespace My.IdentityServer.ConfigurationOptions
{
    public class IdentityServerOptions : IdentityServer4.Configuration.IdentityServerOptions
    {
        public CertificateOption Certificate { get; set; }
    }
}
