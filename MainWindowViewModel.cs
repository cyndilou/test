using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using GoogleCalendarReminder.Converters;
using PerceptiveSoftware.Core.Utility;

namespace CustomComboBoxTest
{
    public class MainWindowViewModel : NotifyPropertyChangedBase
    {
        public int SelectedValue { get; set; }
        public string SelectedText { get; set; }

        private readonly int[] _baseSnoozeList = new[] { 5, 10, 15, 20, 25, 30, 45, 60, SnoozeConverter.CustomSnoozeValue};
        public ObservableCollection<int> ValueCollection { get; set; }

        public ObservableCollection<TestItem> TestItems { get; set; }

        private int _testInt;
        public int TestInt
        {
            get { return _testInt; }
            set
            {
                _testInt = value;
                RaisePropertyChanged("TestInt");
            }
        }

        private DateTime _testEventTime;
        public DateTime TestEventTime
        {
            get { return _testEventTime; }
            set 
            { 
                _testEventTime = value;
                RaisePropertyChanged("TestEventTime");
            }
        }

        private DateTime _reminderTime;
        public DateTime ReminderTime
        {
            get { return _reminderTime; }
            set
            {
                _reminderTime = value;
                RaisePropertyChanged("ReminderTime");
            }
        }

        public MainWindowViewModel()
        {
            ValueCollection = new ObservableCollection<int>(_baseSnoozeList);
            
            ValueCollection.Insert(0, -10);
            ValueCollection.Insert(0,-5);

            TestEventTime = DateTime.Now;
            TestEventTime = TestEventTime.Subtract(new TimeSpan(0, 0, 10, 0));

            ReminderTime = DateTime.Now;

            TestInt = 30;

            TestItems = new ObservableCollection<TestItem>();

            for (int i = 0; i < 5; ++i)
            {
                TestItems.Add(new TestItem
                                  {
                                      Property1 = "Prop " + i + "A",
                                      Property2 = "Prop " + i + "B"
                                  });
            }
        }
    }
}
