using Entregable5.DAL;
using Entregable5.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace Entregable5.BLL
{
    public class GruposBLL
    {
        public static bool Guardar(Grupos Grupo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Grupo.Add(Grupo) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return paso;
        }
        public static bool Modificar(Grupos Grupo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(Grupo).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return paso;
        }
        public static bool Eliminar(int GrupoId)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                Grupos Grupo = contexto.Grupo.Find(GrupoId);
                contexto.Grupo.Remove(Grupo);
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return paso;
        }
        public static Grupos Buscar(int GrupoId)
        {
            Contexto contexto = new Contexto();
            Grupos Grupo = new Grupos();
            try
            {
                Grupo = contexto.Grupo.Find(GrupoId);
                contexto.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return Grupo;
        }
        public static List<Grupos> GetList(Expression<Func<Grupos, bool>> expression)
        {
            List<Grupos> Grupo = new List<Grupos>();
            Contexto contexto = new Contexto();
            try
            {
                Grupo = contexto.Grupo.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return Grupo;
        }
    }
}
