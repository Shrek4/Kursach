using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using WpfShrek.some_support;

namespace WpfShrek_Testing
{
    class Files_Test
    {
        string direct = Directory.GetCurrentDirectory();
        [SetUp]
        public void Setup()
        {
            
        }
        [Test]
        public void RightTxtParsing()
        {
            if(Files.ParseFromDirectory(direct+@"\Result v5.txt")==Cryptograph_Test.inptxt) Assert.Pass();
        }
        [Test]
        public void RightWordParsing()
        {
            if (Files.ParseFromDirectory(direct + @"\Result v5.docx") == Cryptograph_Test.inpword) Assert.Pass();
        }
        [Test]
        public void RightSaving()
        {
            Files.SaveToDirectory(Cryptograph_Test.outpword, direct + @"\test.docx");
            if (Files.ParseFromDirectory(direct + @"\test.docx") == Cryptograph_Test.outpword) Assert.Pass();
        }
    }
}
