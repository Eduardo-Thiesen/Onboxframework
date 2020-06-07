﻿using System.Threading.Tasks;

namespace Onbox.Mvc.V7
{
    public interface IMvcLifeCycle
    {
        bool CanRetryOnError { get; set; }
        bool CanRetryOnWarning { get; set; }
        string Error { get; set; }
        bool IsLoading { get; set; }
        string Message { get; set; }
        string Warning { get; set; }

        void OnDestroy();
        void OnErrorRetry();
        void OnInit();
        Task OnInitAsync();
        void OnWarningRetry();
    }

    public interface IMvcViewLifeCycle : IMvcLifeCycle
    {
        void OnAfterInit();
    }
}