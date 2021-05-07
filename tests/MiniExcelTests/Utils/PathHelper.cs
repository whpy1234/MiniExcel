﻿/**
 This Class Modified from ExcelDataReader : https://github.com/ExcelDataReader/ExcelDataReader
 **/
namespace MiniExcelLibs.Tests.Utils
{
    using System;
    using System.IO;

    internal static class PathHelper
    {
        public static string GetSamplePath(string fileName)
        {
            return $@"../../../../../samples/{fileName}";
        }

        public static string GetNewTemplateFilePath(string extension = "xlsx") 
        {
            var method = (new System.Diagnostics.StackTrace()).GetFrame(1).GetMethod();

            var path = Path.Combine(Path.GetTempPath(), $"{method.DeclaringType.Name}_{method.Name}.{extension}");
            if (File.Exists(path))
                File.Delete(path);
            return path;
        } 
    }
}
