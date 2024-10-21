using System.Collections;

namespace Problem_1
{
    public partial class Enunciado1 : Form
    {
        List<Mascota> G11_lstMascota = new List<Mascota>();
        ArrayList G11_arrayCombo = new ArrayList();
        public Enunciado1()
        {
            InitializeComponent();
        }

        private void Enunciado1_Load(object sender, EventArgs e)
        {
            dgvMascota.Columns.Add("Name", "Nombre");
            dgvMascota.Columns.Add("Age", "Edad");
            dgvMascota.Columns.Add("Race", "Raza");
            dgvMascota.Columns.Add("Owner", "Dueño");
            dgvMascota.Rows.Clear();
        }

        private void btn_registroDueño_Click(object sender, EventArgs e)
        {
            Dueño G11_Dueño = new Dueño();
            G11_Dueño.G11_nombre = txt_Dnombre.Text;
            G11_Dueño.G11_direccion = txt_Ddireccion.Text;
            G11_Dueño.G11_telefono = txt_Dtelefono.Text;
            if (string.IsNullOrWhiteSpace(txt_Dnombre.Text))
            {
                MessageBox.Show("El campo Nombre no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Dnombre.Focus();
                return;
            }
            G11_arrayCombo.Add(txt_Dnombre.Text);
            cbo_Mdueño.Items.Clear();
            foreach (string G5_ITEM in G11_arrayCombo)
                cbo_Mdueño.Items.Add(G5_ITEM);
            txt_Dnombre.Text = "";
            txt_Ddireccion.Text = "";
            txt_Dtelefono.Text = "";
        }

        private void btn_registroMascota_Click(object sender, EventArgs e)
        {

            try
            {
                Mascota G11_Mascota = new Mascota();
                G11_Mascota.G11_nombre = txt_Mnombre.Text;
                G11_Mascota.G11_edad = txt_Medad.Text;
                G11_Mascota.G11_raza = txt_Mraza.Text;
                G11_Mascota.G11_dueño = cbo_Mdueño.SelectedItem.ToString();

                if (string.IsNullOrWhiteSpace(txt_Mnombre.Text))
                {
                    MessageBox.Show("El campo Nombre no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Dnombre.Focus();
                    return;
                }

                G11_lstMascota.Add(G11_Mascota);
                MostrarLista();
                txt_Mnombre.Text = "";
                txt_Medad.Text = "";
                txt_Mraza.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingresa un valor en el campo Dueño", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void MostrarLista()
        {
            dgvMascota.Rows.Clear();
            foreach (Mascota item in G11_lstMascota)
            {
                dgvMascota.Rows.Add(item.getData());
            }
        }

        private void cbo_Mdueño_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_Dtelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_BMbuscar_Click(object sender, EventArgs e)
        {
            Mascota mascotaEncontrada = G11_lstMascota.Find(p => p.G11_nombre == txt_BMnombre.Text);
            if (mascotaEncontrada != null)
            {
                lbl_resbusquedaMascota.Text = "Se encontro la mascota con nombre " + mascotaEncontrada.G11_nombre.ToString();
            }
            else
            {
                lbl_resbusquedaMascota.Text = "Mascota no encontrado";
            }
        }
    }
}
