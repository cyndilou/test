using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Windows.Controls;

namespace CustomComboBoxTest
{
    /// <summary>
    /// Interaction logic for SnoozeControl.xaml
    /// </summary>
    public partial class SnoozeControl : UserControl
    {
        #region Dependency Properties

        public int SnoozeNumber
        {
            get { return (int)GetValue(SnoozeNumberProperty); }
            set { SetValue(SnoozeNumberProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SnoozeNumber.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SnoozeNumberProperty =
            DependencyProperty.Register("SnoozeNumber", typeof(int), typeof(SnoozeControl), new PropertyMetadata(null));
        
        public DateTime EventTime
        {
            get { return (DateTime)GetValue(EventTimeProperty); }
            set { SetValue(EventTimeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for EventTime.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EventTimeProperty =
            DependencyProperty.Register("EventTime", typeof(DateTime), typeof(SnoozeControl), new PropertyMetadata(null));
        
        public TimeSpan SnoozeTimeSpan
        {
            get { return (TimeSpan)GetValue(SnoozeTimeSpanProperty); }
            set { SetValue(SnoozeTimeSpanProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SnoozeTimeSpan.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SnoozeTimeSpanProperty =
            DependencyProperty.Register("SnoozeTimeSpan", typeof(TimeSpan), typeof(SnoozeControl), new PropertyMetadata(null));

        #endregion Dependency Properties

        public SnoozeControl()
        {
            InitializeComponent();
        }
    }
}
