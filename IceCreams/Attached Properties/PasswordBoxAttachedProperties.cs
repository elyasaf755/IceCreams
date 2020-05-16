using System;
using System.Windows;
using System.Windows.Controls;

namespace IceCreams
{
    /// <summary>
    /// The MonitorPassword attached property for a <see cref="PasswordBox"/>
    /// </summary>
    public class MonitorPasswordProperty : AttachedPropertyBase<MonitorPasswordProperty, bool>
    {
        public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            // Get the caller
            var passwordBox = sender as PasswordBox;

            // Make sure it is a password box
            if (passwordBox == null)
                return;

            // Remove any previous events
            passwordBox.PasswordChanged -= PasswordBox_PasswordChanged;

            // If the caller set MonitorPassword to true...
            if ((bool)e.NewValue)
            {
                // Set default value
                HasTextProperty.SetValue(passwordBox);

                // Start listening out for password changes
                passwordBox.PasswordChanged += PasswordBox_PasswordChanged;
            }
        }

        /// <summary>
        /// Fired when the password box password value changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            // Set the attached HasText value
            HasTextProperty.SetValue((PasswordBox)sender);
        }
    }

    /// <summary>
    /// The HasText attached property for a <see cref="PasswordBox"/>
    /// </summary>
    public class HasTextProperty : AttachedPropertyBase<HasTextProperty, bool>
    {
        /// <summary>
        /// Sets the HasText property based on if the caller <see cref="PasswordBox"/> has any text
        /// </summary>
        /// <param name="sender"></param>
        public static void SetValue(DependencyObject sender)
        {
            SetValue(sender, ((PasswordBox)sender).SecurePassword.Length > 0);
            SetIsPasswordEmpty((PasswordBox)sender);
        }

        public static readonly DependencyPropertyKey IsPasswordEmptyPropertyKey =
        DependencyProperty.RegisterAttachedReadOnly(
            "IsPasswordEmpty", typeof(bool), typeof(HasTextProperty),
            new FrameworkPropertyMetadata());

        public static readonly DependencyProperty IsPasswordEmptyProperty =
            IsPasswordEmptyPropertyKey.DependencyProperty;

        private static void SetIsPasswordEmpty(PasswordBox element)
        {
            element.SetValue(IsPasswordEmptyPropertyKey, element.SecurePassword.Length == 0);
        }

        public static bool GetIsPasswordEmpty(PasswordBox element)
        {
            return (bool)element.GetValue(IsPasswordEmptyProperty);
        }
    }
}
