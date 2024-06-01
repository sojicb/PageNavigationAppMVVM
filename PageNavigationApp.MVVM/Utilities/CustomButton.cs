using System.Windows.Controls;

namespace PageNavigationApp.MVVM.Utilities
{
    public class CustomButton : RadioButton
    {
        static CustomButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomButton), new System.Windows.PropertyMetadata(typeof(CustomButton)));
        }
    }
}
