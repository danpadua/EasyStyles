using System.Threading.Tasks;
using Xamarin.Forms;

namespace EasyStylesApp.Customs
{
    public class CardView : Frame
    {
        public CardView()
        {
            if (Device.OS == TargetPlatform.iOS)
            {
                HasShadow = false;
                OutlineColor = Color.Transparent;
                BackgroundColor = Color.Transparent;
            }

            StartAnimation();
        }

        public async void StartAnimation()
        {
            await Task.WhenAll<bool>(
                this.RotateTo(360, 1000),
                this.ScaleTo(2, 500)
            );
            await this.ScaleTo(1, 500);
        }
    }
}
