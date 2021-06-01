using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        //verilen passworde göre hash ve salt değerlerini oluşturuyo
        public static void CreatePasswordHash(string password,out byte[] passwordHash , out byte[] passwordSalt)
        {
            using (var hmac= new System.Security.Cryptography.HMACSHA512())
            {
                //her kullanıcı için bi key oluşturur
                passwordSalt = hmac.Key;
                //passwordun byte değerini aldık encoding ile başlayan kısımda
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
        public static bool VerifyPasswordHash(string password,  byte[] passwordHash,  byte[] passwordSalt)
        {
            //girilen passwordun hash değerinin dbdeki değerle eşleşip eşleşmediğini kontrol ediyor
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i]!=passwordHash[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
