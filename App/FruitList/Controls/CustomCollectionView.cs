using Xamarin.Forms;

namespace FruitList.Controls
{
    public class CustomCollectionView : CollectionView
    {
        public static readonly BindableProperty OrientationDataProperty =
        BindableProperty.Create("OrientationData", typeof(OrientationData), typeof(CustomCollectionView), OrientationData.List);

        public OrientationData OrientationData
        {
            get { return (OrientationData)GetValue(OrientationDataProperty); }
            set { SetValue(OrientationDataProperty, value); }
        }
    }
}