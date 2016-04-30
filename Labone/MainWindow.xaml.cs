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
using System.Reflection;

namespace Labone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();                     
        }

        //Главный Рисовательный Метод
        void drawShape(List<int> coordList)
        {
            for (int i = 0; i <= coordList.Count-2; i=i+2)
            {
                Line line = new Line();
                line.Stroke = System.Windows.Media.Brushes.Black;
                
                line.X1 = coordList[i];
                line.Y1 = coordList[i + 1];
                if (i+2 > coordList.Count-1)
                    line.X2 = coordList[i];
                else
                    line.X2 = coordList[i + 2];
                if (i + 3 > coordList.Count - 1)
                    line.Y2 = coordList[i + 1];
                else
                    line.Y2 = coordList[i + 3];
            
                myCanvas.Children.Add(line); 
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string shapeName = cccomboBox.Text;
            List<int> coordArray = new List<int>();
            int x = Convert.ToInt32(TextBoxX.Text);
            int y = Convert.ToInt32(TextBoxY.Text);

            //Магия!!! То есть рефлексия. Мой код состоит из экскрементов OTL но он РАБОТАЕТ
            
            //делаем объект
            object shapeObject = Activator.CreateInstance(Type.GetType("Labone." + shapeName, false, true));

            //делаем метод
            MethodInfo neededMethod = Type.GetType("Labone." + shapeName, false, true).GetMethod("getCoord");
            var magicResult = neededMethod.Invoke(shapeObject, new object[] { x, y });

            drawShape((List<int>)magicResult);
        }

    }

}
