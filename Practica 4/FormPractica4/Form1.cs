using static Biblioteca2_Practica4.Tempos;
namespace FormPractica4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initializeDataComboBox();
        }

        public void initializeDataComboBox()
        {
            foreach(int i in Enum.GetValues(typeof(Horas))) 
            {
                horaInicioComboBox.Items.Add(i);
            }

            foreach(int i in Enum.GetValues(typeof (Horas)))
            {
                horaFinComboBox.Items.Add(i);
            }

            amPmComboBox.Items.AddRange(Enum.GetNames(typeof(Horario)));
            horaInicioComboBox.SelectedIndex = 0;
            horaFinComboBox.SelectedIndex = 0;
            amPmComboBox.SelectedIndex = 0;

        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            string materia, inicio, fin, horario, mensaje;
            materia = nombreMateriaTextBox.Text;
            inicio = horaInicioComboBox.Text.ToString();
            fin = horaFinComboBox.Text.ToString();
            horario = amPmComboBox.Text.ToString();

            if (string.IsNullOrEmpty(materia) || string.IsNullOrWhiteSpace(materia))
            {
                MessageBox.Show("Escriba una Materia");
                return;
            }

            mensaje = $"Materia: {materia}, hora de inicio: {inicio}, hora de finalizacíon: {fin}, horario: {horario}";
            horariosListBox.Items.Add(mensaje);
            nombreMateriaTextBox.Clear();
        }
    }
}