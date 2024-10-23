using System.Drawing;

namespace FotoMarcaDagua
{
    public partial class Form1 : Form
    {
        String nomeMoldura = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSrcMold_Click(object sender, EventArgs e)
        {
            var FileDialog = new OpenFileDialog();
            DialogResult result = FileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                String FilePath = FileDialog.FileName;
                String[] itens = FilePath.Split("\\");
                nomeMoldura = itens[itens.Length - 1];
                if (FilePath != null)
                {
                    txtMoldura.Text = FilePath;
                    txtMoldura.Focus();
                }
            }
        }

        private void btnSrcPasta_Click(object sender, EventArgs e)
        {
            var FolderDialog = new FolderBrowserDialog();
            DialogResult result = FolderDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                String folderPath = FolderDialog.SelectedPath;
                if (folderPath != null)
                {
                    txtPasta.Text = folderPath;
                    txtPasta.Focus();
                }
            }
        }
        private Image ResizeImage (Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.InterpolationMode  = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }
        private void btnSobrepor_Click(object sender, EventArgs e)
        {
            String Moldura = txtMoldura.Text;
            String Pasta = txtPasta.Text;
            String novaPasta = Path.Combine(Pasta, "Molduras");
            Directory.CreateDirectory(novaPasta);
            Image imgMoldura = Image.FromFile(Moldura);
            imgMoldura = ResizeImage(imgMoldura, 6000, 4000);
            Image imgPasta;
            String[] files;
            files = Directory.GetFiles(Pasta);

            foreach (String file in files)
            {
                try
                {
                    imgPasta = Image.FromFile(file);
                    imgPasta = ResizeImage(imgPasta, 6000, 4000);
                    Bitmap output = new Bitmap(6000,4000);
                    using (Graphics g = Graphics.FromImage(output))
                    {
                        g.DrawImage(imgPasta, new Point(0, 0));

                        g.DrawImage(imgMoldura, new Point(0, 0));
                    }
                    string nomeArquivo = Path.Combine(novaPasta, Path.GetFileName(file));
                    output.Save(nomeArquivo, System.Drawing.Imaging.ImageFormat.Jpeg);
                    output.Dispose();
                } catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao mesclar imagens: {ex.Message}");
                }
            }
            MessageBox.Show("Operação concluida com sucesso", "Sucesso!", MessageBoxButtons.OK  );
        }
    }
}
