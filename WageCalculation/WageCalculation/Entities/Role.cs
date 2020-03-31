using System;
using System.Collections.Generic;
using System.Text;
using WageCalculation.Interfaces;

namespace WageCalculation.Entities
{
    public class Role
    {
        private TenOrTwentyPercent tenOrTwentyPercent;
        private FifteenOrTwentyPercent fifteenOrTwentyPercent;

        public Role(TenOrTwentyPercent tenOrTwentyPercent)
        {
            this.tenOrTwentyPercent = tenOrTwentyPercent;
        }

        public Role(FifteenOrTwentyPercent fifteenOrTwentyPercent)
        {
            this.fifteenOrTwentyPercent = fifteenOrTwentyPercent;
        }

        public Role DEVELOPER
        { get { return new Role(new TenOrTwentyPercent()); } }

        public Role DBA
        { get { return new Role(new FifteenOrTwentyPercent()); } }

        public Role TESTER
        { get { return new Role(new FifteenOrTwentyPercent()); } }

        public object Rule { get; internal set; }
    }
}
