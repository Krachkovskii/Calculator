using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Printing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CalculatorUi;
using CommunityToolkit.Mvvm.Input;

namespace CalculatorProject.CalculatorUi;

class CalculatorViewModel : INotifyPropertyChanged
{
    private double _num1;
    private double _num2;
    private string _num1Input;
    private string _num2Input;
    private double _result;
    private UInt16 _precision;
    private bool _canDecreasePrecision = true;
    private bool _canIncreasePrecision = true;

    public double Num1
    {
        get => _num1;
        set
        {
            _num1 = value;
            OnPropertyChanged(nameof(Num1));
        }
    }

    public double Num2
    {
        get => _num2;
        set
        {
            _num2 = value;
            OnPropertyChanged(nameof(Num2));
        }
    }

    public string Num1Input
    {
        get => _num1Input;
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                _num1Input = value;
                ValidationUtils.InputNumberValidation(value);
                _num1 = double.Parse(value);
                OnPropertyChanged(nameof(Num1Input));
            }
        }
    }

    public string Num2Input
    {
        get => _num2Input;
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                _num2Input = value;
                ValidationUtils.InputNumberValidation(value);
                _num2 = double.Parse(value);
                OnPropertyChanged(nameof(Num2Input));
            }
        }
    }

    public double Result
    {
        get => _result;
        set
        {
            _result = value;
            OnPropertyChanged(nameof(Result));
        }
    }

    public UInt16 Precision
    {
        get => _precision;
        set
        {
            _precision = value;
            Calculator.Calculator.Precision = _precision;
            OnPropertyChanged(nameof(Precision));
        }
    }

    public bool CanDecreasePrecision
    {
        get => _canDecreasePrecision;
        set
        {
            if (Precision == 0)
            {
                _canDecreasePrecision = false;
                OnPropertyChanged(nameof(CanDecreasePrecision));
            }
        }
    }

    public bool CanIncreasePrecision
    {
        get => _canIncreasePrecision;
        set
        {
            if (Precision == 99)
            {
                _canIncreasePrecision = false;
                OnPropertyChanged(nameof(CanIncreasePrecision));
            }
        }
    }

    public ICommand AddCommand
    {
        get;
    }

    public ICommand SubtractCommand
    {
        get;
    }

    public ICommand MultiplyCommand
    {
        get;
    }

    public ICommand DivideCommand
    {
        get;
    }

    public ICommand PowerCommand
    {
        get;
    }

    public ICommand ChangePrecisionCommand
    {
        get;
    }

    public CalculatorViewModel()
    {
        AddCommand = new RelayCommand(Add);
        SubtractCommand = new RelayCommand(Subtract);
        MultiplyCommand = new RelayCommand(Multiply);
        DivideCommand = new RelayCommand(Divide);
        PowerCommand = new RelayCommand(Power);
        ChangePrecisionCommand = new RelayCommand<string>(ChangePrecision);

        Precision = Calculator.Calculator.Precision;
    }

    private void Add()
    {
        Result = Calculator.Calculator.Add(Num1, Num2);
    }

    private void Subtract()
    {
        Result = Calculator.Calculator.Subtract(Num1, Num2);
    }

    private void Multiply()
    {
        Result = Calculator.Calculator.Multiply(Num1, Num2);
    }

    private void Divide()
    {
        Result = Calculator.Calculator.Divide(Num1, Num2);
    }

    private void Power()
    {
        Result = Calculator.Calculator.Power(Num1, Num2);
    }

    private void ChangePrecision(string? sign)
    {
        if (sign == "+")
        {
            Precision++;
        }
        else if (sign == "-")
        {
            Precision--;
        }
    }


    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
