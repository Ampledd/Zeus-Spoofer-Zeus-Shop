using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Auth.GG_Winform_Example
{
	// Token: 0x0200000D RID: 13
	internal class Encryption
	{
		// Token: 0x0600005C RID: 92 RVA: 0x000045A0 File Offset: 0x000027A0
		public static string APIService(string value)
		{
			string @string = Encoding.Default.GetString(Convert.FromBase64String(Constants.APIENCRYPTKEY));
			SHA256 sha = SHA256.Create();
			byte[] key = sha.ComputeHash(Encoding.ASCII.GetBytes(@string));
			byte[] bytes = Encoding.ASCII.GetBytes(Encoding.Default.GetString(Convert.FromBase64String(Constants.APIENCRYPTSALT)));
			return Encryption.EncryptString(value, key, bytes);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00004610 File Offset: 0x00002810
		public static string EncryptService(string value)
		{
			string @string = Encoding.Default.GetString(Convert.FromBase64String(Constants.APIENCRYPTKEY));
			SHA256 sha = SHA256.Create();
			byte[] key = sha.ComputeHash(Encoding.ASCII.GetBytes(@string));
			byte[] bytes = Encoding.ASCII.GetBytes(Encoding.Default.GetString(Convert.FromBase64String(Constants.APIENCRYPTSALT)));
			string str = Encryption.EncryptString(value, key, bytes);
			int length = int.Parse(OnProgramStart.AID.Substring(0, 2));
			return str + Security.Obfuscate(length);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000046A4 File Offset: 0x000028A4
		public static string DecryptService(string value)
		{
			string @string = Encoding.Default.GetString(Convert.FromBase64String(Constants.APIENCRYPTKEY));
			SHA256 sha = SHA256.Create();
			byte[] key = sha.ComputeHash(Encoding.ASCII.GetBytes(@string));
			byte[] bytes = Encoding.ASCII.GetBytes(Encoding.Default.GetString(Convert.FromBase64String(Constants.APIENCRYPTSALT)));
			return Encryption.DecryptString(value, key, bytes);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00004714 File Offset: 0x00002914
		public static string EncryptString(string plainText, byte[] key, byte[] iv)
		{
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			aes.Key = key;
			aes.IV = iv;
			MemoryStream memoryStream = new MemoryStream();
			ICryptoTransform transform = aes.CreateEncryptor();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			byte[] bytes = Encoding.ASCII.GetBytes(plainText);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.FlushFinalBlock();
			byte[] array = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			return Convert.ToBase64String(array, 0, array.Length);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000047A4 File Offset: 0x000029A4
		public static string DecryptString(string cipherText, byte[] key, byte[] iv)
		{
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			aes.Key = key;
			aes.IV = iv;
			MemoryStream memoryStream = new MemoryStream();
			ICryptoTransform transform = aes.CreateDecryptor();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			string result = string.Empty;
			try
			{
				byte[] array = Convert.FromBase64String(cipherText);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.FlushFinalBlock();
				byte[] array2 = memoryStream.ToArray();
				result = Encoding.ASCII.GetString(array2, 0, array2.Length);
			}
			finally
			{
				memoryStream.Close();
				cryptoStream.Close();
			}
			return result;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00004854 File Offset: 0x00002A54
		public static string Decode(string text)
		{
			text = text.Replace('_', '/').Replace('-', '+');
			int num = text.Length % 4;
			int num2 = num;
			if (num2 != 2)
			{
				if (num2 == 3)
				{
					text += "=";
				}
			}
			else
			{
				text += "==";
			}
			return Encoding.UTF8.GetString(Convert.FromBase64String(text));
		}
	}
}
