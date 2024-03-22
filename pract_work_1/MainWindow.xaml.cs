using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Media3D;

namespace pract_work_1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            BitmapImage texture = new BitmapImage();
            texture.BeginInit();
            texture.UriSource = new Uri("texture.jpg", UriKind.Relative);
            texture.EndInit();

            ((DiffuseMaterial)((GeometryModel3D)((ModelVisual3D)viewport3D.Children[3]).Content).Material).Brush = new ImageBrush(texture);
            ((DiffuseMaterial)((GeometryModel3D)((ModelVisual3D)viewport3D.Children[4]).Content).Material).Brush = new ImageBrush(texture);
        }
    }
}
