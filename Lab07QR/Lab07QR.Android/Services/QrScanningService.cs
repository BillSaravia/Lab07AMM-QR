using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing.Mobile;
using Lab07QR.Services;
using Lab07QR.Droid.Service;
using Lab07QR.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(QrScanningService))]

namespace Lab07QR.Droid.Service
{
    public class QrScanningService : IQrScanningService
    {
        public async Task<string> ScanAsync()
        {
            MobileBarcodeScanner.Initialize(MainActivity.Instance.Application);

            var optionsDefault = new MobileBarcodeScanningOptions();
            var optionsCustom = new MobileBarcodeScanningOptions();

            var scanner = new MobileBarcodeScanner()
            {
                TopText = "Scan the QR Code",
                BottomText = "Please Wait",
            };

            var scanResult = await scanner.Scan(optionsCustom);
            return scanResult.Text;
        }
    }
}


