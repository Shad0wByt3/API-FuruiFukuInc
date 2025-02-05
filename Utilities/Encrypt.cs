﻿using System;
using System.Security.Cryptography;
using System.Text;

namespace API_FuruiFukuInc.Utilities
{
    public class Encrypt
    {
        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashBytes);
            }
        }
    }
}
