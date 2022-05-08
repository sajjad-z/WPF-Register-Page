using System.Windows;
using System.Windows.Controls;

namespace Register_Page.UserControls
{
    public partial class MyTextBox : UserControl
    {
        public MyTextBox()
        {
            InitializeComponent();
        }

        public string Hint
        {
            get { return (string)GetValue(HintProperty); }
            set { SetValue(HintProperty, value); }
        }

        public static readonly DependencyProperty HintProperty = DependencyProperty.Register("Hint", typeof(string), typeof(MyTextBox));

    }
}