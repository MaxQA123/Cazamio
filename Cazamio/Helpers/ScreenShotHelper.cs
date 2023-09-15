using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing;
using OpenQA.Selenium;
using CazamioProgect.Helpers;
using System.IO;
using System;
using System.Text;
using System.Diagnostics;
using System.Threading;
using NUnit.Framework;

namespace CazamioProject.Helpers
{
    public class ScreenShotHelper
    {
        public static string MakeScreenShot()
        {
            ITakesScreenshot ssdriver = Browser._Driver as ITakesScreenshot;
            Screenshot screenshot = ssdriver.GetScreenshot();
            string timestampPath = DateTime.Now.ToString("yyyy-MM-dd");
            string timestampName = DateTime.UtcNow.ToString("dd-MMMM-yyyy' 'HH-mm-ss");
            string path = Browser.RootPath() + "ErrorImages\\" + timestampPath + "\\";
            string name = path + "Exception-" + timestampName + ".jpeg";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            screenshot.SaveAsFile(name, ScreenshotImageFormat.Jpeg);
            WaitUntil.WaitSomeInterval(2000);
            return name;
        }
    }

    public class ForceCloseDriver
    {
        [Test]
        public static void ForceClose()
        {
            ForceCloseDriver.ForeseClose();
        }

        public static string CreateBatFile()
        {
            string path = Browser.RootPathReport() + "_!CloseOpenWith.bat";
            string forceCloseAppList = string.Format("echo off" +
                "TASKKILL /F /IM \"OpenWith.exe\"\r\n" +
                "TASKKILL /F /IM \"chromedriver.exe\"\r\n" +
                "TASKKILL /F /IM \"java.exe\"\r\n" +
                "TASKKILL /F /IM \"node.exe\"\r\n" +
                "TASKKILL /F /IM \"AppleMobileDeviceService.exe\"\r\n" +
                "TASKKILL /F /IM \"APSDaemon.exe\"\r\n" +
                "TASKKILL /F /IM \"ICloudServices.exe\"\r\n" +
                "TASKKILL /F /IM \"mDNSResponder.exe\"\r\n" +
                "TASKKILL /F /IM \"altserver.exe\"\r\n" +
                "TASKKILL /F /IM \"Screencast-O-Matic.exe\"" +
                "pause"
                );
            FileInfo fileInf = new(path);
            if (fileInf.Exists == true)
            {
                fileInf.Delete();
            }
            using StreamWriter writer = new(path, false, Encoding.UTF8);
            writer.Write(forceCloseAppList);

            return path;
        }

        public static void RemoveBatFile(string path)
        {
            FileInfo fileInf = new(path);
            if (fileInf.Exists == true)
            {
                fileInf.Delete();
            }
        }

        public static void ForeseClose()
        {
            string path = CreateBatFile();
            Process process = new();
            process.StartInfo.FileName = path;
            process.Start();
            process.Close();
            Thread.Sleep(1000);
            RemoveBatFile(path);
        }
    }
}

