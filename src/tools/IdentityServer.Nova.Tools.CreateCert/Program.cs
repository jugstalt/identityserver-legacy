﻿using Cocona;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;


CoconaApp.Run((string name = "client", string password = "", string cn = "client") =>
{

    string path = Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location)!;
    int expireDays = 365;

    var ecdsa = RSA.Create(); // generate asymmetric key pair
    var req = new CertificateRequest($"cn={cn}", ecdsa, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
    var cert = req.CreateSelfSigned(DateTimeOffset.Now, DateTimeOffset.Now.AddYears(expireDays));


    File.WriteAllBytes($@"{path}\{name}.pfx", cert.Export(X509ContentType.Pfx, password));
    //File.WriteAllBytes($@"{ path }\{ name }.pkcs12", cert.Export(X509ContentType.Pkcs12, password));

    // Create Base 64 encoded CER (public key only)
    File.WriteAllText($@"{path}\{name}.crt",
        "-----BEGIN CERTIFICATE-----\r\n"
    + Convert.ToBase64String(cert.Export(X509ContentType.Cert), Base64FormattingOptions.InsertLineBreaks)
    + "\r\n-----END CERTIFICATE-----");

});
