﻿using bankroll.domain.entities;
using System;

namespace bankroll.service.services.interfaces
{
    public interface IPlayerService : IService<Player>
    {
        void EditBankroll(Player player);
        object OverallChartOnlineData(Guid playerId);
        object OverallChartLiveData(Guid playerId);
        object OverallChartWinAndLose(Guid playerId);
        object OverallChartWinOnlineVsLive(Guid playerId);
    }
}
