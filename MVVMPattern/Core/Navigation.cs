using System.Diagnostics;
using System.Windows.Controls;
using System;
using MVVMPattern.View;

public class Navigation
{
    private readonly Frame _frame;
    public string Title { get; set; }

    public Navigation(Frame frame)
    {
        _frame = frame;
    }

    public void NavigateTo(object param, object dataContext)
    {
        string pageName = param.ToString();
        Page page;

        switch (pageName)
        {
            case "AuthPage":
                page = new AuthPage();
                break;
            case "MainPage":
                page = new MainPage();
                break;
            case "RegistrationPage":
                page = new RegistrationPage();
                break;
            default:
                throw new ArgumentException("Неизвестная страница ", nameof(pageName));
        }

        page.DataContext = dataContext;
        _frame.Navigate(page);
    }
}