﻿using Com.DanLiris.Service.Core.Lib.Interfaces;
using Com.DanLiris.Service.Core.Lib.Models;
using Com.DanLiris.Service.Core.Lib.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Com.DanLiris.Service.Core.Lib.Services.MachineSpinning
{
    public interface IMachineSpinningService : IBaseService<MachineSpinningModel>, IBasicUploadCsvService<MachineSpinningCsvViewModel>
    {
        List<MachineSpinningModel> MapFromCsv(List<MachineSpinningCsvViewModel> data);
        Task<int> UploadData(List<MachineSpinningModel> data);
        MemoryStream DownloadTemplate();
        List<string> GetMachineTypes();
        List<MachineSpinningModel> GetSimple();
    }
}
