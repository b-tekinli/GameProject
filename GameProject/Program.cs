using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                    OYUN DÜNYASINA HOŞ GELDİNİZ\n");

            Gamer gamer1 = new Gamer() { ID = 1, IdentityNumber = 12345678912, Name = "Şevval", LastName = "Kelebek", BirthYear = 2002 };
            Gamer gamer2 = new Gamer() { ID = 2, IdentityNumber = 98765432100, Name = "Mehmet", LastName = "Öz", BirthYear = 1994 };
            Gamer gamer3 = new Gamer() { ID = 3, IdentityNumber = 45678923148, Name = "Berat", LastName = "Türk", BirthYear = 1996 };
            Gamer gamer4 = new Gamer() { ID = 4, IdentityNumber = 15987542326, Name = "Erva", LastName = "Kar", BirthYear = 2000 };
            Gamer gamer5 = new Gamer() { ID = 5, IdentityNumber = 54156121240, Name = "Aleyna", LastName = "Tekin", BirthYear = 1999 };

            Game game1 = new Game() { ID = 1, Name = "Valorant", Price = 125 };
            Game game2 = new Game() { ID = 2, Name = "PUBG", Price = 70 };
            Game game3 = new Game() { ID = 3, Name = "Watch Dogs 2", Price = 400 };
            Game game4 = new Game() { ID = 4, Name = "The Witcher 3", Price = 240 };
            Game game5 = new Game() { ID = 5, Name = "Cyberpunk 2077", Price = 250 };

            Campaign campaign1 = new Campaign() { ID = 1, Name = "Evde Kal", DiscountRate = 26 };
            Campaign campaign2 = new Campaign() { ID = 2, Name = "Best Gamer", DiscountRate = 15 };
            Campaign campaign3 = new Campaign() { ID = 3, Name = "İlk Oyun", DiscountRate = 50 };
            Campaign campaign4 = new Campaign() { ID = 4, Name = "Yeni Üyelik", DiscountRate = 42 };
            Campaign campaign5 = new Campaign() { ID = 5, Name = "Arkadaşınla Oyna", DiscountRate = 12 };

            Console.WriteLine("\n\n*************** OYUNCULAR VE SATIN ALDIKLARI OYUNLAR ****************\n");

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(gamer1, game4);
            salesManager.Sales(gamer2, game2);
            salesManager.Sales(gamer3, game3);
            salesManager.Sales(gamer4, game1);
            salesManager.Sales(gamer5, game5);

            Console.WriteLine("\n\n*************** OYUNCULARIN KAMPANYA İLE SATIN ALDIKLARI OYUNLAR ****************\n");

            salesManager.SellCampaign(gamer1, game3, campaign5);
            salesManager.SellCampaign(gamer2, game1, campaign4);
            salesManager.SellCampaign(gamer3, game4, campaign1);
            salesManager.SellCampaign(gamer4, game5, campaign2);
            salesManager.SellCampaign(gamer5, game2, campaign3);

            Console.WriteLine("\n\n*************** SİSTEM HAREKETLERİ ****************\n");

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Update(campaign1);
            campaignManager.Delete(campaign1);

            campaignManager.Add(campaign2);
            campaignManager.Update(campaign2);
            campaignManager.Delete(campaign2);

            campaignManager.Add(campaign3);
            campaignManager.Update(campaign3);
            campaignManager.Delete(campaign3);

            campaignManager.Add(campaign4);
            campaignManager.Update(campaign4);
            campaignManager.Delete(campaign4);

            campaignManager.Add(campaign5);
            campaignManager.Update(campaign5);
            campaignManager.Delete(campaign5);

        }
    }
}
