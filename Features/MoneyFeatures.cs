using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// For using all other files from this project
using ownned.ext;
using UnityEngine;

namespace ownned.ext.Features
{
    public class MoneyFeatures
    {
        public static void addMoneyModule(int money)
        {
            RoomStatsHolder roomStatsHolder = SurfaceNetworkHandler.RoomStats;
            roomStatsHolder.AddMoney(money);
        }

        public static void removeMoneyModule(int money)
        {
            RoomStatsHolder roomStatsHolder = SurfaceNetworkHandler.RoomStats;
            roomStatsHolder.RemoveMoney(money);
        }
    }
}
