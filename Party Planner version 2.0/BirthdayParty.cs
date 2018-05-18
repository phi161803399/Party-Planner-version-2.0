using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planner_version_2._0
{
    class BirthdayParty: Party
    {
        public string CakeWriting { get; set; }

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }

        private int ActualLength
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                {
                    return MaxWritingLength();
                }
                else
                {
                    return CakeWriting.Length;
                }
            }
            set
            {

            }
        }

        private int CakeSize()
        {
            return NumberOfPeople <= 4 ? 8 : 16;
        }

        private int MaxWritingLength()
        {
            if (CakeSize() == 8)
                return 16;
            return 40;
        }

        public bool CakeWritingTooLong
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return true;
                return false;
            }
        }

        public override decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                decimal cakeCost;
                if (CakeSize() == 8)
                    cakeCost = 40M + ActualLength * .25M;
                else
                {
                    cakeCost = 75M + ActualLength * .25M;
                }
                return totalCost + cakeCost;
            }
        }
    }
}
