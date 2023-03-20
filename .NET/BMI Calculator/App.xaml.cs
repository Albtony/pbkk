namespace BMI_Calculator;

public partial class App : Application
{
    public static BMIRepository BMIRepo { get; private set; }
    public App(BMIRepository repo)
	{
		InitializeComponent();

		MainPage = new AppShell();

		BMIRepo = repo;
	}
}
