using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinSummitLive2020.Views;

namespace XamarinSummitLive2020
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void OnRectangleButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RectanglePage());
        }

        public void OnEllipseButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EllipsePage());
        }

        public void OnLineButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LinePage());
        }

        public void OnPolylineButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PolylinePage());
        }

        public void OnPolygonButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PolygonPage());
        }

        public void OnGeometryButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GeometriesPage());
        }

        public void OnClipsButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ClipPathPage());
        }

        public void OnSvgButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SvgPage());
        }
    }
}
