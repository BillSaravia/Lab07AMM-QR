﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lab07QR.Services
{
    public interface IQrScanningService
    {
        Task<string> ScanAsync();

    }
}