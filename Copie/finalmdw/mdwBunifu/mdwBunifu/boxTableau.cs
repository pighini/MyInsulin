using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdwBunifu
{
    public partial class boxTableau : UserControl
    {
        Control[] lblDates;
        Control[] lblTypes;
        string oldDate = DateTime.Now.ToShortDateString();

        private ModelMeasure _model;

        public ModelMeasure Model
        {
            get { return _model; }
            set { _model = value; }
        }
        int cpt = 0;
        int cptType = 0;

        public boxTableau(ModelMeasure mod)
        {
            InitializeComponent();
            lblDates = Controls.Find("lblDate", true);
            lblTypes = Controls.Find("lblType", true);
            this.Model = mod;
            GenerateTable();
        }
        private void GenerateTable()
        {
            cpt = 0;
            cptType = 0;
            lblDates = Controls.Find("lblDate", true);
            lblTypes = Controls.Find("lblType", true);
            List<string> insertedTypes = new List<string>();
            foreach (string type in Model.GetAllTypes())
            {

                if (!insertedTypes.Exists(s => s == type))
                {
                    insertedTypes.Add(type);
                    addType(type);
                    addColumn();

                    cptType++;


                }

            }
            foreach (Measure mes in this.Model.GetMesureWeekly(8, "DAY"))
            {
                if (mes.DateMesure != oldDate)
                {
                    addDate(mes.DateMesure);
                    addRow();
                    cpt++;
                }


                
                oldDate = mes.DateMesure;
                
                fillWithValue(mes);
            }
            addRow();

        }
        private void addRow()
        {

            Panel sepa = new Panel
            {
                BackColor = System.Drawing.Color.White,
                Location = new System.Drawing.Point(0, 63 + (cpt * 48)),
                Size = new System.Drawing.Size(530, 1)
            };
            this.Controls.Add(sepa);

        }
        private void fillWithValue(Measure mes)
        {


            int line;
            int col;
            int x;
            int y;
            IEnumerable<Label> labels = Controls.OfType<Label>();
            Label lbl = labels.Where(l => l.Text == mes.DateMesure).ToArray()[0];


            //Positionne et fix la valeur
            line = (int)lbl.Tag;
            lbl = labels.Where(l => l.Text == mes.Type).ToArray()[0];
            col = (int)lbl.Tag;
            x = 110 + (col * 70);
            y = 87 + (line * 46);
            //addValueToTab(mes.IdMesure, mes.Poids, x, y);

        }
        private void addDate(string dateTime)
        {
            Label date = new Label
            {
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = System.Drawing.Color.White,
                Location = new System.Drawing.Point(5, 87 + (cpt * 46)),
                Name = "lblDate" + cpt
            };
            ;
            date.Tag = cpt;
            date.Size = new System.Drawing.Size(90, 20);
            date.Text = dateTime;
            this.Controls.Add(date);
        }
        private void addType(string typeMesure)
        {
            Label type = new Label
            {
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = System.Drawing.Color.White,
                Location = new System.Drawing.Point(110 + (cptType * 70), 30),
                Name = "lbl" + cptType,
                Tag = cptType,
                Size = new System.Drawing.Size(50, 30),
                Text = typeMesure
            };
            this.Controls.Add(type);
        }
        private void addColumn()
        {

            Panel sepa = new Panel
            {
                BackColor = System.Drawing.Color.White,
                Location = new System.Drawing.Point(165 + (cptType * 70), 0),
                Size = new System.Drawing.Size(1, 400)
            };
            this.Controls.Add(sepa);

        }
        private void addValueToTab(int id, int value, int x, int y)
        {
            Label val = new Label
            {
                Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = System.Drawing.Color.White,
                Location = new System.Drawing.Point(x, y),
                Name = "lblMesure" + id,
                Tag = id,
                Size = new System.Drawing.Size(35, 20),
                Text = value.ToString()
            };
            val.Click += new EventHandler(lblValue_Click);
            this.Controls.Add(val);

        }

        private void lblValue_Click(object sender, EventArgs e)
        {
            Label myFriend = (Label)sender;
            var parent = this.Parent;
           
            
            this.Hide();
            this.Model.Mes = this.Model.GetMesureById((int)myFriend.Tag);
            boxMesures bxM = new boxMesures(this.Model, true)
            {
                Location = new Point(20, 7),
                Visible = true,
                Name = "Menu"
            };
            parent.Controls.Add(bxM);
          


        }
    }
}
