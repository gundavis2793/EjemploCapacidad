using System;
using System.Collections.Generic;
using System.Text;

namespace App_Utb
{
    public interface IFileHelper
    {
        void UnSuscribeTopic(string tema);
        void SuscribeTopic(string tema);
        void DownloadFile(string url, string folder);
        event EventHandler<DownloadEventArgs> OnFileDownloaded;
        string GetLocalFilePath(string fileName);
        string GetDirectory(string folder);
    }
    public class DownloadEventArgs : EventArgs
    {
        public bool FileSaved = false;
        public DownloadEventArgs(bool fileSaved)
        {
            FileSaved = fileSaved;
        }
    }
}
