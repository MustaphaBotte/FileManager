using FileManager.Ui_Interfaces;
using FileManager.Ui_Interfaces.ChunkChunkDownloader;
using FileManager.Ui_Interfaces.FileCompressor;
using FileManager.Ui_Interfaces.FileDecryptor;
using FileManager.Ui_Interfaces.PasswordGenerator;

namespace FileManager
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();

        }

        private void EncryptFilesBtn_Click(object sender, EventArgs e)
        {
            using (FilesEncryptorFrm frm = new FilesEncryptorFrm())
            {
                frm.ShowDialog();
            }
        }
        private void FileDownloaderBtn_Click(object sender, EventArgs e)
        {
            using (FilesDownloaderFrm frm = new FilesDownloaderFrm())
            {
                frm.ShowDialog();
            }
        }

        private void PasswordGeneratorBtn_Click(object sender, EventArgs e)
        {
            using (PasswordGeneratorFrm frm = new PasswordGeneratorFrm())
            {
                frm.ShowDialog();
            }
        }

        private void CompressFilesBtn_Click(object sender, EventArgs e)
        {
            using (FilesCompressorFrm frm = new FilesCompressorFrm())
            {
                frm.ShowDialog();
            }
        }

        private void DecryptFilesBtn_Click(object sender, EventArgs e)
        {
            using (FilesDecryptorFrm frm = new FilesDecryptorFrm())
            {
                frm.ShowDialog();
            }
        }

        private void ChunkChunkBtn_Click(object sender, EventArgs e)
        {
            using (ChunkChunkDownloaderFrm frm = new ChunkChunkDownloaderFrm())
            {
                frm.ShowDialog();
            }
        }
    }
}
