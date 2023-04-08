﻿using System.Windows.Controls;

namespace DispatchersMonitoringTool.Contracts.Services;

public interface IPageService
{
    Type GetPageType(string key);

    Page GetPage(string key);
}
