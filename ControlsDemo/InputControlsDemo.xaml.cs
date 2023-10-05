namespace ControlsDemo;

public partial class InputControlsDemo : ContentPage
{
	public InputControlsDemo()
	{
		InitializeComponent();
	}

	private	void OnCheckBoxCheckedChanged(object sender, EventArgs e)
	{
		if ( check1.IsChecked )
		{

			etykieta.Text = "Zaznaczony";
		}
		else
		{
            etykieta.Text = "Brak";
        }
	}

     private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
     {
		if (slider.Value > 50)
		{
			
				lblSlider.Text = "pozycja na ekranie wiêksza od 50: " + slider.Value.ToString();
		}
		else
		{
            lblSlider.Text = "pozycja na ekranie mniejsza od 50: " + slider.Value.ToString();

        }

    }
		private void przelacznik(object sender, EventArgs e)
	{
        if (prze.IsToggled)
        {

            etykieta2.Text = "Zaznaczony";
        }
        else
        {
            etykieta2.Text = "Brak";
        }

    }

     private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
     {
		  if (stepper != null)
		  {
			   lblSlider.Text = stepper.Value.ToString();
		  }
	 }
}