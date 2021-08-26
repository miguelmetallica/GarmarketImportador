using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFDataAccess;

namespace FormImportar
{
    public partial class ListaDePrecios : Form
    {
        public ListaDePrecios()
        {
            InitializeComponent();
        }
        
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                if(cboSucursal.Text != "") { 
                    if(dgListaPrecios.Rows.Count > 0) 
                    {
                        btnProcesar.Enabled = false;
                        btnCargar.Enabled = false;

                        using (var db = new GASMARKET_TUCUMANEntities(cboSucursal.Text)) 
                        {
                            for(int i = 0; i < dgListaPrecios.Rows.Count; i++) 
                            {
                                string prod = dgListaPrecios["CodigoProducto", i].Value.ToString();

                                if (chkLista31.Checked)
                                { 
                                    var registro = db.GVA17
                                        .Where(x => x.COD_ARTICU == prod
                                        && x.NRO_DE_LIS == 31).FirstOrDefault();

                                    if (registro == null)
                                    {
                                        registro = new GVA17();
                                        registro.COD_ARTICU = prod;
                                        registro.NRO_DE_LIS = 31;
                                        registro.PRECIO = decimal.Round(Convert.ToDecimal(dgListaPrecios["Lista31", i].Value.ToString()),2);
                                        registro.FILLER = "";
                                        registro.FECHA_MODI = DateTime.Now;
                                        registro.BASE = false;
                                        db.Entry(registro).State = System.Data.Entity.EntityState.Added;
                                    }
                                    else 
                                    { 
                                        registro.PRECIO = decimal.Round(Convert.ToDecimal(dgListaPrecios["Lista31", i].Value.ToString()), 2);
                                        registro.FECHA_MODI = DateTime.Now;

                                        db.Entry(registro).State = System.Data.Entity.EntityState.Modified;
                                    }

                                    db.SaveChanges();
                                }

                                if (chkLista30.Checked)
                                {
                                    var registro = db.GVA17
                                        .Where(x => x.COD_ARTICU == prod
                                        && x.NRO_DE_LIS == 30).FirstOrDefault();

                                    if (registro == null)
                                    {
                                        registro = new GVA17();
                                        registro.COD_ARTICU = prod;
                                        registro.NRO_DE_LIS = 30;
                                        registro.PRECIO = decimal.Round(Convert.ToDecimal(dgListaPrecios["Lista30", i].Value.ToString()), 2);
                                        registro.FILLER = "";
                                        registro.FECHA_MODI = DateTime.Now;
                                        registro.BASE = false;
                                        db.Entry(registro).State = System.Data.Entity.EntityState.Added;
                                    }
                                    else
                                    {
                                        registro.PRECIO = decimal.Round(Convert.ToDecimal(dgListaPrecios["Lista30", i].Value.ToString()), 2);
                                        registro.FECHA_MODI = DateTime.Now;

                                        db.Entry(registro).State = System.Data.Entity.EntityState.Modified;
                                    }

                                    db.SaveChanges();
                                }
                        
                                if (chkLista10.Checked)
                                {
                                    var registro = db.GVA17
                                        .Where(x => x.COD_ARTICU == prod
                                        && x.NRO_DE_LIS == 10).FirstOrDefault();

                                    if (registro == null)
                                    {
                                        registro = new GVA17();
                                        registro.COD_ARTICU = prod;
                                        registro.NRO_DE_LIS = 10;
                                        registro.PRECIO = decimal.Round(Convert.ToDecimal(dgListaPrecios["Lista10", i].Value.ToString()), 2);
                                        registro.FILLER = "";
                                        registro.FECHA_MODI = DateTime.Now;
                                        registro.BASE = false;
                                        db.Entry(registro).State = System.Data.Entity.EntityState.Added;
                                    }
                                    else
                                    {
                                        registro.PRECIO = decimal.Round(Convert.ToDecimal(dgListaPrecios["Lista10", i].Value.ToString()), 2);
                                        registro.FECHA_MODI = DateTime.Now;

                                        db.Entry(registro).State = System.Data.Entity.EntityState.Modified;
                                    }

                                    db.SaveChanges();
                                }

                                if (chkLista20.Checked)
                                {
                                    var registro = db.GVA17
                                        .Where(x => x.COD_ARTICU == prod
                                        && x.NRO_DE_LIS == 20).FirstOrDefault();

                                    if (registro == null)
                                    {
                                        registro = new GVA17();
                                        registro.COD_ARTICU = prod;
                                        registro.NRO_DE_LIS = 20;
                                        registro.PRECIO = decimal.Round(Convert.ToDecimal(dgListaPrecios["Lista20", i].Value.ToString()), 2);
                                        registro.FILLER = "";
                                        registro.FECHA_MODI = DateTime.Now;
                                        registro.BASE = false;
                                        db.Entry(registro).State = System.Data.Entity.EntityState.Added;
                                    }
                                    else
                                    {
                                        registro.PRECIO = decimal.Round(Convert.ToDecimal(dgListaPrecios["Lista20", i].Value.ToString()), 2);
                                        registro.FECHA_MODI = DateTime.Now;

                                        db.Entry(registro).State = System.Data.Entity.EntityState.Modified;
                                    }

                                    db.SaveChanges();
                                }

                                if (chkLista40.Checked)
                                {
                                    var registro = db.GVA17
                                        .Where(x => x.COD_ARTICU == prod
                                        && x.NRO_DE_LIS == 40).FirstOrDefault();

                                    if (registro == null)
                                    {
                                        registro = new GVA17();
                                        registro.COD_ARTICU = prod;
                                        registro.NRO_DE_LIS = 40;
                                        registro.PRECIO = decimal.Round(Convert.ToDecimal(dgListaPrecios["Lista40", i].Value.ToString()), 2);
                                        registro.FILLER = "";
                                        registro.FECHA_MODI = DateTime.Now;
                                        registro.BASE = false;
                                        db.Entry(registro).State = System.Data.Entity.EntityState.Added;
                                    }
                                    else
                                    {
                                        registro.PRECIO = decimal.Round(Convert.ToDecimal(dgListaPrecios["Lista40", i].Value.ToString()), 2);
                                        registro.FECHA_MODI = DateTime.Now;

                                        db.Entry(registro).State = System.Data.Entity.EntityState.Modified;
                                    }

                                    db.SaveChanges();
                                }

                                if (chkLista60.Checked)
                                {
                                    var registro = db.GVA17
                                        .Where(x => x.COD_ARTICU == prod
                                        && x.NRO_DE_LIS == 60).FirstOrDefault();

                                    if (registro == null)
                                    {
                                        registro = new GVA17();
                                        registro.COD_ARTICU = prod;
                                        registro.NRO_DE_LIS = 60;
                                        registro.PRECIO = decimal.Round(Convert.ToDecimal(dgListaPrecios["Lista60", i].Value.ToString()), 2);
                                        registro.FILLER = "";
                                        registro.FECHA_MODI = DateTime.Now;
                                        registro.BASE = false;
                                        db.Entry(registro).State = System.Data.Entity.EntityState.Added;
                                    }
                                    else
                                    {
                                        registro.PRECIO = decimal.Round(Convert.ToDecimal(dgListaPrecios["Lista60", i].Value.ToString()), 2);
                                        registro.FECHA_MODI = DateTime.Now;

                                        db.Entry(registro).State = System.Data.Entity.EntityState.Modified;
                                    }

                                    db.SaveChanges();
                                }

                                if (chkLista41.Checked)
                                {
                                    var registro = db.GVA17
                                        .Where(x => x.COD_ARTICU == prod
                                        && x.NRO_DE_LIS == 41).FirstOrDefault();

                                    if (registro == null)
                                    {
                                        registro = new GVA17();
                                        registro.COD_ARTICU = prod;
                                        registro.NRO_DE_LIS = 41;
                                        registro.PRECIO = decimal.Round(Convert.ToDecimal(dgListaPrecios["Lista41", i].Value.ToString()), 2);
                                        registro.FILLER = "";
                                        registro.FECHA_MODI = DateTime.Now;
                                        registro.BASE = false;
                                        db.Entry(registro).State = System.Data.Entity.EntityState.Added;
                                    }
                                    else
                                    {
                                        registro.PRECIO = decimal.Round(Convert.ToDecimal(dgListaPrecios["Lista41", i].Value.ToString()), 2);
                                        registro.FECHA_MODI = DateTime.Now;

                                        db.Entry(registro).State = System.Data.Entity.EntityState.Modified;
                                    }

                                    db.SaveChanges();
                                }

                                if (chkLista71.Checked)
                                {
                                    var registro = db.GVA17
                                        .Where(x => x.COD_ARTICU == prod
                                        && x.NRO_DE_LIS == 71).FirstOrDefault();

                                    if (registro == null)
                                    {
                                        registro = new GVA17();
                                        registro.COD_ARTICU = prod;
                                        registro.NRO_DE_LIS = 71;
                                        registro.PRECIO = decimal.Round(Convert.ToDecimal(dgListaPrecios["Lista71", i].Value.ToString()), 2);
                                        registro.FILLER = "";
                                        registro.FECHA_MODI = DateTime.Now;
                                        registro.BASE = false;
                                        db.Entry(registro).State = System.Data.Entity.EntityState.Added;
                                    }
                                    else
                                    {
                                        registro.PRECIO = decimal.Round(Convert.ToDecimal(dgListaPrecios["Lista71", i].Value.ToString()), 2);
                                        registro.FECHA_MODI = DateTime.Now;

                                        db.Entry(registro).State = System.Data.Entity.EntityState.Modified;
                                    }

                                    db.SaveChanges();
                                }

                                if (chkLista27.Checked)
                                {
                                    var registro = db.GVA17
                                        .Where(x => x.COD_ARTICU == prod
                                        && x.NRO_DE_LIS == 27).FirstOrDefault();

                                    if (registro == null)
                                    {
                                        registro = new GVA17();
                                        registro.COD_ARTICU = prod;
                                        registro.NRO_DE_LIS = 27;
                                        registro.PRECIO = decimal.Round(Convert.ToDecimal(dgListaPrecios["Lista27", i].Value.ToString()), 2);
                                        registro.FILLER = "";
                                        registro.FECHA_MODI = DateTime.Now;
                                        registro.BASE = false;
                                        db.Entry(registro).State = System.Data.Entity.EntityState.Added;
                                    }
                                    else
                                    {
                                        registro.PRECIO = decimal.Round(Convert.ToDecimal(dgListaPrecios["Lista27", i].Value.ToString()),2);
                                        registro.FECHA_MODI = DateTime.Now;

                                        db.Entry(registro).State = System.Data.Entity.EntityState.Modified;
                                    }

                                    db.SaveChanges();
                                }
                            }
                        }

                        MessageBox.Show("Los datos se guardaron correctamente","Informacion");
                        btnProcesar.Enabled = true;
                        btnCargar.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
                btnProcesar.Enabled = true;
                btnCargar.Enabled = true;
            }

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "ARCHIVOS XLS(*.xls)|*.xls";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            //MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
            if (filePath != "")
            {
                dgListaPrecios.Rows.Clear();
                using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        do
                        {
                            while (reader.Read())
                            {
                                if (reader.Name.ToUpper() == "PRECIOS")
                                {
                                    if (reader.GetValue(0).ToString().ToUpper() != "COD_ARTICU")
                                    {
                                        decimal Lista31 = Math.Round(Convert.ToDecimal(reader.GetValue(3)), 4);
                                        decimal Lista30 = Math.Round(Convert.ToDecimal(reader.GetValue(4)), 4);
                                        decimal Lista10 = Math.Round(Convert.ToDecimal(reader.GetValue(5)), 4);
                                        decimal Lista20 = Math.Round(Convert.ToDecimal(reader.GetValue(6)), 4);
                                        decimal Lista40 = Math.Round(Convert.ToDecimal(reader.GetValue(7)), 4);
                                        decimal Lista60 = Math.Round(Convert.ToDecimal(reader.GetValue(8)), 4);
                                        decimal Lista41 = Math.Round(Convert.ToDecimal(reader.GetValue(9)), 4);
                                        decimal Lista71 = Math.Round(Convert.ToDecimal(reader.GetValue(10)), 4);
                                        decimal Lista27 = Math.Round(Convert.ToDecimal(reader.GetValue(11)), 4);

                                        dgListaPrecios.Rows.Add(
                                                                reader.GetValue(0),
                                                                reader.GetValue(1),
                                                                Lista31,
                                                                Lista30,
                                                                Lista10,
                                                                Lista20,
                                                                Lista40,
                                                                Lista60,
                                                                Lista41,
                                                                Lista71,
                                                                Lista27
                                                                );
                                    }
                                }

                            }
                        } while (reader.NextResult());

                    }
                }

            }
        }
    }
}
