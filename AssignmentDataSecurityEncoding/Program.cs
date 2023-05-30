// See https://aka.ms/new-console-template for more information

using AssignmentDataSecurityEncoding;


Console.WriteLine("/n ===== Task 1 - User Input ======= /n ");
Console.WriteLine("What is Your name");
string inputStr = Console.ReadLine();


BinaryConverter  binary= new BinaryConverter();
string binaryData = binary.StringToBinary(inputStr);
binary.BinaryToString(binaryData);