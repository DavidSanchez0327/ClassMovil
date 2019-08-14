using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FundamentosXAML.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calculator : ContentPage
    {


        private String numberA;
        private String numberB;
        private String operation;
        private List<String> Listoperation = new List<string>();

        public Calculator()
        {
            InitializeComponent();
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            String number = "1";
            write(number);
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            String number = "2";
            write(number);
        }
        private void Button3_Clicked(object sender, EventArgs e)
        {
            String number = "3";
            write(number);
        }
        private void Button4_Clicked(object sender, EventArgs e)
        {
            String number = "4";
            write(number);
        }
        private void Button5_Clicked(object sender, EventArgs e)
        {
            String number = "5";
            write(number);
        }
        private void Button6_Clicked(object sender, EventArgs e)
        {
            String number = "6";
            write(number);
        }
        private void Button7_Clicked(object sender, EventArgs e)
        {
            String number = "7";
            write(number);
        }
        private void Button8_Clicked(object sender, EventArgs e)
        {
            String number = "8";
            write(number);

        }
        private void Button9_Clicked(object sender, EventArgs e)
        {
            String number = "9";
            write(number);
        }
        private void Button0_Clicked(object sender, EventArgs e)
        {
            String number = "0";
            write(number);
        }
        private void ButtonDot_Clicked(object sender, EventArgs e)
        {
            String number = ".";
            write(number);
        }

        private void ButtonC_Clicked(object sender, EventArgs e)
        {
            labelResult.Text = "0";
            labelOperations.Text = "";
        }

        private void deleteFisrTime(String number)
        {

            labelResult.Text = number;
        }
        private void write(String number)
        {
            if (labelResult.Text != "0")
            {
                labelResult.Text += number;
            }
            else
            {
                deleteFisrTime(number);
            }
        }

        private void ButtonSign_Clicked(object sender, EventArgs e)
        {
            double stringNumber = Convert.ToDouble(labelResult.Text) * -1;
            labelResult.Text = stringNumber.ToString();
        }

        private void ButtonPercent_Clicked(object sender, EventArgs e)
        {
            numberA = labelResult.Text;
            operation = "percent";
            labelOperations.Text += String.Format("{0:00}", numberA) + "%";
            Listoperation.Add(numberA);
            Listoperation.Add(operation);
            labelResult.Text = "0";

        }

        private void ButtonDiv_Clicked(object sender, EventArgs e)
        {
            numberA = labelResult.Text;
            operation = "div";
            labelOperations.Text += String.Format("{0:00}", numberA) + "/";
            Listoperation.Add(numberA);
            Listoperation.Add(operation);
            labelResult.Text = "0";
        }

        private void ButtonTimes_Clicked(object sender, EventArgs e)
        {
            numberA = labelResult.Text;
            operation = "mult";
            labelOperations.Text += String.Format("{0:00}", numberA) + "*";
            Listoperation.Add(numberA);
            Listoperation.Add(operation);
            labelResult.Text = "0";
        }

        private void ButtonMinus_Clicked(object sender, EventArgs e)
        {
            numberA = labelResult.Text;
            operation = "subs";
            labelOperations.Text += String.Format("{0:00}", numberA) + "-";
            Listoperation.Add(numberA);
            Listoperation.Add(operation);
            labelResult.Text = "0";
        }

        private void ButtonPlus_Clicked(object sender, EventArgs e)
        {
            numberA = labelResult.Text;
            operation = "sum";
            labelOperations.Text += String.Format("{0:00}", numberA) + "+";
            Listoperation.Add(numberA);
            Listoperation.Add(operation);
            labelResult.Text = "0";
        }

        private void ButtonResult_Clicked(object sender, EventArgs e)
        {
            numberB = labelResult.Text;
            labelOperations.Text += numberB;
            Listoperation.Add(numberB);
            labelResult.Text = calculate(Listoperation);
        }

        private String calculate(List<String> Listoperation)
        {
            double mewNumber = 0;
            for (int i = 0; i < Listoperation.Count; i++)
            {

                switch (Listoperation[i])
                {
                    case "percent":
                        mewNumber = mewNumber * Convert.ToDouble(Listoperation[i + 1]) / 100;
                        i++;
                        break;
                    case "div":
                        mewNumber = mewNumber / Convert.ToDouble(Listoperation[i + 1]);
                        i++;
                        break;
                    case "mult":
                        mewNumber = mewNumber * Convert.ToDouble(Listoperation[i + 1]);
                        i++;
                        break;
                    case "subs":
                        mewNumber = mewNumber - Convert.ToDouble(Listoperation[i + 1]);
                        i++;
                        break;
                    case "sum":
                        mewNumber = mewNumber + Convert.ToDouble(Listoperation[i + 1]);
                        i++;
                        break;
                    default:
                        mewNumber = Convert.ToDouble(Listoperation[i]);
                        break;
                }
            }

            return mewNumber.ToString();
        }

    }
}