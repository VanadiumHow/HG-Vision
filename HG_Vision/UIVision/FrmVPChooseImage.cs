using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using HG_Vision.Manager.Manager_System;

namespace HG_Vision.UIVision
{
    public partial class FrmVPChooseImage : Form
    {
        #region  委托事件
        public event Action OnChooseSure;
        #endregion

        private FrmVpVisionControl _userDisplay;

        private int _model = 0;

        public FrmVPChooseImage(FrmVpVisionControl p)
        {
            InitializeComponent();
            _userDisplay = p;
            picBoxes = new PictureBox[4] { pictureBox1, pictureBox2, pictureBox3, pictureBox4 };
        }
        /// <summary>
        /// 定义图像预览控件集合
        /// </summary>
        private PictureBox[] picBoxes;
        private string[] imageInfoNames;
        private string imageName;

        /// <summary>
        /// 打开单张图像文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog oImage = new OpenFileDialog())
            {

                oImage.Filter = "所有图像文件 | *.tiff; *.png; *.jpg; *.bmp; *.hobj; *.ima; *.gif; *.jpeg; *.jp2; *.jxr; *.pcx; *.ras; *.xwd; *.pbm; *.pnm; *.pgm; *.ppm";
                oImage.Multiselect = false;
                oImage.Title = "请选择需要从本地打开的文件...";

                oImage.InitialDirectory = Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[0].RawImagePosition;
                oImage.InitialDirectory = null;

                if (oImage.ShowDialog() == DialogResult.OK)
                {
                    foreach (PictureBox pb in picBoxes)
                    {
                        pb.Image = null;
                    }

                    imageName = oImage.FileName;
                    tbPath.Text = imageName;
                    if (imageName.Trim().EndsWith(".bmp") || imageName.Trim().EndsWith(".png") || imageName.Trim().EndsWith(".jpg"))
                    {
                        pictureBox1.Load(imageName.Trim());
                    }
                    groupBox1.Text = "图像总数-1";

                    _model = 1;

                }
            }
        }

        /// <summary>
        /// 打开图像文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChooseDictionary_Click(object sender, EventArgs e)
        {
            picBoxes = new PictureBox[4] { pictureBox1, pictureBox2, pictureBox3, pictureBox4 };
            using (FolderBrowserDialog oImage = new FolderBrowserDialog())
            {
                oImage.SelectedPath = Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[0].RawImagePosition;
                if (oImage.ShowDialog() == DialogResult.OK)
                {

                    string pathName = oImage.SelectedPath;
                    string[] str = "*.tiff;*.png;*.jpg;*.bmp;*.hobj;*.ima;*.gif;*.jpeg;*.jp2;*.jxr;*.pcx;*.ras;*.xwd;*.pbm;*.pnm;*.pgm;*.ppm".Split(';');

                    System.IO.DirectoryInfo d = new System.IO.DirectoryInfo(pathName);
                    List<System.IO.FileInfo> ALLfis = new List<FileInfo>(); ;
                    foreach (string st in str)
                    {
                        System.IO.FileInfo[] fis = d.GetFiles(st.Replace(" ", ""));
                        ALLfis.AddRange(fis);
                    }

                    int imagesCount = ALLfis.Count;

                    if (imagesCount > 0)
                    {
                        foreach (PictureBox pb in picBoxes)
                        {
                            pb.Image = null;
                        }
                        tbPath.Text = pathName;

                        imageInfoNames = new string[imagesCount];
                        groupBox1.Text = "图像总数 _ " + imagesCount.ToString();

                        int index = 0;
                        for (int i = imagesCount - 1; i >= 0; i--)
                        {
                            if (index <= 3)
                            {
                                if (ALLfis[i].FullName.Trim().EndsWith(".bmp") || ALLfis[i].FullName.Trim().EndsWith(".png") || ALLfis[i].FullName.Trim().EndsWith(".jpg"))
                                {
                                    picBoxes[index].Load(ALLfis[i].FullName); index++;
                                }
                            }
                            imageInfoNames[imagesCount - 1 - i] = ALLfis[i].FullName;
                        }
                        _model = 2;
                    }
                    else
                    {
                        MessageBox.Show("未能识别到BMP的图像文件,请重新选择文件夹！", "信息提示");
                    }
                }
            }
        }

        private void ChooseImages_Load(object sender, EventArgs e)
        {
            if (_userDisplay.ImageLoadStyle == FrmVpVisionControl.LoadStyle.Image && !string.IsNullOrEmpty(_userDisplay.ImageName))
            {
                _model = 1;
                imageName = _userDisplay.ImageName;
                tbPath.Text = _userDisplay.ImageName;
                if (tbPath.Text.Trim().EndsWith(".bmp") || tbPath.Text.Trim().EndsWith(".png") || tbPath.Text.Trim().EndsWith(".jpg"))
                {
                    pictureBox1.Load(tbPath.Text);
                }
                groupBox1.Text = "图像总数-1";
            }
            if (_userDisplay.ImageLoadStyle == FrmVpVisionControl.LoadStyle.Folder && _userDisplay.ImageInfoNames.Length > 0 && !string.IsNullOrEmpty(_userDisplay.DirectoryName))
            {
                _model = 2;
                tbPath.Text = _userDisplay.DirectoryName;
                imageInfoNames = _userDisplay.ImageInfoNames;
                foreach (PictureBox pb in picBoxes)
                {
                    pb.Image = null;
                }
                string pathName = tbPath.Text;
                string[] str = "*.tiff ;*.png; *.jpg ;*.bmp;".Split(';');

                System.IO.DirectoryInfo d = new System.IO.DirectoryInfo(pathName);
                List<System.IO.FileInfo> ALLfis = new List<FileInfo>(); ;
                foreach (string st in str)
                {
                    System.IO.FileInfo[] fis = d.GetFiles(st.Replace(" ", ""));
                    ALLfis.AddRange(fis);
                }
                int imagesCount = ALLfis.Count;
                groupBox1.Text = "图像总数-" + imagesCount.ToString();
                int i = 0;
                foreach (System.IO.FileInfo fi in ALLfis)
                {
                    if (i > 3)
                        break;
                    imagesCount--;

                    if (ALLfis[imagesCount].FullName.Trim().EndsWith(".bmp") || ALLfis[imagesCount].FullName.Trim().EndsWith(".png") || ALLfis[imagesCount].FullName.Trim().EndsWith(".jpg"))
                    {
                        picBoxes[i].Load(ALLfis[imagesCount].FullName); i++;
                    }

                }
            }
        }

        private void btn_Sure_Click(object sender, EventArgs e)
        {
            if (_model == 0)
            {
                MessageBox.Show("请选择需要加载的图片！");
                return;
            }
            if (_model == 1)
            {
                _userDisplay.ImageLoadStyle = FrmVpVisionControl.LoadStyle.Image;
                _userDisplay.ImageName = imageName;
            }
            else if (_model == 2)
            {
                _userDisplay.ImageLoadStyle = FrmVpVisionControl.LoadStyle.Folder;
                _userDisplay.ImageInfoNames = imageInfoNames;
                _userDisplay.DirectoryName = imageInfoNames[0].Substring(0, imageInfoNames[0].LastIndexOf("\\"));

            }
            this.Close();
            OnChooseSure?.Invoke();
        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
