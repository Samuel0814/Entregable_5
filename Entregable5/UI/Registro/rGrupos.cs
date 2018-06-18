using Entregable5.DAL;
using Entregable5.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace Entregable5.UI.Registro
{
    public partial class rGrupos : Form
    {
        public rGrupos()
        {
            InitializeComponent();
            LlenarComboBox;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(GrupoIdnumericUpDown.Value);
            Grupos Grupo = BLL.GruposBLL.Buscar(id);

            if (Grupo != null)
            {
                LlenarCampos(Grupo);
            }
            else
                MessageBox.Show("No se encontro!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            GrupoIdnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;

            DescripciontextBox.Clear();
            MyerrorProvider.Clear();
        }

        private void FechadateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Grupos Grupo;
            bool Paso = false;

            if (HayErrores())
            {
                MessageBox.Show("Favor revisar todos los campos", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Grupo = LlenaClase();

            //Determinar si es Guardar o Modificar
            if (GrupoIdnumericUpDown.Value == 0)
                Paso = BLL.GruposBLL.Guardar(Grupo);
            else
                //todo: validar que exista.
                Paso = BLL.GruposBLL.Modificar(Grupo);

            //Informar el resultado
            if (Paso)
            {
                Nuevobutton.PerformClick();
                MessageBox.Show("Guardado!!", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(GrupoIdnumericUpDown.Value);

            //todo: validar que exista
            if (BLL.GruposBLL.Eliminar(id))
                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LlenarComboBox()
        {
            Repositorio<Grupos> repositorio = new Repositorio<Grupos>(new Contexto());
            CiudadcomboBox.DataSource = repositorio.GetList(c => true);
            CiudadcomboBox.ValueMember = "CiudadId";
            CiudadcomboBox.DisplayMember = "Nombre";
        }

        private Visitas LlenaClase()
        {
            Visitas visita = new Visitas();

            visita.VisitaId = Convert.ToInt32(IdnumericUpDown.Value);
            visita.Fecha = fechaDateTimePicker.Value;
            visita.Comentarios = comentariosTextBox.Text;

            //Agregar cada linea del Grid al detalle
            foreach (DataGridViewRow item in detalleDataGridView.Rows)
            {
                visita.AgregarDetalle(
                    ToInt(item.Cells["Id"].Value),
                    ToInt(item.Cells["VisitaId"].Value),
                    ToInt(item.Cells["CiudadId"].Value),
                    ToInt(item.Cells["Cantidad"].Value)
                  );
            }
            return visita;
        }

        private void LlenarCampos(Grupos Grupo)
        {
            GrupoIdnumericUpDown.Value = Grupo.GrupoId;
            FechadateTimePicker.Value = Grupo.Fecha;

            //Cargar el detalle al Grid
            DescripciontextBox.DataSource = Grupo.Detalle;

            //Ocultar columnas
            DescripciontextBox.Columns["Id"].Visible = false;
            DescripciontextBox.Columns["CiudadId"].Visible = false;
        }

        private void DescripciontextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
