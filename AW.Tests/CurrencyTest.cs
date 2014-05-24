using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AW.Repositories;
using NUnit.Framework;

namespace AW.Tests
{
    [TestFixture]
    public class CurrencyTest
    {
        [Test]
        public void Get_All_Currency_Name()
        {
            using (var context = new AWDataContext())
            {
                var countNames = context.Currencies.Count(x => !string.IsNullOrEmpty(x.Name));
                Assert.Greater(countNames, 0);
            }
        }
    }
}
