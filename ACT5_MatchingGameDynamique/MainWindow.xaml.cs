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

namespace ACT5_MatchingGameDynamique
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeInterface();
        }

        public void InitializeInterface()
        {
            ColumnDefinition Column = new ColumnDefinition();
            RowDefinition Row = new RowDefinition();
            grid.ColumnDefinitions.Add(Column);
            grid.RowDefinitions.Add(Row);
            ColumnDefinition c2 = new ColumnDefinition();
            RowDefinition r2 = new RowDefinition();
            grid.ColumnDefinitions.Add(c2);
            grid.RowDefinitions.Add(r2);
            ColumnDefinition c3  = new ColumnDefinition();
            RowDefinition r3 = new RowDefinition();
            grid.ColumnDefinitions.Add(c3);
            grid.RowDefinitions.Add(r3);


            Button btn1 = new Button();
            btn1.Height = 130;
            btn1.Width = 130;
            btn1.Content = "BOUTON 1";

            Button btn2 = new Button();
            btn2.Height = 130;
            btn2.Width = 130;
            btn2.Content = "BOUTON 2";

            Button btn3 = new Button();
            btn3.Height = 130;
            btn3.Width = 130;
            btn3.Content = "BOUTON 3";

            TextBlock txtTop = new TextBlock();
            txtTop.Text = "TextBlock créé dynamiquement";
            txtTop.Foreground = Brushes.Red;
            txtTop.Background = Brushes.Yellow;
            txtTop.Height = 50;
            txtTop.FontFamily = new FontFamily("Times New Roman");
            txtTop.FontSize = 25;
            txtTop.FontWeight = FontWeights.Bold;

            TextBlock txtDown = new TextBlock();
            txtDown.Text = "infos :";
            txtDown.Background = Brushes.Yellow;
            txtDown.Height = 70;

            TextBox txtB = new TextBox();
            txtB.Text = "j'attends vos infos";

            ComboBox cmbB = new ComboBox();
            Thickness cmbBMargin = new Thickness();
            cmbBMargin.Bottom = 20;
            cmbBMargin.Left = 50;
            cmbBMargin.Right = 50;
            cmbBMargin.Top = 20;
            cmbB.Margin = cmbBMargin;
            cmbB.Items.Add("item # 1");
            cmbB.Items.Add("item # 2");


            StackPanel stkP = new StackPanel();
            Thickness stkPMargin = new Thickness();
            stkPMargin.Bottom = 0;
            stkPMargin.Left = 0;
            stkPMargin.Right = 0;
            stkPMargin.Top = 20;
            stkP.Margin = stkPMargin;


            grid.Children.Add(txtTop);

            grid.Children.Add(btn1);
            grid.Children.Add(btn2);
            grid.Children.Add(btn3);

            grid.Children.Add(stkP);
            stkP.Children.Add(txtDown);
            stkP.Children.Add(txtB);
            grid.Children.Add(cmbB);


            Grid.SetColumn(txtTop, 0);
            Grid.SetColumnSpan(txtTop, 3);

            Grid.SetRow(btn1, 1);
            Grid.SetRow(btn2, 1);
            Grid.SetRow(btn3, 1);
            Grid.SetColumn(btn1, 0);
            Grid.SetColumn(btn2, 1);
            Grid.SetColumn(btn3, 2);

            Grid.SetRow(stkP, 2);
            Grid.SetColumn(stkP, 0);
            Grid.SetColumnSpan(stkP, 2);
            Grid.SetRow(cmbB, 2);
            Grid.SetColumn(cmbB, 2);
            
        }
    }
}
