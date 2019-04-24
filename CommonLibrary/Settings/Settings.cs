using System.Globalization;
using System.Threading;

namespace CommonLibrary.Settings
{
    public class Settings
    {
        /// <summary>
        /// Bu yerda kelishuv bo'yicha dastlabki sozlamalar joylashadi....
        /// </summary>
        public static void SetDefaultSettings()
        {
            ///
            /// UI tilini qo'yish
            ///
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("En-US");
        }
    }
}
