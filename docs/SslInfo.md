# SslInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**ValidCertificate** | **bool?** | ssl certificate validity<br>indicates whether the ssl certificate detected on a website is not expired, suspended, revoked or invalid |[optional]|
**CertificateIssuer** | **string** | ssl certificate authority<br>the entity that issued the detected ssl certificate |[optional]|
**CertificateSubject** | **string** | ssl certificate subject<br>the entity associated with the public key |[optional]|
**CertificateVersion** | **string** | ssl certificate version<br>indicates the version of X.509 used by an ssl certificate |[optional]|
**CertificateHash** | **string** | ssl certificate hash<br>the version of the ssl certificate’s hash function |[optional]|
**CertificateExpirationDate** | **string** | ssl certificate expiration date<br>the date and time when the ssl certificate expires<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|