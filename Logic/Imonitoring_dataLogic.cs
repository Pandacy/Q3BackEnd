﻿using DTO;
using System.Collections.Generic;

namespace Logic
{
    public interface Imonitoring_dataLogic
    {
        IEnumerable<monitoring_dataDTO> ReadAll();
        IEnumerable<monitoring_dataDTO> GetByPort(int port)
    }
}