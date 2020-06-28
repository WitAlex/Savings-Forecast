using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savings_Forecast
{
    /// <summary> Klasa <c>SavingsValues</c> odpowiada za zarządza listami <c>expensesList</c> i <c>earningsList</c> 
    /// w ktróych zapisne są inforamcje na temat wydatków i przychodów.
    /// </summary> 
    /// 
    static public class SavingsValues
    {
        /// <summary>
        /// Lista przechowuje listę wydatków.
        /// </summary>
        public static List<Expense> expensesList = new List<Expense>();

        /// <summary>
        /// Lista przechowuje listę przychodów.
        /// </summary>
        public static List<Earning> earningsList = new List<Earning>();

        /// <summary>
        /// Metoda oblicza szacunkowe oszczędności na podstawie informacji zwarcanych przez 
        /// metody <c>calcualteEarnings</c> i <c>calcualteExpenses</c> . 
        /// </summary>
        /// <returns> Zwraca sume oszczędności.</returns>
        public static float calcualteSavings() {

          
            return calcualteEarnings() - calcualteExpenses();
        }

        /// <summary>
        /// Metoda oblicza przychody na podstawie informacji z listy <c>earningsList</c>.
        /// </summary>
        /// <returns> Zwraca sume przychodów.</returns>
        public static float calcualteEarnings()
        {

            float earningsSum = 0;

            foreach (Earning earning in earningsList)
            {
                earningsSum += earning.value;
            }

            return earningsSum ;
        }

        /// <summary>
        /// Metoda oblicza wydatki na podstawie informacji z listy <c>expensesList</c>.
        /// </summary>
        /// <returns> Zwraca sume wydatków.</returns>
        public static float calcualteExpenses()
        {

            float expensesSum = 0;

            foreach (Expense expense in expensesList)
            {
                expensesSum += expense.value;
            }

            return expensesSum;
        }

        /// <summary>
        /// Metoda sprawdza czy nazwa podanego wydatku występuje już w liście <c>expensesList</c>
        /// </summary>
        /// <param name="name">Nazwa która ma być sprawdzona</param>
        /// <returns>Zwarac true jeśli nazwa się powtarza, false gdy nie.</returns>
        public static bool findIfExpenseDuplicate(String name) {
            foreach (Expense expense in expensesList) {
                if (name.Equals(expense.name)) {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Metoda sprawdza czy nazwa podanego przychodu występuje już w liście <c>earningsList</c>.
        /// </summary>
        /// <param name="name">Nazwa która ma być sprawdzona.</param>
        /// <returns>Zwarac true jeśli nazwa się powtarza, false gdy nie.</returns>
        public static bool findIfEarningDuplicate(String name)
        {
            foreach (Earning earning in earningsList)
            {
                if (name.Equals(earning.name))
                {
                    return true;
                }
            }
            return false;
        }
    }

    /// <summary>
    /// Klasa przechowująca nazwe i wartość pojedyńczego wydatku.
    /// </summary>
    public class Expense
    {
        /// <summary>
        /// Nazwa wydatku.
        /// </summary>
        public String name;

        /// <summary>
        /// Wartość wydatku.
        /// </summary>
        public float value;

        public override string ToString()
        {
            return name + " - " + value + "PLN";
        }
    }

    /// <summary>
    /// Klasa przechowująca nazwe i wartość pojedyńczego przychodu.
    /// </summary>
    public class Earning
    {
        /// <summary>
        /// Nazwa przychodu.
        /// </summary>
        public String name;

        /// <summary>
        /// Wartość przychodu.
        /// </summary>
        public float value;
        public override string ToString()
        {
            return name + " - " + value + "PLN";
        }
    }


}
