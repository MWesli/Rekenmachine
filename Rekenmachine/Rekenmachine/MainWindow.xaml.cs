using System;
using System.Windows;
using System.Windows.Input;

namespace RekenmachineWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            int Input = 0;
            Int32.TryParse(Solution.Text, out Input);
            string calc = Calculate_Text.Text;
            if (calc != null)
            {
                if (calc.EndsWith("+"))
                {
                    string calc2 = calc.Remove(calc.Length - 2);
                    Int32.TryParse(calc2, out int calcA);
                    int AwnserInt = calcA + Input;
                    string Awnser = AwnserInt.ToString();
                    Calculate_Text.Text = Awnser;
                    Solution.Text = "";
                }
                else if (calc.EndsWith("-"))
                {
                    string calc2 = calc.Remove(calc.Length - 2);
                    Int32.TryParse(calc2, out int calcA);
                    int AwnserInt = calcA - Input;
                    string Awnser = AwnserInt.ToString();
                    Calculate_Text.Text = Awnser;
                    Solution.Text = "";
                }
                else if (calc.EndsWith("*"))
                {
                    string calc2 = calc.Remove(calc.Length - 2);
                    Int32.TryParse(calc2, out int calcA);
                    int AwnserInt = calcA * Input;
                    string Awnser = AwnserInt.ToString();
                    Calculate_Text.Text = Awnser;
                    Solution.Text = "";
                }
                else if (calc.EndsWith("/"))
                {
                    string calc2 = calc.Remove(calc.Length - 2);
                    Int32.TryParse(calc2, out int calcA);
                    int AwnserInt = calcA / Input;
                    string Awnser = AwnserInt.ToString();
                    Calculate_Text.Text = Awnser;
                    Solution.Text = "";
                }
                else
                {
                    Calculate_Text.Text += Solution.Text;
                    Solution.Text = "";
                }
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.NumPad0) || Keyboard.IsKeyDown(Key.D0))
            {
                string Input = Solution.Text;
                Solution.Text = Input + "0";
            }
            if (Keyboard.IsKeyDown(Key.NumPad1) || Keyboard.IsKeyDown(Key.D1))
            {
                string Input = Solution.Text;
                Solution.Text = Input + "1";
            }
            if (Keyboard.IsKeyDown(Key.NumPad2) || Keyboard.IsKeyDown(Key.D2))
            {
                string Input = Solution.Text;
                Solution.Text = Input + "2";
            }
            if (Keyboard.IsKeyDown(Key.NumPad3) || Keyboard.IsKeyDown(Key.D3))
            {
                string Input = Solution.Text;
                Solution.Text = Input + "3";
            }
            if (Keyboard.IsKeyDown(Key.NumPad4) || Keyboard.IsKeyDown(Key.D4))
            {
                string Input = Solution.Text;
                Solution.Text = Input + "4";
            }
            if (Keyboard.IsKeyDown(Key.NumPad5) || Keyboard.IsKeyDown(Key.D5))
            {
                string Input = Solution.Text;
                Solution.Text = Input + "5";
            }
            if (Keyboard.IsKeyDown(Key.NumPad6) || Keyboard.IsKeyDown(Key.D6))
            {
                string Input = Solution.Text;
                Solution.Text = Input + "6";
            }
            if (Keyboard.IsKeyDown(Key.NumPad7) || Keyboard.IsKeyDown(Key.D7))
            {
                string Input = Solution.Text;
                Solution.Text = Input + "7";
            }
            if (Keyboard.IsKeyDown(Key.NumPad8) || Keyboard.IsKeyDown(Key.D8))
            {
                string Input = Solution.Text;
                Solution.Text = Input + "8";
            }
            if (Keyboard.IsKeyDown(Key.NumPad9) || Keyboard.IsKeyDown(Key.D9))
            {
                string Input = Solution.Text;
                Solution.Text = Input + "9";
            }
            if (Keyboard.IsKeyDown(Key.Add))
            {
                int Input = 0;
                Int32.TryParse(Solution.Text, out Input);
                string calc = Calculate_Text.Text;
                if (calc != null)
                {
                    if (calc.EndsWith("+"))
                    {
                        string calc2 = calc.Remove(calc.Length - 2);
                        Int32.TryParse(calc2, out int calcA);
                        int AwnserInt = calcA + Input;
                        string Awnser = AwnserInt.ToString();
                        Calculate_Text.Text = Awnser + " +";
                        Solution.Text = "";
                    }
                    else if (calc.EndsWith("-"))
                    {
                        string calc2 = calc.Remove(calc.Length - 2);
                        Int32.TryParse(calc2, out int calcA);
                        int AwnserInt = calcA - Input;
                        string Awnser = AwnserInt.ToString();
                        Calculate_Text.Text = Awnser + " +";
                        Solution.Text = "";
                    }
                    else if (calc.EndsWith("*"))
                    {
                        string calc2 = calc.Remove(calc.Length - 2);
                        Int32.TryParse(calc2, out int calcA);
                        int AwnserInt = calcA * Input;
                        string Awnser = AwnserInt.ToString();
                        Calculate_Text.Text = Awnser + " +";
                        Solution.Text = "";
                    }
                    else if (calc.EndsWith("/"))
                    {
                        string calc2 = calc.Remove(calc.Length - 2);
                        Int32.TryParse(calc2, out int calcA);
                        int AwnserInt = calcA / Input;
                        string Awnser = AwnserInt.ToString();
                        Calculate_Text.Text = Awnser + " +";
                        Solution.Text = "";
                    }
                    else
                    {
                        if (calc == "")
                        {
                            Calculate_Text.Text = Solution.Text + " +";
                            Solution.Text = "";
                        }
                        else
                        {
                            Calculate_Text.Text += " +";
                            Solution.Text = "";
                        }
                    }
                }
            }
            if (Keyboard.IsKeyDown(Key.Multiply))
            {
                int Input = 0;
                Int32.TryParse(Solution.Text, out Input);
                string calc = Calculate_Text.Text;
                if (calc != null)
                {
                    if (calc.EndsWith("+"))
                    {
                        string calc2 = calc.Remove(calc.Length - 2);
                        Int32.TryParse(calc2, out int calcA);
                        int AwnserInt = calcA + Input;
                        string Awnser = AwnserInt.ToString();
                        Calculate_Text.Text = Awnser + " *";
                        Solution.Text = "";
                    }
                    else if (calc.EndsWith("-"))
                    {
                        string calc2 = calc.Remove(calc.Length - 2);
                        Int32.TryParse(calc2, out int calcA);
                        int AwnserInt = calcA - Input;
                        string Awnser = AwnserInt.ToString();
                        Calculate_Text.Text = Awnser + " *";
                        Solution.Text = "";
                    }
                    else if (calc.EndsWith("*"))
                    {
                        string calc2 = calc.Remove(calc.Length - 2);
                        Int32.TryParse(calc2, out int calcA);
                        int AwnserInt = calcA * Input;
                        string Awnser = AwnserInt.ToString();
                        Calculate_Text.Text = Awnser + " *";
                        Solution.Text = "";
                    }
                    else if (calc.EndsWith("/"))
                    {
                        string calc2 = calc.Remove(calc.Length - 2);
                        Int32.TryParse(calc2, out int calcA);
                        int AwnserInt = calcA / Input;
                        string Awnser = AwnserInt.ToString();
                        Calculate_Text.Text = Awnser + " *";
                        Solution.Text = "";
                    }
                    else
                    {
                        if (calc == "")
                        {
                            Calculate_Text.Text = Solution.Text + " *";
                            Solution.Text = "";
                        }
                        else
                        {
                            Calculate_Text.Text += " *";
                            Solution.Text = "";
                        }
                    }
                }
            }
            if (Keyboard.IsKeyDown(Key.Subtract))
            {
                int Input = 0;
                Int32.TryParse(Solution.Text, out Input);
                string calc = Calculate_Text.Text;
                if (calc != null)
                {
                    if (calc.EndsWith("+"))
                    {
                        string calc2 = calc.Remove(calc.Length - 2);
                        Int32.TryParse(calc2, out int calcA);
                        int AwnserInt = calcA + Input;
                        string Awnser = AwnserInt.ToString();
                        Calculate_Text.Text = Awnser + " -";
                        Solution.Text = "";
                    }
                    else if (calc.EndsWith("-"))
                    {
                        string calc2 = calc.Remove(calc.Length - 2);
                        Int32.TryParse(calc2, out int calcA);
                        int AwnserInt = calcA - Input;
                        string Awnser = AwnserInt.ToString();
                        Calculate_Text.Text = Awnser + " -";
                        Solution.Text = "";
                    }
                    else if (calc.EndsWith("*"))
                    {
                        string calc2 = calc.Remove(calc.Length - 2);
                        Int32.TryParse(calc2, out int calcA);
                        int AwnserInt = calcA * Input;
                        string Awnser = AwnserInt.ToString();
                        Calculate_Text.Text = Awnser + " -";
                        Solution.Text = "";
                    }
                    else if (calc.EndsWith("/"))
                    {
                        string calc2 = calc.Remove(calc.Length - 2);
                        Int32.TryParse(calc2, out int calcA);
                        int AwnserInt = calcA / Input;
                        string Awnser = AwnserInt.ToString();
                        Calculate_Text.Text = Awnser + " -";
                        Solution.Text = "";
                    }
                    else
                    {
                        if (calc == "")
                        {
                            Calculate_Text.Text = Solution.Text + " -";
                            Solution.Text = "";
                        }
                        else
                        {
                            Calculate_Text.Text += " -";
                            Solution.Text = "";
                        }
                    }
                }
            }
            if (Keyboard.IsKeyDown(Key.Divide))
            {
                int Input = 0;
                Int32.TryParse(Solution.Text, out Input);
                string calc = Calculate_Text.Text;
                if (calc != null)
                {
                    if (calc.EndsWith("+"))
                    {
                        string calc2 = calc.Remove(calc.Length - 2);
                        Int32.TryParse(calc2, out int calcA);
                        int AwnserInt = calcA + Input;
                        string Awnser = AwnserInt.ToString();
                        Calculate_Text.Text = Awnser + " /";
                        Solution.Text = "";
                    }
                    else if (calc.EndsWith("-"))
                    {
                        string calc2 = calc.Remove(calc.Length - 2);
                        Int32.TryParse(calc2, out int calcA);
                        int AwnserInt = calcA - Input;
                        string Awnser = AwnserInt.ToString();
                        Calculate_Text.Text = Awnser + " /";
                        Solution.Text = "";
                    }
                    else if (calc.EndsWith("*"))
                    {
                        string calc2 = calc.Remove(calc.Length - 2);
                        Int32.TryParse(calc2, out int calcA);
                        int AwnserInt = calcA * Input;
                        string Awnser = AwnserInt.ToString();
                        Calculate_Text.Text = Awnser + " /";
                        Solution.Text = "";
                    }
                    else if (calc.EndsWith("/"))
                    {
                        string calc2 = calc.Remove(calc.Length - 2);
                        Int32.TryParse(calc2, out int calcA);
                        int AwnserInt = calcA / Input;
                        string Awnser = AwnserInt.ToString();
                        Calculate_Text.Text = Awnser + " /";
                        Solution.Text = "";
                    }
                    else
                    {
                        if (calc == "")
                        {
                            Calculate_Text.Text = Solution.Text + " /";
                            Solution.Text = "";
                        }
                        else
                        {
                            Calculate_Text.Text += " /";
                            Solution.Text = "";
                        }
                    }
                }
            }
            if (Keyboard.IsKeyDown(Key.Decimal))
            {
                string Input = Solution.Text;
                Solution.Text = Input + ".";
            }
            if (Keyboard.IsKeyDown(Key.Return))
            {
                int Input = 0;
                Int32.TryParse(Solution.Text, out Input);
                string calc = Calculate_Text.Text;
                if (calc != null)
                {
                    if (calc.EndsWith("+"))
                    {
                        string calc2 = calc.Remove(calc.Length - 2);
                        Int32.TryParse(calc2, out int calcA);
                        int AwnserInt = calcA + Input;
                        string Awnser = AwnserInt.ToString();
                        Calculate_Text.Text = Awnser;
                        Solution.Text = "";
                    }
                    else if (calc.EndsWith("-"))
                    {
                        string calc2 = calc.Remove(calc.Length - 2);
                        Int32.TryParse(calc2, out int calcA);
                        int AwnserInt = calcA - Input;
                        string Awnser = AwnserInt.ToString();
                        Calculate_Text.Text = Awnser;
                        Solution.Text = "";
                    }
                    else if (calc.EndsWith("*"))
                    {
                        string calc2 = calc.Remove(calc.Length - 2);
                        Int32.TryParse(calc2, out int calcA);
                        int AwnserInt = calcA * Input;
                        string Awnser = AwnserInt.ToString();
                        Calculate_Text.Text = Awnser;
                        Solution.Text = "";
                    }
                    else if (calc.EndsWith("/"))
                    {
                        string calc2 = calc.Remove(calc.Length - 2);
                        Int32.TryParse(calc2, out int calcA);
                        int AwnserInt = calcA / Input;
                        string Awnser = AwnserInt.ToString();
                        Calculate_Text.Text = Awnser;
                        Solution.Text = "";
                    }
                    else
                    {
                        if (calc == "")
                        {
                            Calculate_Text.Text = Solution.Text;
                            Solution.Text = "";
                        }
                        else
                        {
                            Solution.Text = "";
                        }
                    }
                }
            }
            if (Keyboard.IsKeyDown(Key.Back))
            {
                if (Solution.Text != "")
                {
                    string Original = Solution.Text;
                    string New = Original.Remove(Original.Length - 1);
                    Solution.Text = New;
                }
            }
        }

        private void N0_Click(object sender, RoutedEventArgs e)
        {
            string Input = Solution.Text;
            Solution.Text = Input + "0";
        }

        private void N1_Click(object sender, RoutedEventArgs e)
        {
            string Input = Solution.Text;
            Solution.Text = Input + "1";
        }

        private void N2_Click(object sender, RoutedEventArgs e)
        {
            string Input = Solution.Text;
            Solution.Text = Input + "2";
        }

        private void N3_Click(object sender, RoutedEventArgs e)
        {
            string Input = Solution.Text;
            Solution.Text = Input + "3";
        }

        private void N4_Click(object sender, RoutedEventArgs e)
        {
            string Input = Solution.Text;
            Solution.Text = Input + "4";
        }

        private void N5_Click(object sender, RoutedEventArgs e)
        {
            string Input = Solution.Text;
            Solution.Text = Input + "5";
        }

        private void N6_Click(object sender, RoutedEventArgs e)
        {
            string Input = Solution.Text;
            Solution.Text = Input + "6";
        }

        private void N7_Click(object sender, RoutedEventArgs e)
        {
            string Input = Solution.Text;
            Solution.Text = Input + "7";
        }

        private void N8_Click(object sender, RoutedEventArgs e)
        {
            string Input = Solution.Text;
            Solution.Text = Input + "8";
        }

        private void N9_Click(object sender, RoutedEventArgs e)
        {
            string Input = Solution.Text;
            Solution.Text = Input + "9";
        }

        private void Delen_Click(object sender, RoutedEventArgs e)
        {
            int Input = 0;
            Int32.TryParse(Solution.Text, out Input);
            string calc = Calculate_Text.Text;
            if (calc != null)
            {
                if (calc.EndsWith("+"))
                {
                    string calc2 = calc.Remove(calc.Length - 2);
                    Int32.TryParse(calc2, out int calcA);
                    int AwnserInt = calcA + Input;
                    string Awnser = AwnserInt.ToString();
                    Calculate_Text.Text = Awnser + " /";
                    Solution.Text = "";
                }
                else if (calc.EndsWith("-"))
                {
                    string calc2 = calc.Remove(calc.Length - 2);
                    Int32.TryParse(calc2, out int calcA);
                    int AwnserInt = calcA - Input;
                    string Awnser = AwnserInt.ToString();
                    Calculate_Text.Text = Awnser + " /";
                    Solution.Text = "";
                }
                else if (calc.EndsWith("*"))
                {
                    string calc2 = calc.Remove(calc.Length - 2);
                    Int32.TryParse(calc2, out int calcA);
                    int AwnserInt = calcA * Input;
                    string Awnser = AwnserInt.ToString();
                    Calculate_Text.Text = Awnser + " /";
                    Solution.Text = "";
                }
                else if (calc.EndsWith("/"))
                {
                    string calc2 = calc.Remove(calc.Length - 2);
                    Int32.TryParse(calc2, out int calcA);
                    int AwnserInt = calcA / Input;
                    string Awnser = AwnserInt.ToString();
                    Calculate_Text.Text = Awnser + " /";
                    Solution.Text = "";
                }
                else
                {
                    Calculate_Text.Text += " /";
                    Solution.Text = "";
                }
            }
        }

        private void Keer_Click(object sender, RoutedEventArgs e)
        {
            int Input = 0;
            Int32.TryParse(Solution.Text, out Input);
            string calc = Calculate_Text.Text;
            if (calc != null)
            {
                if (calc.EndsWith("+"))
                {
                    string calc2 = calc.Remove(calc.Length - 2);
                    Int32.TryParse(calc2, out int calcA);
                    int AwnserInt = calcA + Input;
                    string Awnser = AwnserInt.ToString();
                    Calculate_Text.Text = Awnser + " *";
                    Solution.Text = "";
                }
                else if (calc.EndsWith("-"))
                {
                    string calc2 = calc.Remove(calc.Length - 2);
                    Int32.TryParse(calc2, out int calcA);
                    int AwnserInt = calcA - Input;
                    string Awnser = AwnserInt.ToString();
                    Calculate_Text.Text = Awnser + " *";
                    Solution.Text = "";
                }
                else if (calc.EndsWith("*"))
                {
                    string calc2 = calc.Remove(calc.Length - 2);
                    Int32.TryParse(calc2, out int calcA);
                    int AwnserInt = calcA * Input;
                    string Awnser = AwnserInt.ToString();
                    Calculate_Text.Text = Awnser + " *";
                    Solution.Text = "";
                }
                else if (calc.EndsWith("/"))
                {
                    string calc2 = calc.Remove(calc.Length - 2);
                    Int32.TryParse(calc2, out int calcA);
                    int AwnserInt = calcA / Input;
                    string Awnser = AwnserInt.ToString();
                    Calculate_Text.Text = Awnser + " *";
                    Solution.Text = "";
                }
                else
                {
                    Calculate_Text.Text += " *";
                    Solution.Text = "";
                }
            }
        }

        private void Min_Click(object sender, RoutedEventArgs e)
        {
            int Input = 0;
            Int32.TryParse(Solution.Text, out Input);
            string calc = Calculate_Text.Text;
            if (calc != null)
            {
                if (calc.EndsWith("+"))
                {
                    string calc2 = calc.Remove(calc.Length - 2);
                    Int32.TryParse(calc2, out int calcA);
                    int AwnserInt = calcA + Input;
                    string Awnser = AwnserInt.ToString();
                    Calculate_Text.Text = Awnser + " -";
                    Solution.Text = "";
                }
                else if (calc.EndsWith("-"))
                {
                    string calc2 = calc.Remove(calc.Length - 2);
                    Int32.TryParse(calc2, out int calcA);
                    int AwnserInt = calcA - Input;
                    string Awnser = AwnserInt.ToString();
                    Calculate_Text.Text = Awnser + " -";
                    Solution.Text = "";
                }
                else if (calc.EndsWith("*"))
                {
                    string calc2 = calc.Remove(calc.Length - 2);
                    Int32.TryParse(calc2, out int calcA);
                    int AwnserInt = calcA * Input;
                    string Awnser = AwnserInt.ToString();
                    Calculate_Text.Text = Awnser + " -";
                    Solution.Text = "";
                }
                else if (calc.EndsWith("/"))
                {
                    string calc2 = calc.Remove(calc.Length - 2);
                    Int32.TryParse(calc2, out int calcA);
                    int AwnserInt = calcA / Input;
                    string Awnser = AwnserInt.ToString();
                    Calculate_Text.Text = Awnser + " -";
                    Solution.Text = "";
                }
                else
                {
                    Calculate_Text.Text += " -";
                    Solution.Text = "";
                }
            }
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            int Input = 0;
            Int32.TryParse(Solution.Text, out Input);
            string calc = Calculate_Text.Text;
            if (calc != null)
            {
                if (calc.EndsWith("+"))
                {
                    string calc2 = calc.Remove(calc.Length - 2);
                    Int32.TryParse(calc2, out int calcA);
                    int AwnserInt = calcA + Input;
                    string Awnser = AwnserInt.ToString();
                    Calculate_Text.Text = Awnser + " +";
                    Solution.Text = "";
                }
                else if (calc.EndsWith("-"))
                {
                    string calc2 = calc.Remove(calc.Length - 2);
                    Int32.TryParse(calc2, out int calcA);
                    int AwnserInt = calcA - Input;
                    string Awnser = AwnserInt.ToString();
                    Calculate_Text.Text = Awnser + " +";
                    Solution.Text = "";
                }
                else if (calc.EndsWith("*"))
                {
                    string calc2 = calc.Remove(calc.Length - 2);
                    Int32.TryParse(calc2, out int calcA);
                    int AwnserInt = calcA * Input;
                    string Awnser = AwnserInt.ToString();
                    Calculate_Text.Text = Awnser + " +";
                    Solution.Text = "";
                }
                else if (calc.EndsWith("/"))
                {
                    string calc2 = calc.Remove(calc.Length - 2);
                    Int32.TryParse(calc2, out int calcA);
                    int AwnserInt = calcA / Input;
                    string Awnser = AwnserInt.ToString();
                    Calculate_Text.Text = Awnser + " +";
                    Solution.Text = "";
                }
                else
                {
                    Calculate_Text.Text += " +";
                    Solution.Text = "";
                }
            }
        }

        private void Decimal_Click(object sender, RoutedEventArgs e)
        {
            string Input = Solution.Text;
            Solution.Text = Input + ".";
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            if (Solution.Text != "")
            {
                string Original = Solution.Text;
                string New = Original.Remove(Original.Length - 1);
                Solution.Text = New;
            }
        }

        private void C_Button_Click(object sender, RoutedEventArgs e)
        {
            Solution.Text = "";
        }

        private void CEButton_Click(object sender, RoutedEventArgs e)
        {
            Solution.Text = "";
            Calculate_Text.Text = "";
        }
    }
}
