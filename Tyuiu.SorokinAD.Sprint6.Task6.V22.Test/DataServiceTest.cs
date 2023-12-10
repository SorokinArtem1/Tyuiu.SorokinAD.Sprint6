using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinAD.Sprint6.Task6.V22.Lib;
using System.IO;

namespace Tyuiu.SorokinAD.Sprint6.Task6.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CollectTextFromFile()
        {
            string str = "";
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask6V22.txt";
            string wait = $"MLgyapd\nkEPQzl\nIOuDWll\nTMRyztkPxzEVkcarVMlQ\nunwTmf";
            string res = ds.CollectTextFromFile(str,path);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CheckFile()
        {
            string path = @"C:\DataSprint6\InPutFileTask6V22.txt";
            FileInfo file = new FileInfo(path);
            bool exists = file.Exists;
            Assert.AreEqual(true, exists);
        }
    }
}
