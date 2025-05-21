namespace MauiAppHotel1.Views
{
    public partial class ContratacaoHospedagem : ContentPage
    {
        App PropriedadesApp;


        public ContratacaoHospedagem()
        {
            InitializeComponent();

            PropriedadesApp = (App)Application.Current;

            pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

            dtpck_chekin.MinimumDate = DateTime.Today;
            dtpck_chekin.MaximumDate = DateTime.Today.AddMonths(3);
            dtpck_chekin.Date = DateTime.Today;

            dtpck_chekout.MinimumDate = dtpck_chekin.Date.AddDays(1);
            dtpck_chekout.MaximumDate = dtpck_chekin.Date.AddMonths(6);
            dtpck_chekout.Date = DateTime.Today;

        }

        private async void sobreClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sobre());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new HospedagemContratada());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void dtpck_chekin_DateSelected(object sender, DateChangedEventArgs e)
        {
            DatePicker elemento = sender as DatePicker;

            DateTime data_selecionada_do_checkin = elemento.Date;
                      
            dtpck_chekout.MinimumDate = data_selecionada_do_checkin.AddDays(1);
            dtpck_chekout.MaximumDate = data_selecionada_do_checkin.AddMonths(6);
        }
    }
}
