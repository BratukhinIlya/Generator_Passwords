using GeneratorPasswords;
using System.Globalization;

namespace TestProject3
{
    [TestClass]
    public class GeneratorPasswordTests
    {
       /// <summary>
       /*[TestMethod]
       /// </summary>
        public void SavePasswordToFile_WritesCorrectDataToFile()
        {
            // Arrange
            string password = "testPassword";
            string login = "testLogin";
            string expected = $"{login} - {password}\n";
            PassGenerator passGenerator = new PassGenerator();

            // Act
            passGenerator.SavePasswordToFile(password, login);

            // Assert
            string[] lines = File.ReadAllLines(filePath);
            Assert.AreEqual(expected, lines[0]);
        }
        public void SavePasswordToFile_ThrowsExceptionIfFileCannotBeWritten()
        {
            // Arrange
            string password = "testPassword";
            string login = "testLogin";
            string invalidFilePath = "invalidFilePath";

            // Act & Assert
            Assert.Throws<Exception>(() => SavePasswordToFile(password, login, invalidFilePath));
        }
        public void SavePasswordToFile_ReturnsImmediatelyIfUserChoosesNotToOverwriteFile()
        {
            // Arrange
            string password = "testPassword";
            string login = "testLogin";
            string existingFilePath = "existingFilePath";

            // Create a file with the same name to simulate an existing file
            File.Create(existingFilePath).Dispose();

            try
            {
                // Act
                var dialogResult = SavePasswordToFile(password, login, existingFilePath);

                // Assert
                Assert.AreEqual(DialogResult.No, dialogResult);
            }
            finally
            {
                // Clean up created file
                File.Delete(existingFilePath);
            }
        }
    }
}