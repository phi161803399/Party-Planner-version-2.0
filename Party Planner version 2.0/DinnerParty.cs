using System;

namespace Party_Planner_version_2._0
{
    class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOptions { get; set; }

        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += NumberOfPeople *
                             (CalculateCostOfBeveragesPerPerson() + CostOfFoodPerPerson);
                if (HealthyOptions)
                    totalCost *= 0.95M;
                return totalCost;
            }
        }

        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOptions)
        {
            Console.Write(this.Cost);
            Console.Write(CalculateCostOfDecorations());

            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOptions = healthyOptions;
        }

        private decimal CalculateCostOfDecorations()
        {
            return FancyDecorations ?
                NumberOfPeople * 15.00M + 50.00M :
                NumberOfPeople * 7.50M + 30.00M;
        }

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            return HealthyOptions ? 5.00M : 20.00M;
        }
    }
}