using System;
using System.IO;
using System.Diagnostics;
using FlaxEngine;
using FlaxEditor;

namespace AmbientCGForFlax
{
    public static class Curl
    {
        private static string CurlPath => Path.Combine(GetAmbientCGForFlaxProjectPath(), "Curl", "curl.exe");
        private static string CachePath => Path.Combine(Editor.Instance.GameProject.ProjectFolderPath, "Cache");

        public static void DownloadToCache(string url, string outFile = "curl.out")
        {
            string outPath = Path.Combine(CachePath, outFile);
            string curlArgs = string.Format("{0} --output {1}", url, outPath);

            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = CurlPath;
            info.Arguments = curlArgs;
            info.CreateNoWindow = true;
            info.UseShellExecute = false;
            Process curl = Process.Start(info);
            curl.WaitForExit();
        }

        public static string Download(string url)
        {
            DownloadToCache(url);

            string filePath = Path.Combine(CachePath, "curl.out");
            if(!File.Exists(filePath))
                return string.Empty;

            string curlOut = File.ReadAllText(filePath);
            File.Delete(filePath);
            
            return curlOut;
        }

        private static string GetAmbientCGForFlaxProjectPath()
        {
            if(Editor.Instance.GameProject.Name == "AmbientCGForFlax")
                return Editor.Instance.GameProject.ProjectFolderPath;

            foreach(var reference in Editor.Instance.GameProject.References)
            {
                if(reference.Name == "AmbientCGForFlax")
                    return reference.Project.ProjectFolderPath;
            }

            return null;
        }
    }
}
