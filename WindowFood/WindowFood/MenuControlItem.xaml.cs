using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WindowFood
{
    /// <summary>
    /// Interaction logic for MenuItem.xaml
    /// </summary>
    public partial class MenuControlItem : UserControl
    {


        [Category("Custom")]
        [Description("Image icon")]
        public ImageSource imageIcon { get; set; }

        [Category("Custom")]
        [Description("Image Icon")]
        public bool selected { get; set; }

        [Category("Custom")]
        [Description("Panel Name")]
        public string panelName { get; set; }

        public MenuControlItem()
        {
            InitializeComponent();
            this.selected = false;
        }

        public void select()
        {
            selected = true;
            grdMain.Background = new SolidColorBrush(Color.FromArgb(40, 0,0,0));
        }

        public void unselect()
        {
            selected = false;
            grdMain.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
        }

        private void UserControl_MouseEnter(object sender, MouseEventArgs e)
        {
            grdMain.Background = new SolidColorBrush(Color.FromArgb(70, 0, 0, 0));
        }

        private void UserControl_MouseLeave(object sender, MouseEventArgs e)
        {
            if(selected) grdMain.Background = new SolidColorBrush(Color.FromArgb(40, 0, 0, 0));
            else grdMain.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
        }

        private void MenuControlItem1_Loaded(object sender, RoutedEventArgs e)
        {
            this.txtPanelName.Text = panelName;
            imgIcon.Source = imageIcon;
            if (selected) select();
        }
    }
}
