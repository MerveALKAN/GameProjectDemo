﻿using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Abstract
{
   public interface ISaleService
    {
        void Sell(Gamer gamer, Game game);//Yapılan satışlar oyuncu ile ilişkilendirildi.
        void CampaignSale(Gamer gamer, Game game, Campaign campaign);
    }
}
