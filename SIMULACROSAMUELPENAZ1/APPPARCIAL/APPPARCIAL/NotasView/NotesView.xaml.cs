using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using APPPARCIAL.NotasViewModel;
namespace APPPARCIAL.NotasView
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NotesView : ContentPage
	{
		public NotesView ()
		{
			InitializeComponent ();
		}

        private void BInsertar_Clicked(object sender, EventArgs e)
        {
            StatusMessage.Text = string.Empty;
            NotesViewModel.Instance.AddNew(dContents.Text);
            StatusMessage.Text = NotesViewModel.Instance.EstadoMensaje;


        }

        private void BListar_Clicked(object sender, EventArgs e)
        {

            var allNotes = NotesViewModel.Instance.GetAll(); //TODAS LAS NOTAS SE ESTAN IGUALANDO EN UNA VARIBALE LOCAL Y EN LA SIGUIENTE LINEA LAS MUESTRA
            listanotas.ItemsSource = allNotes;
            StatusMessage.Text = NotesViewModel.Instance.EstadoMensaje;

        }
    }
}