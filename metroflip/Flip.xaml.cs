using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace metroflip
{
    public sealed partial class Flip : UserControl
    {
       
        public Flip()
        {
            InitializeComponent();
        }
        public static readonly DependencyProperty TextPrevProperty =
       DependencyProperty.Register("TextPrev", typeof(string),
       typeof(Flip), null);

        public static readonly DependencyProperty TextNextProperty =
        DependencyProperty.Register("TextNext", typeof(string),
        typeof(Flip), null);

        public string TextPrev
        {
            get { return (string)GetValue(TextPrevProperty); }
            set
            {
                SetValue(TextPrevProperty, value);
                textBlockBottom.Text = TextPrev;
                textBlockFlipTop.Text = TextPrev;
            }
        }

        public string TextNext
        {
            get { return (string)GetValue(TextNextProperty); }
            set
            {
                SetValue(TextNextProperty, value);
                textBlockTop.Text = TextNext;
                textBlockFlipBottom.Text = TextNext;

            }
        }

        public void Value(string source, string target)
        {
            TextNext = target;
            TextPrev = source;
            FlipAnimation.Begin();
        }

     
    }
}
