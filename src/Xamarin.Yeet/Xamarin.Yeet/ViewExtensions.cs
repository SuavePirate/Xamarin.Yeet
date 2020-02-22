using System;
using Xamarin.Forms;

namespace Xamarin.Yeet
{
    public static class ViewExtensions
    {
        public static void Yeet(this View view)
        {
            view?.TranslateTo(9000, 9000, 2000);
        }
    }
}
