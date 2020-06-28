using Microsoft.VisualStudio.TestTools.UnitTesting;

using Savings_Forecast;

namespace SavingValuesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalculateEarnings()
        {
            float earnig1 = 100;
            float earnig2 = 200; 
            float earnig3 = 300;
            float expected = 600;

            SavingsValues.earningsList.Clear();
            SavingsValues.earningsList.Add(new Earning { name = "earnig1", value = earnig1});
            SavingsValues.earningsList.Add(new Earning { name = "earnig2", value = earnig2});
            SavingsValues.earningsList.Add(new Earning { name = "earnig3", value = earnig3});
            float actual = SavingsValues.calcualteEarnings();

            Assert.AreEqual(expected, actual, "Sum of earnings wrong!");
        }

        [TestMethod]
        public void TestCalculateExpenses()
        {

            float expense1 = 100;
            float expense2 = 200;
            float expense3 = 300;
            float expected = 600;

            SavingsValues.expensesList.Clear();
            SavingsValues.expensesList.Add(new Expense { name = "expense1", value = expense1 });
            SavingsValues.expensesList.Add(new Expense { name = "expense2", value = expense2 });
            SavingsValues.expensesList.Add(new Expense { name = "expense3", value = expense3 });
            float actual = SavingsValues.calcualteExpenses();

            Assert.AreEqual(expected, actual, "Sum of expenses wrong!");
        }

        [TestMethod]
        public void TestFindIfExpenseDuplicate()
        {
            string name = "DuplicateMe";
            string name2 = "Example";
            Expense expense1 = new Expense { name = name, value = 100 };
            bool expected = true;
            bool expected2 = false;

            SavingsValues.expensesList.Clear();
            SavingsValues.expensesList.Add( expense1 );
            bool actual = SavingsValues.findIfExpenseDuplicate(name);
            bool actual2 = SavingsValues.findIfExpenseDuplicate(name2);

            Assert.AreEqual(expected, actual, "Wrong info about duplicate!");
            Assert.AreEqual(expected2, actual2, "Wrong info about duplicate!");
            
        }

        [TestMethod]
        public void TestFindIfEarningDuplicate()
        {
            string name = "DuplicateMe";
            string name2 = "Example";
            Earning earnig1 = new Earning { name = name, value = 100 };
            bool expected = true;
            bool expected2 = false;

            SavingsValues.earningsList.Clear();
            SavingsValues.earningsList.Add(earnig1);
            bool actual = SavingsValues.findIfEarningDuplicate(name);
            bool actual2 = SavingsValues.findIfEarningDuplicate(name2);

            Assert.AreEqual(expected, actual, "Wrong info about duplicate!");
            Assert.AreEqual(expected2, actual2, "Wrong info about duplicate!");
        }

        [TestMethod]
        public void TestCalcualteSavings()
        {

            float expense1 = 100;
            float expense2 = 200;
            float earning1 = 300;
            float earning2= 400;
            float expected = 400;

            SavingsValues.expensesList.Clear();
            SavingsValues.earningsList.Clear();
            SavingsValues.expensesList.Add(new Expense { name = "expense1", value = expense1 });
            SavingsValues.expensesList.Add(new Expense { name = "expense2", value = expense2 });
            SavingsValues.earningsList.Add(new Earning { name = "earning1", value = earning1 });
            SavingsValues.earningsList.Add(new Earning { name = "earning2", value = earning2 });
            float actual = SavingsValues.calcualteSavings();

            Assert.AreEqual(expected, actual, "Sum of savings wrong!");
        }
    }
}
