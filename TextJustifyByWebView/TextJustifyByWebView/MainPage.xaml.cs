using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TextJustifyByWebView
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ShowText();
        }

        private void ShowText()
        {
            var browser = new WebView
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };
            string cs = "New Delhi, India (CNN)What is expected to be India's strongest landfalling tropical cyclone in nearly five years is barreling toward 100 million people on the east coast, prompting officials to begin emergency evacuations. On Thursday, Tropical Cyclone Fani had winds of 215 kph(130 mph) with gusts of 260 kph(160 mph), making it equivalent in intensity to a Category 4 major hurricane on the Saffir - Simpson scale. While it is not expected to make landfall in Odisha state until midday Friday, tropical cyclone force winds are already coming ashore in portions of Andhra Pradesh and will soon reach the Odisha coast as well. Cyclone Fani is due to make landfall in Odisha state on Friday. As Fani was classified as an extremely severe cyclonic storm in India, the country's Coast Guard and Navy deployed ships and helicopters for relief and rescue operations. Army and Air Force units have also been put on standby in Odisha, West Bengal and Andhra Pradesh states. Some 900 cyclone shelters have been set up across Odisha to house evacuees and school is canceled across the state on Thursday and Friday. Teams are going door to door to warn people. They are being told what to take with them if they leave and the precautions they need to take if they stay, said Ameya Patnaik, assistant commandant for the National Disaster Response Force(NDRF) in Odisha.";
            var structure = "<html>" +
                            "<body style=\"text-align: justify; color: red; background-color:powderblue;\">" +
                            String.Format("<p>{0}</p>", cs) +
                            "</body>" +
                            "</html>";
            var source = new HtmlWebViewSource();
            source.Html = structure;
            browser.Source = source;
            myview.Children.Add(browser);
        }
    }
}
