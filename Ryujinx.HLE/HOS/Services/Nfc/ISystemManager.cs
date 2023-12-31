﻿using Ryujinx.HLE.HOS.Services.Nfc.SystemManager;

namespace Ryujinx.HLE.HOS.Services.Nfc
{
    [Service("nfc:sys")]
    class ISystemManager : IpcService
    {
        public ISystemManager(ServiceCtx context) { }

        [CommandHipc(0)]
        // CreateSystemInterface() -> object<nn::nfp::detail::ISystem>
        public ResultCode CreateSystemInterface(ServiceCtx context)
        {
            MakeObject(context, new ISystem());

            return ResultCode.Success;
        }
    }
}