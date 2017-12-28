# hashing.cs

C# based data hasher.
Outputs are expected to match that with PHP, MySQL and SQL Server.

It currently supports

 * MD5
 * Base64
 * SHA256
 * SHA512


## Examples

### MD5

	hasher h = new hasher();
	string hash = h.md5("A quick brown fox jumps over the lazy dog.");


### Base64 Encode, Decode

	hasher h = new hasher();
	string hash = h.base64_encode("A quick brown fox jumps over the lazy dog.");

	hasher h = new hasher();
	string original = h.base64_decode("QSBxdWljayBicm93biBmb3gganVtcHMgb3ZlciB0aGUgbGF6eSBkb2cu");


### SHA512

	hasher h = new hasher();
	string hash = h.sha256("A quick brown fox jumps over the lazy dog.");
	string hash = h.sha256ascii("A quick brown fox jumps over the lazy dog.");


### SHA512

	hasher h = new hasher();
	string hash = h.sha512("A quick brown fox jumps over the lazy dog.");
	string hash = h.sha512ascii("A quick brown fox jumps over the lazy dog.");
