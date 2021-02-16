using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("{0} adlı kampanya sisteme eklendi. ", campaign.Name);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("{0} adlı kampanya güncellendi. ", campaign.Name);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("{0} adlı kampanya sistemden silindi. ", campaign.Name);
        }
    }
}
