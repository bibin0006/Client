using System;
using System.Text;
using System.Security.Cryptography;

namespace clients.Enumerable
{
    class CriptoUtil
    {
        
            public static string HashData(string data)
	        {
	            var hasher = SHA256.Create();
	            var hashed_data = hasher.ComputeHash(
	                Encoding.Unicode.GetBytes(data));
	 
	            // Now we'll make it into a hexadecimal string for saving
	            var sb = new StringBuilder(hashed_data.Length * 2);
	            foreach (byte b in hashed_data)
	            {
	                sb.AppendFormat("{0:x2}", b );
	            }
	            return sb.ToString();
	        }

            public static string HashLogin(string user_name, string password)
	        {
	            // Use the first 4 letters of the userName for a salt
	            return HashData(String.Format("{0}{1}", user_name.Substring(0, 4), password));
	        }

            public static bool IsValidPassword(string user_name, string password, string hashed_password_from_db)
	        {
	            return (String.Compare( hashed_password_from_db, HashLogin(user_name, password)) == 0);
	        }
	 
	       
	    }
	}



    

