using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Account;
using Ryujinx.Horizon.Sdk.Ncm;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    interface IHomeMenuFunctions : IServiceObject
    {
        Result RequestToGetForeground();
        Result LockForeground();
        Result UnlockForeground();
        Result PopFromGeneralChannel(out IStorage arg0);
        Result GetPopFromGeneralChannelEvent(out int arg0);
        Result GetHomeButtonWriterLockAccessor(out ILockAccessor arg0);
        Result GetWriterLockAccessorEx(out ILockAccessor arg0, int arg1);
        Result IsSleepEnabled(out bool arg0);
        Result IsRebootEnabled(out bool arg0);
        Result PopRequestLaunchApplicationForDebug(out ApplicationId arg0, out int arg1, Span<Uid> arg2);
        Result IsForceTerminateApplicationDisabledForDebug(out bool arg0);
        Result LaunchDevMenu();
        Result SetLastApplicationExitReason(int arg0);
    }
}
