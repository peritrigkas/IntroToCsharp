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


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            Title = "Demo APP";
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Empolyee e1 = new Empolyee();
            e1.Name = " Peri ";

            Empolyee e2 = new Empolyee();
            e2.Name = " Trigkas ";
            Output.Text= e1.Name + " " + e2.Name;
            Shape s1 = new Circle(DrawingCanvas);

            s1.Draw();
        }
        private void DrawShape(Shape shape)
        {
            shape.Draw();
        }


}
            
}

        
    

