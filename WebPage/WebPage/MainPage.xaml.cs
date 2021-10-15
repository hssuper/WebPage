using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPage.model;
using Xamarin.Forms;

namespace WebPage
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btUrl(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(urlTxt.Text))
                DisplayAlert("Webview Erro", "Digite a URl", "OK");
            else
                wv1.Source = urlTxt.Text;
        }

        private void btHtml(object sender, EventArgs e)
        {
            var html1 = new HtmlWebViewSource();
            html1.Html = @"<!doctype html>
                            <html><head><title>Exemplo 1</title>
                            <meta charset='utf-8'
                            </head>
                            <body>
                            <h2>Exemplo de conteúdo HTML em WebView</h2>
                            <label style='color: Blue;'>Aula Xamarin - Prof. Ricardo Amaral</label>
                            </body></html>";
            wv1.Source = html1;
        }

        private void btHtmlLocal(object sender, EventArgs e)
        {
            var html2 = new HtmlWebViewSource();
            html2.BaseUrl = DependencyService.Get<IBaseUrl>().Get();
            wv1.Source = html2.BaseUrl;
        }
    }
}
