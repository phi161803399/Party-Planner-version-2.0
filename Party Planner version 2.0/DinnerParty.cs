using System;

namespace Party_Planner_version_2._0
{
    class DinnerParty: Party
    {
        public bool HealthyOptions { get; set; }

        public override decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += NumberOfPeople *
                             (CalculateCostOfBeveragesPerPerson() + CostOfFoodPerPerson);
                if (HealthyOptions)
                    totalCost *= 0.95M;
                if (NumberOfPeople > 12)
                    totalCost += 100M;
                return totalCost;
            }
        }

        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOptions)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOptions = healthyOptions;
        }

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            return HealthyOptions ? 5.00M : 20.00M;
        }
    }
}