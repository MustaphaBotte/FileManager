using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using ICSharpCode;
using ICSharpCode.SharpZipLib.Zip;
using System.Security.Cryptography;
using System.Data.SqlTypes;

namespace FileManager.Packages
{
    public class FileCompressor
    {

        public static long[] GetFilesSize(string[] FilesPath)
        {
            long[] sizes = new long[FilesPath.Length];
            try
            {
                for(int i= 0;i< FilesPath.Length;i++)
                {
                    using (FileStream fileStream = new FileStream(FilesPath[i], FileMode.Open))
                    {
                        sizes[i] += fileStream.Length;
                    }
                }
            }
            catch
            {             
            }
            return sizes;
        }
        public static long TotalFilesSize(string[] FilesPath)
        {
            long TotlaBytes = 0;
            try
            {              
                foreach (string filepath in FilesPath)
                {
                    using (FileStream fileStream = new FileStream(filepath, FileMode.Open))
                    {
                        TotlaBytes += fileStream.Length;
                    }
                }
            }
            catch
            {
                return 0;
            }
            return TotlaBytes;
        }
        private static FileStream? CreateFileInSafeMode(string FilePath)
        {
            try
            {
                string? directory = Path.GetDirectoryName(FilePath);
                bool FileExists = false;
                if(directory!=null)
                {
                    string[]Files = Directory.GetFiles(directory);
                    foreach (string file in Files)
                    {
                        if (file == FilePath)
                        {
                            FileExists = true;
                            int trials = 1;
                            string TempFileName = file;
                            while(File.Exists(TempFileName))
                            {
                                TempFileName= FilePath.Replace(".zip", "")+" (Copy"+trials+").zip";
                                trials++;
                            }
                            return File.Create(TempFileName);                        
                        }
                    }
                    if(!FileExists)
                    {
                        return File.Create(FilePath);
                    }
                }
            }
            catch
            {
                return null;
            }
            return null;
        }
        public static void CompressFilesIntoZip(string[]FilesPath ,string OutPutDirectory,string ZipFileName,int level,Action<decimal> CallBack)
        {
            string DirectoryShortNAme = Directory.CreateDirectory(OutPutDirectory).Name;
            string FinalOutputDirectory = OutPutDirectory+ @"\"+ DirectoryShortNAme;
            Directory.CreateDirectory(FinalOutputDirectory);

            FileStream? ZipfileStream = CreateFileInSafeMode(FinalOutputDirectory+ @"\" + ZipFileName);
            if(ZipfileStream==null)
            {
                throw new Exception("Wrong file path or must have permissions");
            }
            if(level<0 || level>9)
            {
                throw new Exception("Invalid level");
            }
            long TotalSize = TotalFilesSize(FilesPath);
            decimal progress = 0;
            using (ZipOutputStream outputStream = new ZipOutputStream(ZipfileStream))
            {
                outputStream.SetLevel(level);
               
                foreach (string filepath in FilesPath)
                {
                    using (FileStream fileStream = new FileStream(filepath, FileMode.Open))
                    {
                        ZipEntry zipEntry = new ZipEntry(Path.GetFileName(filepath));
                        zipEntry.Size = fileStream.Length;
                        outputStream.PutNextEntry(zipEntry);
                        fileStream.CopyTo(outputStream);
                        progress += ((decimal)fileStream.Length/TotalSize)*100; 
                    }
                    CallBack?.Invoke(progress);
                }
                outputStream.IsStreamOwner = true;
            }
        }

        public static void CompressFoldersIntoZip(string[] FoldersPath, string OutPutDirectory, string ZipFileName,
            int level, Action<long> CallBack = null)
        {
            string DirectoryShortNAme = Directory.CreateDirectory(OutPutDirectory).Name;
            string FinalOutputDirectory = OutPutDirectory + @"\" + DirectoryShortNAme;
            if (DirectoryShortNAme== Directory.CreateDirectory(OutPutDirectory).Root.Name)
            {
                FinalOutputDirectory = OutPutDirectory;
            }
            Directory.CreateDirectory(FinalOutputDirectory);

            FileStream? ZipfileStream = CreateFileInSafeMode(FinalOutputDirectory + @"\" + ZipFileName);
            if (ZipfileStream == null)
            {
                throw new Exception("Wrong file path or must have permissions");
            }
            if (level < 0 || level > 9)
            {
                throw new Exception("Invalid level");
            }
            using (ZipOutputStream outputStream = new ZipOutputStream(ZipfileStream))
            {
                outputStream.SetLevel(level);
                long progress = 0;
                foreach (string path in FoldersPath)
                {
                    string[] Directories = Directory.GetDirectories(path);
                    string[] files = Directory.GetFiles(path,"*",searchOption:SearchOption.AllDirectories);
                    foreach (string file in files)
                    {
                       using (FileStream fileStream = new FileStream(file, FileMode.Open))
                       {
                                ZipEntry zipEntry = new ZipEntry(Path.Combine(path, fileStream.Name));
                                zipEntry.Size = fileStream.Length;
                                outputStream.PutNextEntry(zipEntry);
                                fileStream.CopyTo(outputStream);
                                progress += fileStream.Length;
                                CallBack?.Invoke(progress);
                        }
                    }                                           
                }
                outputStream.IsStreamOwner = true;
            }
        }



    }
}
