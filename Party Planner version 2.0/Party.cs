using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planner_version_2._0
{
    class Party
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }

        public virtual decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;
                if (NumberOfPeople > 12)
                    totalCost += 100M;
                return totalCost;
            }
        }

        private decimal CalculateCostOfDecorations()
        {
            return FancyDecorations ?
                NumberOfPeople * 15.00M + 50.00M :
                NumberOfPeople * 7.50M + 30.00M;
        }
    }
}
