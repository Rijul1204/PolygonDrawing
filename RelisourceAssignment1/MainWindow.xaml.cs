using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace RelisourceAssignment1
{
    public class Target
    {
        public string firstName;
        public string lastName; 
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ReadJson();

            //CurrWindow.Width = 1000;       

            CreateAPolygon();

        }

        void ReadJson()
        {
            string json = File.ReadAllText(@"c:\users\user.pc\documents\visual studio 2013\Projects\RelisourceAssignment1\RelisourceAssignment1\Config\file.json");
            
            var path = System.IO.Path.Combine(Directory.GetCurrentDirectory());
            string json1 = File.ReadAllText("Config/file.json");
            
            Target newTarget = JsonConvert.DeserializeObject<Target>(json);
        }

        private void CreateAPolygon()
        {

            // Create a blue and a black Brush

            SolidColorBrush yellowBrush = new SolidColorBrush();

            yellowBrush.Color = Colors.Yellow;

            SolidColorBrush blackBrush = new SolidColorBrush();

            blackBrush.Color = Colors.Black;



            // Create a Polygon

            Polygon yellowPolygon = new Polygon();
            Polygon Polygon2 = new Polygon();

            //yellowPolygon.Stroke = blackBrush;

            //yellowPolygon.Fill = yellowBrush;

            //yellowPolygon.StrokeThickness = 4;

            PointCollection polygonPoints = new PointCollection();
            PointCollection polygonPoints2 = new PointCollection();            


            // Create a collection of points for a polygon

            System.Windows.Point Point1 = new System.Windows.Point(50, 100);
            System.Windows.Point Point2 = new System.Windows.Point(200, 100);
            System.Windows.Point Point3 = new System.Windows.Point(200, 200);

            System.Windows.Point Point21 = new System.Windows.Point(350, 100);
            System.Windows.Point Point22 = new System.Windows.Point(400, 100);
            System.Windows.Point Point23 = new System.Windows.Point(400, 300);
            //System.Windows.Point Point4 = new System.Windows.Point(300, 30);
            //System.Windows.Point Point5 = new System.Windows.Point(300, 90);

            polygonPoints.Add(Point1);
            polygonPoints.Add(Point2);
            polygonPoints.Add(Point3);

            polygonPoints2.Add(Point21);
            polygonPoints2.Add(Point22);           
            polygonPoints2.Add(Point23);

            // Set Polygon.Points properties

            yellowPolygon.Points = polygonPoints;
            Polygon2.Points = polygonPoints2;            
         
            
            

            //yellowPolygon.Style.Triggers.

            yellowPolygon.Style = (Style)TryFindResource("MulitTriggerButtonStyle");
            Polygon2.Style = (Style)TryFindResource("MulitTriggerButtonStyle");
          

            // Add Polygon to the page


            LayoutRoot.Children.Add(yellowPolygon);

            LayoutRoot.Children.Add(Polygon2);            
            

        }

        public void CreateALine()
        {

            // Create a Line

            Line redLine = new Line();

            redLine.X1 = 50;

            redLine.Y1 = 50;

            redLine.X2 = 200;

            redLine.Y2 = 200;
            

            // Create a red Brush
            SolidColorBrush redBrush = new SolidColorBrush();
            redBrush.Color = Colors.Red;



            // Set Line's width and color

            redLine.StrokeThickness = 4;

            redLine.Stroke = redBrush;



            // Add line to the Grid.

            LayoutRoot.Children.Add(redLine);

        }
    }
}
