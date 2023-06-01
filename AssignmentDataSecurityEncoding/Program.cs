// See https://aka.ms/new-console-template for more information
using AssignmentDataSecurityEncoding;

Console.WriteLine("/n ===== Task 1 - User Name ======= /n ");
Console.WriteLine("What is Your name");
string nameStr = Console.ReadLine();

Console.WriteLine("/n ===== Task 2 - Binary Convertion ======= /n ");
BinaryConverter  binary= new BinaryConverter();
string binaryData = binary.StringToBinary(nameStr);
Console.WriteLine($"The convertion to Binary: {binaryData}");
binary.BinaryToString(binaryData);

Console.WriteLine("/n ===== Task 3 - hexadecimal  Convertion ======= /n ");
HexadecimalConverter hexaDec = new HexadecimalConverter();
string hexData = hexaDec.StringToHexadecimal(nameStr);
Console.WriteLine(($"The convertion to hexadecimal: {hexData}"));
hexaDec.HexadecimalToString(hexData);

Console.WriteLine("/n ===== Task 4 - Base64  Convertion ======= /n ");
Base64Converter base64 = new Base64Converter();
string base64Data = base64.StringToBase64(nameStr);
Console.WriteLine(($"The convertion to base64: {base64Data}"));
base64.Base64ToString(base64Data);

Console.WriteLine("/n ===== Task 5 - Encrypt/Decrypt ======= /n ");
EncryptDecrypt encrypt = new EncryptDecrypt();
var encryptData = encrypt.EncryptString(nameStr);
Console.WriteLine(($"The encryption of the name: {encryptData}"));
encrypt.DecryptString(encryptData.Item1, encryptData.Item2, encryptData.Item3);