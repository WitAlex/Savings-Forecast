using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Savings_Forecast
{
    /// <summary>
    /// Klasa obsługuje przyciski, pola tekstowe oraz radio buttony.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Domyślny konstruktor inicjalizujący komponenty.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda sprawdza czy podany znak jest cyfrą.
        /// </summary>
        /// <param name="sender">Obiekt przysyłający zdarzenie.</param>
        /// <param name="e">Informacja o tym jaki przycisk został wciśnięty.</param>
        public void isDigit(Object sender, KeyPressEventArgs e) {

            Char chr = e.KeyChar;
            if(!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter valid digit");
            }
        }
        /// <summary>
        /// Metoda ukrywa lub pokazuje pole umożliwiające wpisywanie ilości miesięcy, przez 
        /// które wykres ma rysować.
        /// </summary>
        /// <param name="sender">Obiekt przysyłający zdarzenie.</param>
        /// <param name="e">Agrumenty.</param>
        public void customTextBoxHidding(object sender, EventArgs e) {
            if (customRadioButton.Checked)
            {
                customTextBox.Visible = true;
            }
            else 
            {
                customTextBox.Visible = false;
            }
        }
        /// <summary>
        /// Metoda dodaje przychód do listy <c>earningsList</c> oraz do <c>earningsListBox</c>.
        /// Sprawdza czy wszytkie pola są uzupełnione, jeśli nie wyświetla komunikat "Enter valid values"
        /// </summary>
        /// <param name="sender">Obiekt przysyłający zdarzenie.</param>
        /// <param name="e">Argumenty.</param>
        private void addEarningsButton_Click(object sender, EventArgs e)
        {
            if (!earningsNameTextBox.Text.Equals("") && !earningsValueTextBox.Text.Equals("") && !SavingsValues.findIfEarningDuplicate(earningsNameTextBox.Text))
            {
                SavingsValues.earningsList.Add(new Earning { name = earningsNameTextBox.Text, value = float.Parse(earningsValueTextBox.Text) });
                int i = SavingsValues.earningsList.Count() - 1;
                earningsListBox.Items.Add(SavingsValues.earningsList.ElementAt(i));
                earningsNameTextBox.Text = "";
                earningsValueTextBox.Text = "";
            }
            else {
                MessageBox.Show("Enter valid values");
            }
        }

        /// <summary>
        /// Metoda dodaje wydatek do listy <c>expensesList</c> oraz <c>expensesListBox</c>.
        /// Sprawdza czy wszystkie pola są uzupełnione, jeśli nie wyświetla komunikat "Enter valid values".
        /// </summary>
        /// <param name="sender">Obiekt przysyłający zdarzenie.</param>
        /// <param name="e">Argumenty.</param>
        private void addExpensesButton_Click(object sender, EventArgs e)
        {
            if (!expensesValueTextBox.Text.Equals("") && !expensesValueTextBox.Text.Equals("") && !SavingsValues.findIfExpenseDuplicate(expensensNameTextBox.Text))
            {
                SavingsValues.expensesList.Add(new Expense { name = expensensNameTextBox.Text, value = float.Parse(expensesValueTextBox.Text) });
                int i = SavingsValues.expensesList.Count() - 1;
                expensesListBox.Items.Add(SavingsValues.expensesList.ElementAt(i));
                expensensNameTextBox.Text = "";
                expensesValueTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Enter valid values");
            }

        }

        /// <summary>
        /// Metoda zmienia wartości pól wyświetlających inforamcje na temat wydatków, przychodów i oszczędności, oraz
        /// wywołuje medtodę <c>printChart</c> z parametrem zależnym od zazaczonego Radio Buttona.
        /// </summary>
        /// <param name="sender">Obiekt przysyłający zdarzenie.</param>
        /// <param name="e">Argumenty.</param>
        private void calculateSavingsButton_Click(object sender, EventArgs e)
        {

            while (savingsChart.Series.Count > 0)
            {
                savingsChart.Series.RemoveAt(0);
            }

            if (monthRadioButton.Checked)
            {
                savingsLabel.Text = SavingsValues.calcualteSavings().ToString();
                printChart(1);
            }
            else if (halfOfYearRadioButton.Checked)
            {
                savingsLabel.Text = (6 * SavingsValues.calcualteSavings()).ToString();
                printChart(6);
            }
            else if (yearRadioButton.Checked)
            {
                savingsLabel.Text = (12 * SavingsValues.calcualteSavings()).ToString();
                printChart(12);
            }
            else 
            {
                int tmp;
                Int32.TryParse(customTextBox.Text ,out tmp);
                if (!customTextBox.Text.Equals(""))
                {
                    savingsLabel.Text = (tmp * SavingsValues.calcualteSavings()).ToString();
                    printChart(tmp);
                }
                else {
                    MessageBox.Show("Enter valid values");
                }
            }

           
            
        }

        /// <summary>
        /// Metoda ustawia kolor tekstu pola wyświetlającego szacunkową oszczędność na czerwony jeśli 
        /// jest ona mniejsza niż zero, a na zielony jeśli jest więsza.
        /// </summary>
        /// <param name="sender">Obiekt przysyłający zdarzenie.</param>
        /// <param name="e">Argumenty.</param>
        private void savingsLabel_TextChanged(object sender, EventArgs e)
        {
            if (float.Parse(savingsLabel.Text) > 0)
            {
                savingsLabel.ForeColor = Color.Green;
            }
            else {
                savingsLabel.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// Metoda usuwa zaznaczone w <c>earningsListBox</c> pole. Usuwany jest również wpis w liście 
        /// <c>earningsList</c>.
        /// </summary>
        /// <param name="sender">Obiekt przysyłający zdarzenie.</param>
        /// <param name="e">Argumenty.</param>
        private void removeEarningsButton_Click(object sender, EventArgs e)
        {
            SavingsValues.earningsList.Remove((Earning)earningsListBox.SelectedItem);
            earningsListBox.Items.RemoveAt(earningsListBox.SelectedIndex);
            
        }

        /// <summary>
        /// Metoda usuwa zaznaczone w <c>expensesListBox</c> pole. Usuwany jest również wpis w liście
        /// <c>expensesList</c>.
        /// </summary>
        /// <param name="sender">Obiekt przysyłający zdarzenie.</param>
        /// <param name="e">Argumenty.</param>
        private void removeExpensesButton_Click(object sender, EventArgs e)
        {
            SavingsValues.expensesList.Remove((Expense)expensesListBox.SelectedItem);
            expensesListBox.Items.RemoveAt(expensesListBox.SelectedIndex);
        }

        /// <summary>
        /// Tworzy serie w wykresie o podanej nazwie i kolorze.
        /// </summary>
        /// <param name="name">Nazwa jaką ma przyjąć linia stworzona w wykresie.</param>
        /// <param name="color">Kolor jaki ma przyjąć linia stworzona w wykresie.</param>
        public void createChartSeries(String name, Color color) {
            savingsChart.Series.Add(name);
            savingsChart.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            savingsChart.Series[name].Color = color;
            savingsChart.Series[name].BorderWidth = 2;
        }

        /// <summary>
        /// Metoda przesyła dane potrzeben do narysowania wykresu na przestrzeni czasu.
        /// </summary>
        /// <param name="name">Nazwa serii na której będziemy operować.</param>
        /// <param name="value">Wartość o jaką ma się zwiększać lub zmiejszać wykresu co miesiąc.</param>
        /// <param name="months">Ilość miesięcy któe mają być wgenerowane.</param>
        public void fillChartSeries(String name, float value, int months) {

            for (int i = 0; i <= months; i++)
            {
                    savingsChart.Series[name].Points.AddXY(i , i * value);
            }
        }

        /// <summary>
        /// Metoda rysuje wykresy przez określoną ilość miesięcy.
        /// </summary>
        /// <param name="i">Ilość miesięcy przez któe ma być rysowany wykres.</param>
        public void printChart(int i) {

            if (savedCheckBox.Checked) {
                createChartSeries("Saved", Color.Green);
                fillChartSeries("Saved", SavingsValues.calcualteSavings(), i);
            }
            if (expensedCheckBox.Checked) {
                createChartSeries("Expense", Color.Red);
                fillChartSeries("Expense", SavingsValues.calcualteExpenses(), i);
            }
            if (earnedCheckBox.Checked) {
                createChartSeries("Earned", Color.Blue);
                fillChartSeries("Earned", SavingsValues.calcualteEarnings(), i);
            }
            
        }
    }
}
