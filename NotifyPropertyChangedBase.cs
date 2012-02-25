using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;

namespace PerceptiveSoftware.Core.Utility
{
    /// <summary>
    /// Base class for that provides an easy-to-use method to rasing
    /// PropertyChanged notifications.
    /// </summary>
    /// <remarks>
    /// Simplifies the implementation of INotifyPropertyChanged, by supplying
    /// the public PropertyChanged event and wrapping the process of raising
    /// the event in a thread-safe manner.  Any class that implements the
    /// INotifyPropertyChanged event and does not inherit from another base
    /// class can use this class as its base.
    /// </remarks>
    public abstract class NotifyPropertyChangedBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected NotifyPropertyChangedBase()
        {
            ThrowOnInvalidPropertyName = true;
        }

        /// <summary>
        /// set this to true if you want to throw on invalid property names.
        /// </summary>
        public bool ThrowOnInvalidPropertyName { get; set; }

        protected void RaisePropertyChanged(string propertyName)
        {
            VerifyPropertyName(propertyName);

            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [Conditional("DEBUG")]
        [DebuggerStepThrough]
        private void VerifyPropertyName(string propertyName)
        {
            // Empty or null propertyName indicates that all of the properties have changed.
            if (ThrowOnInvalidPropertyName && !string.IsNullOrEmpty(propertyName))
            {
                if (GetType().GetProperty(propertyName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic) == null)
                {
                    throw new ArgumentException("Property not found: " + propertyName, "propertyName");
                }
            }
        }

    }
}
