using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jumper.Data
{
    public class DataAccess
    {
        public delegate void RefreshListDelegate();
        public static event RefreshListDelegate RefreshList;
        public static IEnumerable<Agent> GetAgents()
        {
            return JumperMishaEntities.GetContext().Agents.ToList();
        }

        public static List<AgentType> GetAgentTypes()
        {
            return JumperMishaEntities.GetContext().AgentTypes.ToList();
        }

        public static List<Product> GetProducts()
        {
            return JumperMishaEntities.GetContext().Products.ToList();
        }

        public static void SaveAgent(Agent agent)
        {
            if (agent.ID == 0)
                JumperMishaEntities.GetContext().Agents.Add(agent);
            JumperMishaEntities.GetContext().SaveChanges();
            RefreshList?.Invoke();
        }

        public static void DeleteAgent(Agent agent)
        {
            JumperMishaEntities.GetContext().Agents.Remove(agent);
            JumperMishaEntities.GetContext().SaveChanges();
            RefreshList?.Invoke();
        }

        public static void DeleteProductSale(ProductSale product)
        {
            JumperMishaEntities.GetContext().ProductSales.Remove(product);
            JumperMishaEntities.GetContext().SaveChanges();
            RefreshList?.Invoke();
        }
    }
}
