using System;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;

namespace DataLayer {
    public static class AuthProvider {
        public enum SupportedHash {
            [Description("SHA256 Hashing Algorithm")]
            SHA256,
            [Description("SHA384 Hashing Algorithm")]
            SHA384,
            [Description("SHA512 Hashing Algorithm")]
            SHA512
        }

        public static string ComputeHash(string text, SupportedHash hashAlgorithm, byte[] salt) {
            int minSaltLength = 4;
            int maxSaltLength = 16;

            byte[] SaltBytes = null;

            if (salt != null) {
                SaltBytes = salt;
            } else {
                Random r = new Random();
                int SaltLength = r.Next(minSaltLength, maxSaltLength);
                SaltBytes = new byte[SaltLength];
                using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider()) {
                    rng.GetNonZeroBytes(SaltBytes);
                }
            }

            byte[] plainData = Encoding.UTF8.GetBytes(text);
            byte[] plainDataAndSalt = new byte[plainData.Length + SaltBytes.Length];

            for (int i = 0; i < plainData.Length; i++)
                plainDataAndSalt[i] = plainData[i];

            for (int i = 0; i < SaltBytes.Length; i++)
                plainDataAndSalt[plainData.Length + i] = SaltBytes[i];

            byte[] hashValue = null;

            switch (hashAlgorithm) {
                case SupportedHash.SHA256:
                    using (SHA256Managed sha256 = new SHA256Managed()) {
                        hashValue = sha256.ComputeHash(plainDataAndSalt);
                    }
                    break;
                case SupportedHash.SHA384:
                    using (SHA384Managed sha384 = new SHA384Managed()) {
                        hashValue = sha384.ComputeHash(plainDataAndSalt);
                    }
                    break;
                case SupportedHash.SHA512:
                    using (SHA512Managed sha512 = new SHA512Managed()) {
                        hashValue = sha512.ComputeHash(plainDataAndSalt);
                    }
                    break;
            }

            byte[] result = new byte[hashValue.Length + SaltBytes.Length];
            for (int i = 0; i < hashValue.Length; i++)
                result[i] = hashValue[i];

            for (int i = 0; i < SaltBytes.Length; i++)
                result[hashValue.Length + i] = SaltBytes[i];

            return Convert.ToBase64String(result);
        }

        public static bool Confirm(string text, string hashValue, SupportedHash hashAlgorithm) {
            byte[] hashBytes = Convert.FromBase64String(hashValue);
            int hashSize = 0;
            switch (hashAlgorithm) {
                case SupportedHash.SHA256:
                    hashSize = 32;
                    break;
                case SupportedHash.SHA384:
                    hashSize = 48;
                    break;
                case SupportedHash.SHA512:
                    hashSize = 64;
                    break;
            }

            byte[] saltBytes = new byte[hashBytes.Length - hashSize];
            for (int i = 0; i < saltBytes.Length; i++)
                saltBytes[i] = hashBytes[hashSize + i];

            string NewHash = ComputeHash(text, hashAlgorithm, saltBytes);

            return (hashValue == NewHash);
        }
    }
}