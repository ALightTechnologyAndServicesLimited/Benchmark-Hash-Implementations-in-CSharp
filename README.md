# Benchmark-Hash-Implementations-in-CSharp

Associated blog post - [BenchmarkDotNet with hash implementation in C#](https://www.alightservices.com/2023/08/30/benchmarkdotnet-with-hash-implementation-in-c/)

This code repository shows usage of [BenchmarkDotNet](https://github.com/dotnet/BenchmarkDotNet) and benchmarks some .Net based hash libraries.

The following libraries/implementations were benchmarked:

[SHA256](https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.sha256?view=net-7.0)

[SHA384](https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.sha384?view=net-7.0)

[SHA512](https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.sha512?view=net-7.0)

[FastHash](https://github.com/hpeebles/FastHash)

[MurmurHash3](https://github.com/judwhite/Grassfed.MurmurHash3)

[Blake2](https://github.com/saucecontrol/Blake2Fast)

Here are the results:

32 Bytes: 

![32 Bytes](https://raw.githubusercontent.com/ALightTechnologyAndServicesLimited/Benchmark-Hash-Implementations-in-CSharp/main/32bytes.png "32 Bytes")

I did not want all the implementations, I commented some code and ran few more benchmarks with varying data sizes.

25 KB: 

![25 KB](https://raw.githubusercontent.com/ALightTechnologyAndServicesLimited/Benchmark-Hash-Implementations-in-CSharp/main/25kb.png "25 KB")

5MB: 

![5 MB](https://raw.githubusercontent.com/ALightTechnologyAndServicesLimited/Benchmark-Hash-Implementations-in-CSharp/main/5mb.png "5 MB")

25MB: 

![25 MB](https://raw.githubusercontent.com/ALightTechnologyAndServicesLimited/Benchmark-Hash-Implementations-in-CSharp/main/25mb.png "25 MB")



### Conclusion:
For non-cryptographic 128 bit hashes use Murmur3.

### Personal Links:
[Facebook - Kanti Arumilli](https://www.facebook.com/kanti.arumilli)

[LinkedIn - Kanti Kalyan Arumilli](https://www.linkedin.com/in/kanti-kalyan-arumilli/)

[Twitter](https://twitter.com/KantiKalyanA/)

[Thread](https://www.threads.net/@kantiarumilli)

[Youtube](https://www.youtube.com/@kantikalyanarumilli)

+91-789-362-6688, +1-480-347-6849, +44-3333-03-1284, +44-07718-273-964

### Startup Links:
[ALight Technology And Services Limited](https://www.alightservices.com/)

[Facebook](https://www.facebook.com/ALightTechnologyAndServicesLimited/)

[LinkedIn](https://www.linkedin.com/company/alight-technology-and-services-limited/)

[Youtube](https://www.youtube.com/@alighttechnologyandservicesltd)
