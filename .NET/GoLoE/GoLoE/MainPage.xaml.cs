namespace GoLoE;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void onCompare(object sender, EventArgs e)
	{
		int leftNumber = int.Parse(InputLeftNumber.Text);
		int rightNumber = int.Parse(InputRightNumber.Text);

		string status = "equal to";

		if(leftNumber > rightNumber)
		{
			status = "greater than";
		} else if(leftNumber < rightNumber)
		{
			status = "lower than";
		} 

		ResultLabel.Text = String.Format("{0} is {1} {2}!", rightNumber, status, leftNumber);
	}
}

