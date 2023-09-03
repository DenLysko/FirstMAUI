using Microsoft.Maui.Controls;
using System.Diagnostics;

namespace FirstMAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            string result = await webView.EvaluateJavaScriptAsync($"document.getElementsByClassName(" +
                $"'mectrl_profilepic mectrl_glyph mectrl_signIn_circle_glyph')[0].innerHTML");
            Debug.WriteLine(result);

            webView.Eval($"document.getElementsByClassName('mectrl_profilepic mectrl_glyph mectrl_signIn_circle_glyph')[0].click()");
            
            
            
            
            
            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            // Не совсем понял зачем это нужно
            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}
