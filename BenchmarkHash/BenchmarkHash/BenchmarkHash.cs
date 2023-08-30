using BenchmarkDotNet.Attributes;
using Blake2Fast;
using Grassfed.MurmurHash3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkHash
{
    [MemoryDiagnoser]
    public class BenchmarkHash
    {
        private int dataLength = 25 * 1024 * 1024;
        private byte[] data;
        Random rand = new Random();
        private MurmurHash3 murmur;

        [GlobalSetup]
        public void Setup()
        {
            data = new byte[dataLength];
            rand.NextBytes(data);

            murmur = new MurmurHash3();
        }

        [Benchmark]
        public void HashMD5()
        {
            var bytes = MD5.HashData(data);
            var hash = Convert.ToBase64String(bytes);
        }

        [Benchmark]
        public void HashSHA256()
        {
            var bytes = SHA256.HashData(data);
            var hash = Convert.ToBase64String(bytes);
        }

        [Benchmark]
        public void HashSHA384()
        {
            var bytes = SHA384.HashData(data);
            var hash = Convert.ToBase64String(bytes);
        }

        [Benchmark]
        public void HashSHA512()
        {
            var bytes = SHA512.HashData(data);
            var hash = Convert.ToBase64String(bytes);
        }

        [Benchmark]
        public void HashFastHash32()
        {
            var hashResult = FastHash.HashGenerator.GenerateHash32(new ReadOnlySpan<byte>(data));
            var hash = Convert.ToBase64String(hashResult.AsSpan());
            //Or
            hashResult.AsUInt32();
        }

        [Benchmark]
        public void HashFastHash64()
        {
            var hashResult = FastHash.HashGenerator.GenerateHash64(new ReadOnlySpan<byte>(data));
            var hash = Convert.ToBase64String(hashResult.AsSpan());
            // Or
            //hashResult.AsUInt64();
        }

        [Benchmark]
        public void HashFastHash128()
        {
            var hashResult = FastHash.HashGenerator.GenerateHash128(new ReadOnlySpan<byte>(data));
            var hash = Convert.ToBase64String(hashResult.AsSpan());
        }

        [Benchmark]
        public void HashMurMur()
        {
            var bytes = murmur.ComputeHash(data);
            var hash = Convert.ToBase64String(bytes);
        }

        [Benchmark]
        public void HashBlake32()
        {
            var bytes = Blake2b.ComputeHash(4, data);
            var hash = Convert.ToBase64String(bytes);
        }

        [Benchmark]
        public void HashBlake64()
        {
            var bytes = Blake2b.ComputeHash(8, data);
            var hash = Convert.ToBase64String(bytes);
        }

        [Benchmark]
        public void HashBlake128()
        {
            var bytes = Blake2b.ComputeHash(16, data);
            var hash = Convert.ToBase64String(bytes);
        }

        [Benchmark]
        public void HashBlake256()
        {
            var bytes = Blake2b.ComputeHash(32, data);
            var hash = Convert.ToBase64String(bytes);
        }
    }
}
