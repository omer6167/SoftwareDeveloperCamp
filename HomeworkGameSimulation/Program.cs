using System;
using HomeworkGameSimulation.Abstract;
using HomeworkGameSimulation.Concrete;

namespace HomeworkGameSimulation
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Player player = new Player() { Id = 1,FirstName = "ömer",LastName = "küçük",BirthDate = new DateTime(1995,10,17),IdentityNo = "1000000000" };

            PlayerManager playerManager = new PlayerManager();
            playerManager.Add(player); 
              
            ISaleService newSale = new SaleManager();
            newSale.Sale(new Player(),new Campaign()
            {
                Duration = new DateTime(2021,10,13),Name = "NewCampaign",Price = 10
            },new Game()
            {
                Id = 1,Name = "NewGame",Price = 100
            });    

            ICampaignService campaignService = new CampaignManager();
            campaignService.Add(new Campaign());


            Console.ReadLine();
        }
    }
}
