using dplab_3;
using System;

class Program
{
    static void Main(string[] args)
    {
        EncryptionContext encryptionContext = new EncryptionContext();
        FileEncryptionService fileService = new FileEncryptionService(encryptionContext);

        Console.WriteLine("Select an encryption algorithm:");
        Console.WriteLine("1. AES");
        Console.WriteLine("2. DES");
        Console.WriteLine("3. Caesar Cipher");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                encryptionContext.SetEncryptionStrategy(new AesEncryptionStrategy());
                break;
            case 2:
                encryptionContext.SetEncryptionStrategy(new DesEncryptionStrategy());
                break;
            case 3:
                Console.Write("Enter shift value for Caesar Cipher: ");
                int shift = int.Parse(Console.ReadLine());
                encryptionContext.SetEncryptionStrategy(new CaesarCipherEncryptionStrategy(shift));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        Console.Write("Enter the file path to encrypt: ");
        string inputFilePath = Console.ReadLine();
        Console.Write("Enter the output file path for encrypted data: ");
        string encryptedFilePath = Console.ReadLine();

        fileService.EncryptFile(inputFilePath, encryptedFilePath);
        Console.WriteLine($"File encrypted and saved to {encryptedFilePath}");

        Console.Write("Enter the file path to decrypt: ");
        string decryptFilePath = Console.ReadLine();
        Console.Write("Enter the output file path for decrypted data: ");
        string outputFilePath = Console.ReadLine();

        fileService.DecryptFile(decryptFilePath, outputFilePath);
        Console.WriteLine($"File decrypted and saved to {outputFilePath}");
    }
}
